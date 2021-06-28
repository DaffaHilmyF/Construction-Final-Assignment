namespace TUBES_FINAL.Database
{
    using TUBES_FINAL.Model;
    using System;
    using System.Collections.Generic;
    using MySql.Data.MySqlClient;

    public static class DBLecturer
    {
        private static LecturerModel _lecturer;
        private static List<LecturerModel> _lecturerList;
        private static string _queryString;

        public static List<LecturerModel> GetAllLecturer()
        {
            try
            {
                _lecturerList = new List<LecturerModel>();
                _queryString = "SELECT * FROM dosen";
                DBConn.Connection.Open();
                DBConn.Command = new MySqlCommand(_queryString, DBConn.Connection);
                DBConn.Reader = DBConn.Command.ExecuteReader();

                while (DBConn.Reader.Read())
                {
                    _lecturerList.Add(
                        new LecturerModel(
                            DBConn.Reader["id_dosen"].ToString(),
                            DBConn.Reader["nama_dosen"].ToString(),
                            DBConn.Reader["email_dosen"].ToString(),
                            DBConn.Reader["password_dosen"].ToString(),
                            DBConn.Reader["nidn_dosen"].ToString()
                            )
                        );
                }

                DBConn.Reader.Close();
                DBConn.Connection.Close();
                return _lecturerList;

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace);
                return null;
            }
        }

        public static LecturerModel GetLecturerByNIDN(string NIDN)
        {
            try
            {
                _queryString = $"SELECT * FROM dosen WHERE nidn_dosen = '{NIDN}'";
                DBConn.Connection.Open();
                DBConn.Command = new MySqlCommand(_queryString, DBConn.Connection);
                DBConn.Reader = DBConn.Command.ExecuteReader();

                while (DBConn.Reader.Read())
                {
                    _lecturer = new LecturerModel(
                            DBConn.Reader["id_dosen"].ToString(),
                            DBConn.Reader["nama_dosen"].ToString(),
                            DBConn.Reader["email_dosen"].ToString(),
                            DBConn.Reader["password_dosen"].ToString(),
                            DBConn.Reader["nidn_dosen"].ToString()
                        );
                }

                DBConn.Reader.Close();
                DBConn.Connection.Close();
                return _lecturer;

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace);
                return null;
            }
        }

        public static void InsertLecturer(LecturerModel lecturer)
        {
            try
            {
                _queryString = $"INSERT INTO dosen (nama_dosen, nidn_dosen, email_dosen, password_dosen)" +
                    $" VALUES ('{lecturer.PersonName}', '{lecturer.LecturerNIDN}', '{lecturer.PersonEmail}', '{lecturer.PersonPassword}')";
                DBConn.Connection.Open();
                DBConn.Command = new MySqlCommand(_queryString, DBConn.Connection);
                DBConn.Command.ExecuteNonQuery();
                DBConn.Connection.Close();

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace);
            }

            Console.WriteLine($"Insert data {lecturer.LecturerNIDN} success");

        }

        public static void DeleteLecturerByNIM(string NIDN)
        {
            try
            {
                _queryString = $"DELETE FROM dosen WHERE nidn_dosen = '{NIDN}'";
                DBConn.Connection.Open();
                DBConn.Command = new MySqlCommand(_queryString, DBConn.Connection);
                DBConn.Command.ExecuteNonQuery();
                DBConn.Connection.Close();
                Console.WriteLine($"Delete data {NIDN} success");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace);
            }


        }

        public static void UpdateLecturer(string nidn, string name, string email, string password)
        {
            try
            {
                _queryString = $"UPDATE dosen SET nama_dosen = {name}, email_dosen = {email}, " +
                    $"password_dosen = {password} WHERE nidn_dosen = '{nidn}'";
                DBConn.Connection.Open();
                DBConn.Command = new MySqlCommand(_queryString, DBConn.Connection);
                DBConn.Command.ExecuteNonQuery();
                DBConn.Connection.Close();
                Console.WriteLine($"Update data {nidn} success");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace);
            }
        }
    }
}
