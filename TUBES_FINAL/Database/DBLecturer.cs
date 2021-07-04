namespace TUBES_FINAL.Database
{
    using TUBES_FINAL.Model;
    using System;
    using System.Collections.Generic;
    using MySql.Data.MySqlClient;

    public static class DBLecturer
    {
        private static LecturerModel lecturerData;
        private static List<LecturerModel> lecturerList;
        private static string queryString;

        public static List<LecturerModel> GetAllLecturer()
        {
            try
            {
                lecturerList = new List<LecturerModel>();
                queryString = "SELECT * FROM dosen";
                DBConn.Connection.Open();
                DBConn.Command = new MySqlCommand(queryString, DBConn.Connection);
                DBConn.Reader = DBConn.Command.ExecuteReader();

                while (DBConn.Reader.Read())
                {
                    lecturerList.Add(
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
                return lecturerList;

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace);
                return null;
            }
        }

        internal static void UpdateLecturer(string indexUser, LecturerModel lecturer)
        {
            try
            {
                queryString =   $"UPDATE `dosen` SET " +
                                $"`nama_dosen`= '{lecturer.PersonName}'," + 
                                $"`email_dosen`= '{lecturer.PersonEmail}'," +
                                $"`password_dosen`= '{lecturer.PersonPassword}' " +
                                $"WHERE `nidn_dosen` = '{indexUser}';";

                DBConn.Connection.Open();
                DBConn.Command = new MySqlCommand(queryString, DBConn.Connection);
                DBConn.Command.ExecuteNonQuery();
                DBConn.Connection.Close();
                
                Console.WriteLine($"Update data {indexUser} success");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace);
            }
        }

        public static LecturerModel GetLecturerByNIDN(string NIDN)
        {
            try
            {
                queryString = $"SELECT * FROM dosen WHERE nidn_dosen = '{NIDN}'";
                DBConn.Connection.Open();
                DBConn.Command = new MySqlCommand(queryString, DBConn.Connection);
                DBConn.Reader = DBConn.Command.ExecuteReader();

                while (DBConn.Reader.Read())
                {
                    lecturerData = new LecturerModel(
                            DBConn.Reader["id_dosen"].ToString(),
                            DBConn.Reader["nama_dosen"].ToString(),
                            DBConn.Reader["email_dosen"].ToString(),
                            DBConn.Reader["password_dosen"].ToString(),
                            DBConn.Reader["nidn_dosen"].ToString()
                        );
                }

                DBConn.Reader.Close();
                DBConn.Connection.Close();
                return lecturerData;

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
                queryString =   $"INSERT INTO dosen (nama_dosen, nidn_dosen, email_dosen, password_dosen)" +
                                $" VALUES ('{lecturer.PersonName}', '{lecturer.LecturerNIDN}',  " +
                                $"'{lecturer.PersonEmail}', '{lecturer.PersonPassword}')";

                DBConn.Connection.Open();
                DBConn.Command = new MySqlCommand(queryString, DBConn.Connection);
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
                queryString = $"DELETE FROM dosen WHERE nidn_dosen = '{NIDN}'";
                DBConn.Connection.Open();
                DBConn.Command = new MySqlCommand(queryString, DBConn.Connection);
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

       
    }
}
