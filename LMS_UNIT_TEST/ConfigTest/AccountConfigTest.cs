using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TUBES_FINAL.Config;

namespace LMS_UNIT_TEST.ConfigTest
{
    [TestClass]
    class AccountConfigTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Input should not be blank!")]
        public void Should_ThrowException_When_Input_IsDomainEmailLecturerCorrect_Null()
        {
            string InitialInput = null;
            AccountConfig.IsDomainEmailLecturerCorrect(InitialInput);

        }
    }
}
