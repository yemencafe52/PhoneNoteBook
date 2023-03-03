namespace PhoneBookv3
{
    internal static class Constants
    {
        private static string dbPath = System.IO.Directory.GetCurrentDirectory() + "\\DataBase\\db.accdb";
        private static string connectionString = $"Provider=Microsoft.ace.oledb.12.0;data source={dbPath}";
        internal static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }
    }
}
