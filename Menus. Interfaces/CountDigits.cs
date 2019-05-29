using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class CountDigits : MenuItem
    {
        string m_OperationName = "Count Digits";

        public void OnClick()
        {
            string stringToCountHisDigit;
            int amountOfDigit = 0;

            Console.WriteLine("Write Some string:");
            stringToCountHisDigit = Console.ReadLine();

            amountOfDigit = countAmountOfDigit(stringToCountHisDigit);

            Console.WriteLine("The amount of digit in the sentence is: {0}{1}", amountOfDigit, Environment.NewLine);
        }

        private int countAmountOfDigit(string i_stringToCountHisDigit)
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

        public string ItemName()
        {
            return m_OperationName;
        }
    }
}
