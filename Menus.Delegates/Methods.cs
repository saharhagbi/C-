using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class Methods
    {
        public static void CountDigits()
        {
            string stringToCountHisDigit;
            int amountOfDigit = 0;

            Console.WriteLine("Write Some string");
            stringToCountHisDigit = Console.ReadLine();
            amountOfDigit = countAmountOfDigit(stringToCountHisDigit);
            Console.WriteLine("The amount of digit in the sentence is: {0}{1}", amountOfDigit, Environment.NewLine);
        }

        private static int countAmountOfDigit(string i_stringToCountHisDigit)
        {
            int amountOfDigit = 0;

            foreach (char charToCheck in i_stringToCountHisDigit)
            {
                if (char.IsDigit(charToCheck))
                {
                    amountOfDigit++;
                }
            }

            return amountOfDigit;
        }

        public static void ShowVersion()
        {
            Console.WriteLine("The Version is:");
            Console.WriteLine("Version: 19.2.4.32{0}", Environment.NewLine);
        }

        public static void ShowDate()
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine("The Date is:");
            Console.WriteLine("{0}/{1}/{2}{3}", localDate.Day, localDate.Month, localDate.Year, Environment.NewLine);
        }

        public static void ShowTime()
        {
            Console.WriteLine("The Time is:");
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));
            Console.WriteLine();
        }
    }
}

