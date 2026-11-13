using Microsoft.Data.SqlClient;

namespace activity_3
{
    public static class Database
    {
        public const string ConnectionString =
            @"Server=(localdb)\MSSQLLocalDB;Database=activity3_db;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}