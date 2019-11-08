using System.Configuration;

namespace Skork.Data
{
    internal static class SkorkConnection
    {
        static SkorkConnection()
        {
            GetConnectionString = ConfigurationManager.ConnectionStrings["skork_database"].ConnectionString;
        }

        public static string GetConnectionString { get; }
    }
}
