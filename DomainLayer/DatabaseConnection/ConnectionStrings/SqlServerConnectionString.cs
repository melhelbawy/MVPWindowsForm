using System.Data.SqlClient;

namespace Domain.DatabaseConnection.ConnectionStrings
{
    public class SqlServerConnectionString
    {
        public static string Connection()
        {
            return ConnectionDetails();
        }
        private static string ConnectionDetails()
        {
            return new SqlConnectionStringBuilder()
            {
                DataSource = @".\SQLEXPRESS", // Configuring Server
                ApplicationName = "ELhelbawi-MVPPAttern",
                IntegratedSecurity = true,
                InitialCatalog = "MVPPatternDB"
            }.ConnectionString;
        }
    }
}
