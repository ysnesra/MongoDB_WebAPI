namespace MongoDB_WebAPI.Settings
{
    public interface IDbSettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
    }
}
