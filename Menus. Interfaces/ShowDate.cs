using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ShowDate : MenuItem
    {
        string m_OperationName = "Show Date";

        public void OnClick()
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine("The Date is:");
            Console.WriteLine("{0}/{1}/{2}{3}", localDate.Day, localDate.Month, localDate.Year, Environment.NewLine);
        }

        public string ItemName()
        {
            return m_OperationName;
        }
    }
}
