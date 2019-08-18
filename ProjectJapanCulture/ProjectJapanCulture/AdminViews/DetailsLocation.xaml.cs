using Microsoft.WindowsAzure.Storage;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsLocation : ContentPage
	{
        string url;

        public DetailsLocation ()
		{
			InitializeComponent ();
		}

        // action to open Photo Gallery
        async void SelectImageButton_Clicked(object sender, EventArgs e)
        {
            // added using Plugin.Media
            await CrossMedia.Current.Initialize();

            // added to define selecting photo from the gallery
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Error", "This is not supported on your device", "Ok");
                return;
            }

            // added using Plugin.Media.Abstractions
            // added to have the option to resize image
            var mediaOptions = new PickMediaOptions()
            {
                PhotoSize = PhotoSize.Custom,
                CustomPhotoSize = 50,
                CompressionQuality = 90
            };

            // added to define media option to pick photo
            var selectedImageFile = await CrossMedia.Current.PickPhotoAsync(mediaOptions);

            if (selectedImage == null)
            {
                await DisplayAlert("Error", "There was an error when trying to get your image", "Ok");
                return;
            }

            selectedImage.Source = ImageSource.FromStream(() => selectedImageFile.GetStream());

            // added using System.IO
            UploadImage(selectedImageFile.GetStream());
        }

        // added using Microsoft.WindowsAzure.Storage
        // uses key1 Connection string of imagestoragemobileproj1 in azure
        // uses created container name in imagestoragemobileproj1 in azure
        private async void UploadImage(Stream stream)
        {
            var account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=imagestoragemobileproj1;" +
                "AccountKey=2DkqAMraRdl8Cohf/338dpJZhBTf9bmzYVLYOrG5PDg8xc4cDkCRgMF7orumkjDz9ZjrcAUYf6LyGwF7ZDeP7A==;EndpointSuffix=core.windows.net"); // key1 connection string
            var client = account.CreateCloudBlobClient();
            var container = client.GetContainerReference("imagecontainer"); // container name
            await container.CreateIfNotExistsAsync(); // to create the container if it does not exist; will be ignored otherwise


            var name = Guid.NewGuid().ToString(); // a method that is always going to be creating an entirely different string (unique name)
            var blockBlob = container.GetBlockBlobReference($"{name}.jpg"); // a blob reference for a unique stream (image name of type string)
            await blockBlob.UploadFromStreamAsync(stream); // to upload a byte, array, or a file or text and pass the stream (to upload the image)

            url = blockBlob.Uri.OriginalString;
        }

        // action to save the changes made
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var locationItem = (Models.Locations)BindingContext;

            if (url != null)
            { locationItem.CityImage = url; }
            else
            {
                locationItem.CityImage = locationItem.CityImage;
            };

            await App.Database.SaveItemAsync7(locationItem);
            await Navigation.PopAsync();
        }

        // action to delete the location
        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var locationItem = (Models.Locations)BindingContext;
            await App.Database.DeleteItemAsync7(locationItem);
            await Navigation.PopAsync();
        }
    }
}