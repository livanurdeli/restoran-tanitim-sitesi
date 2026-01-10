using System;
using System.Data.SqlClient;

namespace wtproje2.Classes
{
    public class SqlConnectionClass
    {
        // Static connection nesnesi
        static SqlConnection connection = new SqlConnection("Data Source=LENOVO\\MSSQLSERVER01;Initial Catalog=CafeContact;Integrated Security=True");

        // Bağlantıyı kontrol eden static method
        public static void CheckConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Bağlantıyı kapatma methodu (isteğe bağlı)
        public static void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
