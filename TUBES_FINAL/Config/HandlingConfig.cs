namespace TUBES_FINAL.Config
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    public static class HandlingConfig
    {
        public static void SanitizeFileIsExist(string inputParams)
        {
            if (!File.Exists(inputParams))
                throw new FileNotFoundException("File not found");
        }

        public static void SanitizeInputNotNull(string inputParams)
        {
            if (String.IsNullOrEmpty(inputParams))
                throw new ArgumentNullException("Input should not be blank!");
        }
        
        public static void SanitizeInputNotNull(params string[] inputParams)
        {
            foreach(var item in inputParams)
            {
                if (String.IsNullOrEmpty(item))
                    throw new ArgumentNullException("Input should not be blank!");
            }

        }

        public static void SanitizeInputNotNull<T>(List<T> inputParams)
        {
            if (inputParams == null)
                throw new ArgumentNullException("Input should not be blank!");
        }

        public static void SanitizeInputLengthIsCorrect(string inputParams, int exceptedLength)
        {
            if (inputParams.Length != exceptedLength)
                throw new FormatException("Input length should be 10");
        }

        public static void SanitizeInputIsNumeric(string inputParams)
        {
            if (int.TryParse(inputParams, out _) == false)
                throw new FormatException("Input not numeric!");
        }

        public static void SanitizeInputIsNumeric(params string[] inputParams)
        {
            foreach(var item in inputParams)
            {
                if (int.TryParse(item, out _) == false)
                    throw new FormatException("Input not numeric!");
            }
            
        }

        public static void SanitizeInputNotOverflow(int inputParams)
        {
            if ((inputParams == Int32.MaxValue) || (inputParams == Int32.MinValue))
                throw new OverflowException("Input is overflow");
        }

        public static void SanitizeInputNotNegative(int inputParams)
        {
            if (inputParams < 0)
                throw new OverflowException("Input value is cannot below zero");
        }
        
        public static void SanitizeInputDomainLecturerIsCorrect(string inputParams)
        {
            Regex domainEmail = new Regex(@"^[a-zA-Z0-9_.+-]+@(?:(?:[a-zA-Z0-9-]+\.)?[a-zA-Z]+\.)?(telkomuniversity)\.ac.id$");

            if (!domainEmail.IsMatch(inputParams))
                throw new FormatException("Domain email is invalid");
            
        }

        public static void SanitizeInputDomainStudentIsCorrect(string inputParams)
        {
            Regex domainEmail = new Regex(@"^[a-zA-Z0-9_.+-]+@(?:(?:[a-zA-Z0-9-]+\.)?[a-zA-Z]+\.)?(student.telkomuniversity)\.ac.id$");

            if (!domainEmail.IsMatch(inputParams))
                throw new FormatException("Domain email is invalid");
           
        }
        
    }
}
