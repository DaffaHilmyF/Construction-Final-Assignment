namespace TUBES_FINAL.Database
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TUBES_FINAL.Model;

    public static class DBStudent
    {
        private static StudentModel studentData;
        private static List<StudentModel> studentList;
        private static string queryString;

        public static List<StudentModel> GetAllStudent()
        {
            try
            {
                studentList = new List<StudentModel>();
                queryString = "SELECT * FROM mahasiswa";

                DBConn.Connection.Open();
                DBConn.Command = new MySqlCommand(queryString, DBConn.Connection);
                DBConn.Reader = DBConn.Command.ExecuteReader();

                while (DBConn.Reader.Read())
                {
                    string id = DBConn.Reader["id_mahasiswa"].ToString();
                    string nama = DBConn.Reader["nama_mahasiswa"].ToString();
                    string email = DBConn.Reader["email_mahasiswa"].ToString();
                    string password = DBConn.Reader["password_mahasiswa"].ToString();
                    string nim = DBConn.Reader["nim_mahasiswa"].ToString();
                    string tahun = DBConn.Reader["tahun_mahasiswa"].ToString();

                    studentList.Add(
                        new StudentModel(
                            id, nama, email, password, nim, tahun
                        )
                    );

                }

                DBConn.Reader.Close();
                DBConn.Connection.Close();

                return studentList;

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace);
                return null;
            }


        }

    }
}
