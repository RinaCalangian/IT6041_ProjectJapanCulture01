
using System.Collections.Generic;

using System.Threading.Tasks;
using ProjectJapanCulture.Models;
using SQLite;


// Declares the constructor ProjectDatabase which takes the path for the database file as an argument
// On this page, tables are created (for classes in Models folder)
// The remainder of the ProjectDatabase class contains SQLite queries that run cross-platform
namespace ProjectJapanCulture.Data
{
    public class ProjectDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ProjectDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<PhrasesAccomodation>().Wait();
            database.CreateTableAsync<PhrasesExpressions>().Wait();
            database.CreateTableAsync<PhrasesFacilities>().Wait();
            database.CreateTableAsync<PhrasesFood>().Wait();
            database.CreateTableAsync<PhrasesGeneral>().Wait();
            database.CreateTableAsync<PhrasesTime>().Wait();
            database.CreateTableAsync<Locations>().Wait();
            database.CreateTableAsync<Activities>().Wait();
        } 

        // CRUD for class PhrasesAccomodation
        public Task<List<Models.PhrasesAccomodation>> GetItemsAsync()
        {
            return database.Table<Models.PhrasesAccomodation>().ToListAsync();
        }

        public Task<List<Models.PhrasesAccomodation>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Models.PhrasesAccomodation>("SELECT * FROM [Models.PhrasesAccomodation] WHERE [Done] = 0");
        }

        public Task<Models.PhrasesAccomodation> GetItemAsync(int id)
        {
            return database.Table<Models.PhrasesAccomodation>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Models.PhrasesAccomodation item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Models.PhrasesAccomodation item)
        {
            return database.DeleteAsync(item);
        }

        // CRUD for class PhrasesExpressions
        public Task<List<Models.PhrasesExpressions>> GetItemsAsync2()
        {
            return database.Table<Models.PhrasesExpressions>().ToListAsync();
        }

        public Task<List<Models.PhrasesExpressions>> GetItemsNotDoneAsync2()
        {
            return database.QueryAsync<Models.PhrasesExpressions>("SELECT * FROM [Models.PhrasesExpressions] WHERE [Done] = 0");
        }

        public Task<Models.PhrasesExpressions> GetItemAsync2(int id)
        {
            return database.Table<Models.PhrasesExpressions>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync2(Models.PhrasesExpressions item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync2(Models.PhrasesExpressions item)
        {
            return database.DeleteAsync(item);
        }

        // CRUD for class PhrasesFacilities
        public Task<List<Models.PhrasesFacilities>> GetItemsAsync3()
        {
            return database.Table<Models.PhrasesFacilities>().ToListAsync();
        }

        public Task<List<Models.PhrasesFacilities>> GetItemsNotDoneAsync3()
        {
            return database.QueryAsync<Models.PhrasesFacilities>("SELECT * FROM [Models.PhrasesFacilities] WHERE [Done] = 0");
        }

        public Task<Models.PhrasesFacilities> GetItemAsync3(int id)
        {
            return database.Table<Models.PhrasesFacilities>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync4(Models.PhrasesFacilities item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync3(Models.PhrasesFacilities item)
        {
            return database.DeleteAsync(item);
        }
        
        // CRUD for class PhrasesFood
        public Task<List<Models.PhrasesFood>> GetItemsAsync4()
        {
            return database.Table<Models.PhrasesFood>().ToListAsync();
        }

        public Task<List<Models.PhrasesFood>> GetItemsNotDoneAsync4()
        {
            return database.QueryAsync<Models.PhrasesFood>("SELECT * FROM [Models.PhrasesFood] WHERE [Done] = 0");
        }

        public Task<Models.PhrasesFood> GetItemAsync4(int id)
        {
            return database.Table<Models.PhrasesFood>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync4(Models.PhrasesFood item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync4(Models.PhrasesFood item)
        {
            return database.DeleteAsync(item);
        }

        // CRUD for class PhrasesGeneral
        public Task<List<Models.PhrasesGeneral>> GetItemsAsync5()
        {
            return database.Table<Models.PhrasesGeneral>().ToListAsync();
        }

        public Task<List<Models.PhrasesGeneral>> GetItemsNotDoneAsync5()
        {
            return database.QueryAsync<Models.PhrasesGeneral>("SELECT * FROM [Models.PhrasesGeneral] WHERE [Done] = 0");
        }

        public Task<Models.PhrasesGeneral> GetItemAsync5(int id)
        {
            return database.Table<Models.PhrasesGeneral>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync5(Models.PhrasesGeneral item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync5(Models.PhrasesGeneral item)
        {
            return database.DeleteAsync(item);
        }

        // CRUD for class PhrasesTime
        public Task<List<Models.PhrasesTime>> GetItemsAsync6()
        {
            return database.Table<Models.PhrasesTime>().ToListAsync();
        }

        public Task<List<Models.PhrasesTime>> GetItemsNotDoneAsync6()
        {
            return database.QueryAsync<Models.PhrasesTime>("SELECT * FROM [Models.PhrasesTime] WHERE [Done] = 0");
        }

        public Task<Models.PhrasesTime> GetItemAsync6(int id)
        {
            return database.Table<Models.PhrasesTime>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync6(Models.PhrasesTime item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync6(Models.PhrasesTime item)
        {
            return database.DeleteAsync(item);
        }

        // CRUD for class Locations
        public Task<List<Models.Locations>> GetItemsAsync7()
        {
            return database.Table<Models.Locations>().ToListAsync();
        }

        public Task<List<Models.Locations>> GetItemsNotDoneAsync7()
        {
            return database.QueryAsync<Models.Locations>("SELECT * FROM [Models.Locations] WHERE [Done] = 0");
        }

        public Task<Models.Locations> GetItemAsync7(int id)
        {
            return database.Table<Models.Locations>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync7(Models.Locations item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync7(Models.Locations item)
        {
            return database.DeleteAsync(item);
        }

        // CRUD for class Activities
        public Task<List<Models.Activities>> GetItemsAsync8()
        {
            return database.Table<Models.Activities>().ToListAsync();
        }

        public Task<List<Models.Activities>> GetItemsNotDoneAsync8()
        {
            return database.QueryAsync<Models.Activities>("SELECT * FROM [Models.Activities] WHERE [Done] = 0");
        }

        public Task<Models.Activities> GetItemAsync8(int id)
        {
            return database.Table<Models.Activities>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync8(Models.Activities item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync8(Models.Activities item)
        {
            return database.DeleteAsync(item);
        }
    }
}
