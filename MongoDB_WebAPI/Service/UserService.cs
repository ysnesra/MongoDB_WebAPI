using MongoDB.Driver;
using MongoDB_WebAPI.Model;
using MongoDB_WebAPI.Settings;
using System.Collections.Generic;

namespace MongoDB_WebAPI.Service
{
    public class UserService
    {
        private IDbSettings _settings;
        private IMongoCollection<User> _user;

        //Connection Stringimiz ile mongoDB Client a erişiriz
        //Clienttan da database e erişiriz
        //Collectiona(Tabloya) erişmek içinde; User classımızla users collectionımızı(tablomuzu) ilişkilendirdik
        public UserService(IDbSettings settings)
        {
            _settings = settings;
            MongoClient client = new MongoClient(settings.ConnectionString);
            var db = client.GetDatabase(settings.Database);
            _user = db.GetCollection<User>(settings.Collection);
        }

        //Tümünü Listeleme
        public List<User> GetAll()
        {
            return _user.Find(u => true).ToList();
        }

        //Tek bir kullanıcı getirme
        public User GetSingle(string id)
        {
            return _user.Find(u => u.Id == id).FirstOrDefault();
        }

        //Kullanıcı ekleme
        public User Add(User user)
        {
            _user.InsertOne(user);
            return user;
        }

        //Kullanıcı güncelleme
        public long Update(User currentUser)
        {
            //ReplaceOne : databasede koleksiyonda(tabloda) güncelleme yapan komut
            //ModifiedCount : değiştirilen satır sayısını tutar. Bu, kullanıcının güncellenip güncellenmediğini belirlemek için kullanılılır
            return _user.ReplaceOne(u => u.Id == currentUser.Id, currentUser).ModifiedCount;
        }

        //Kullanıcı silme
        public long Delete(string id)
        {
            return _user.DeleteOne(u => u.Id == id).DeletedCount;
        }

    }
}