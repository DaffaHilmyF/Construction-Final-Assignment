namespace LMS_TEST.ConfigTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using TUBES_FINAL.Config;

    [TestClass]
    public class HandlingConfigTest
    {
        [TestMethod]
        public void Should_ThrowsException_When_InputParams_Null_In_SanitizeInputNotNull()
        {
            string intialValue = null;

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                HandlingConfig.SanitizeInputNotNull(intialValue);
            });

        }

        [TestMethod]
        public void Should_ThrowsException_When_InputParamsArray_Null_In_SanitizeInputNotNull()
        {
            string[] intialValue = { "watame", "noel", null, "fubuki", "moona" };

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                HandlingConfig.SanitizeInputNotNull(intialValue);
            });
            
        }

        [TestMethod]
        public void Should_ThrowsException_When_InputParams_MaxValue_In_SanitizeInputNotOverflow()
        {
            int initialValue = Int32.MaxValue;

            Assert.ThrowsException<OverflowException>(() =>
            {
                HandlingConfig.SanitizeInputNotOverflow(initialValue);
            });

        }

        public void Should_ThrowsException_When_InputParams_MinValue_In_SanitizeInputNotOverflow()
        {
            int initialValue = Int32.MinValue;

            Assert.ThrowsException<OverflowException>(() =>
            {
                HandlingConfig.SanitizeInputNotOverflow(initialValue);
            });

        }
    }

    
}
