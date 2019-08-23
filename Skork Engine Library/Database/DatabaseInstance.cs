namespace Skork_Engine_Library.Database {

    /// <summary>
    /// The <see cref="DatabaseInstance"/> class.
    /// 
    /// <para>The <see cref="DatabaseInstance"/> class contains
    /// a connection to the database.</para>
    /// </summary>
    internal class DatabaseInstance {

        public static string DB_INSTANCE = "Server=tcp:skork-engine.database.windows.net,1433;Initial Catalog=skork;Persist Security Info=False;User ID=z;Password=z;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        internal DatabaseInstance() {

        }

        

    }
}
