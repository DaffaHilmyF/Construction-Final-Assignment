namespace TUBES_FINAL.Database
{
    using System;
    using System.Data;
    using MySql.Data;
    using MySql.Data.MySqlClient;

    sealed class DBConn
    {
        private readonly string _connString = "server=localhost;user=root;database=kpl_tubes;port=3306;password=";
        private static DBConn _createConnection = null;
        public static MySqlConnection Connection;
        public static MySqlCommand Command;
        public static MySqlDataReader Reader;


        private DBConn()
        {
            try
            {
                Connection = new MySqlConnection(_connString);
                Console.WriteLine("Connecting to MySQL...");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace);
            }
            
        }

        public static DBConn CreateConnection
        {
            get
            {
                if (_createConnection == null)
                    _createConnection = new DBConn();

                return _createConnection;
            }
        }

    }
}
