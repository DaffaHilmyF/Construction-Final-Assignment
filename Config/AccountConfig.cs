namespace TUBES_FINAL.Config
{
    using BCrypt.Net;
    using TUBES_FINAL.Model;
    using System.Collections.Generic;

    public static class AccountConfig
    {
        public static void IsDomainEmailLecturerCorrect(string inputParams)
        {
            HandlingConfig.SanitizeInputNotNull(inputParams);
            HandlingConfig.SanitizeInputDomainLecturerIsCorrect(inputParams);
        }

        public static void IsDomainEmailStudentCorrect(string inputParams)
        {
            HandlingConfig.SanitizeInputNotNull(inputParams);
            HandlingConfig.SanitizeInputDomainStudentIsCorrect(inputParams);
        }

        public static bool IsPasswordCorrect(string inputParams, string hashedParams)
        {
            HandlingConfig.SanitizeInputNotNull(inputParams);
            HandlingConfig.SanitizeInputNotNull(hashedParams);

            return BCrypt.Verify(inputParams, hashedParams);
        }

        public static string PasswordHashed(string inputParams)
        {
            HandlingConfig.SanitizeInputNotNull(inputParams);

            return BCrypt.HashPassword(inputParams);
        }
        
        public static string ReturnIndexAccount(List<StudentModel> studentList, string email, string password)
        {
            foreach (var item in studentList)
            {
                if (item.PersonEmail.CompareTo(email) == 0)
                {
                    if (AccountConfig.IsPasswordCorrect(password, item.PersonPassword))
                    {
                        return item.StudentNIM;
                    }
                }
            }
            return null;
        }
        
        public static string ReturnIndexAccount(List<LecturerModel> lecturerList, string email, string password)
        {
            foreach (var item in lecturerList)
            {
                if (item.PersonEmail.CompareTo(email) == 0)
                {
                    if (AccountConfig.IsPasswordCorrect(password, item.PersonPassword))
                    {
                        return item.LecturerNIDN;
                    }
                }
            }
            return null;
        }

    }
}
