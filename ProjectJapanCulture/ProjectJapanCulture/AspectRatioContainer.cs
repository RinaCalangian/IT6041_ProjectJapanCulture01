using Xamarin.Forms;

// This is being used by ActivityDetailPage.xaml, LocationDetailPage.xaml, DetailsActivity.xaml, DetailsLocation.xaml
// This has fixed the issue of the image getting clipped when the device is rotated
// The images inside the layout will automatically conform to the dimensions of the layout, while maintaining their aspect ratio

namespace ProjectJapanCulture
{
    public class AspectRatioContainer : ContentView
    {
        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            return new SizeRequest(new Size(widthConstraint, widthConstraint * this.AspectRatio));
        }

        public static BindableProperty AspectRatioProperty = BindableProperty.Create(nameof(AspectRatio), typeof(double), typeof(AspectRatioContainer), (double)1);

        public double AspectRatio
        {
            get { return (double) this.GetValue(AspectRatioProperty); }
            set
            {
                this.SetValue(AspectRatioProperty, value);
            }
        }
    }
}
