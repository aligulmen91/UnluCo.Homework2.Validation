using System;

namespace UnluCo.ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string pass = "ssdsad23Swer";
            
            Condition isUppercase = new IsUpper();
            Condition isLowerCase = new IsLower();
            Condition isDigit = new IsDigit();
            Condition isLong = new IsLong(); //longer than 10 chars


            Console.WriteLine(pass.CheckConditions(isUppercase, isLowerCase, isLong,isDigit));

        }

      

    }
}