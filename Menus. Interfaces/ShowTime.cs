using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ShowTime : MenuItem
    {
        string m_OperationName = "Show Time";

        public void OnClick()
        {
            Console.WriteLine("The Time is:");
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));
            Console.WriteLine();
        }

        public string ItemName()
        {
            return m_OperationName;
        }
    }
}
