namespace TUBES_FINAL.Database
{
    using LMS_TUBES.Model;
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
                        new Lecturer(
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
}
