using System.Data.SqlClient;

namespace Skork_Engine_Library.Database {
    public class DatabaseController {

        public DatabaseController() {

        }

        public bool Login(string username, string password) {
            try {
                LoginHelper(username, password);
            }
        }

        private void LoginHelper(string username, string password) {
            SqlConnection conn = new SqlConnection(DatabaseInstance.DB_INSTANCE);
            conn.Open();

            SqlCommand cmd = new SqlCommand($"SELECT user_id from [USER] where username = {username} and password_hash = {password}",conn);
            if (cmd.ExecuteNonQuery() != 0);
        }
    }
}
