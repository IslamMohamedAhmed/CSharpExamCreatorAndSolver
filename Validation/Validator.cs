using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace C__Exam.Validation
{
    internal class Validator
    {
        public static string StringInputValidation(string message)
        {
            string str;
            do
            {
                Console.WriteLine(message);
                str = Console.ReadLine();
            } while (string.IsNullOrEmpty(str) || !str.Any(char.IsLetterOrDigit));
            return str;
        } // to obtain clean code (No DRY)


        public static int IntegerInputValidation(string message)
        {
            int x;

            do
            {
                Console.WriteLine(message);


            } while (!int.TryParse(Console.ReadLine(), out x));
            return x;
        } // to obtain clean code (No DRY)

        public static int IntegerInputValidation(string message, int mn)
        {
            int x;

            do
            {
                Console.WriteLine(message);


            } while (!int.TryParse(Console.ReadLine(), out x) || x < mn);
            return x;
        } // to obtain clean code (No DRY)

        public static int IntegerInputValidation(string message, int mn, int mx)
        {
            int x;

            do
            {
                Console.WriteLine(message);


            } while (!int.TryParse(Console.ReadLine(), out x) || x < mn || x > mx);
            return x;
        } // to obtain clean code (No DRY)
    }
}
