namespace MongoDB_WebAPI.Settings
{
    //appsettings dosyasında bu değişkenlerin değeri verildi.
    public class MongoDbSettings : IDbSettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
    }
}

