namespace LMS_TEST.ConfigTest
{

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using TUBES_FINAL.Config;
    using TUBES_FINAL.Model;

    [TestClass]
    public class AccountConfigTest
    {
        [TestMethod]
        public void Should_ThrowException_When_InputParams_In_IsDomainEmailStudentCorrect_Null()
        {
            string InitialValue = null;

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                AccountConfig.IsDomainEmailStudentCorrect(InitialValue);
            });
        }

        [TestMethod]
        public void Should_ThrowException_When_InputParamsEmail_In_IsDomainEmailStudentCorrect_InCorrect()
        {
            string initialValue = "watame@gmail.com";

            Assert.ThrowsException<FormatException>(() =>
            {
                AccountConfig.IsDomainEmailStudentCorrect(initialValue);
            });
        }

        [TestMethod]
        public void Should_ThrowException_When_InputParams_In_IsDomainEmailLecturerCorrect_Null()
        {
            string InitialValue = null;

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                AccountConfig.IsDomainEmailLecturerCorrect(InitialValue);
            });
        }

        [TestMethod]
        public void Should_ThrowException_When_InputParamsEmail_In_IsDomainEmailLecturerCorrect_InCorrect()
        {
            string initialValue = "watame@gmail.com";

            Assert.ThrowsException<FormatException>(() =>
            {
                AccountConfig.IsDomainEmailLecturerCorrect(initialValue);
            });


        }

        [TestMethod]
        public void Should_Return_Null_When_AccountStudentNotFound_In_ReturnIndexAccount()
        {
            List<StudentModel> studentList = new List<StudentModel>();
            string intialEmail = "watame@student.telkomuniversity.ac.id";
            string intialPassword = "123";
            string expectedValue = null;

            Assert.AreEqual(expectedValue,
                    AccountConfig.ReturnIndexAccount(
                        studentList, intialEmail, intialPassword
                        )
                );

        }

        [TestMethod]
        public void Should_Return_Null_When_AccountLecturerNotFound_In_ReturnIndexAccount()
        {
            List<LecturerModel> lecturerList = new List<LecturerModel>();
            string intialEmail = "watame@telkomuniversity.ac.id";
            string intialPassword = "123";
            string expectedValue = null;

            Assert.AreEqual(expectedValue,
                    AccountConfig.ReturnIndexAccount(
                        lecturerList, intialEmail, intialPassword
                        )
                );
        }

        [TestMethod]
        public void Should_Return_True_When_PasswordCorrect_In_IsPasswordCorrect()
        {
            List<StudentModel> studentList = new List<StudentModel>();
            string initialPasswordValue = "kiryucoco";
            string initialHashedPassValue = AccountConfig.PasswordHashed(initialPasswordValue);
            bool ExpectedValue = true;

            Assert.AreEqual(ExpectedValue,
                AccountConfig.IsPasswordCorrect(
                    initialPasswordValue, 
                    initialHashedPassValue
                    )
                );
            
        }



    }
}
