namespace TUBES_FINAL.Config
{
    using BCrypt.Net;
    using LMS_TUBES.Model;
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
}
