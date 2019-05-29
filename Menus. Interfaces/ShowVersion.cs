using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ShowVersion : MenuItem
    {
        string m_OperationName = "Show Version";

        public void OnClick()
        {
            Console.WriteLine("The Version is:");
            Console.WriteLine("Version: 19.2.4.32{0}", Environment.NewLine);
        }

        public string ItemName()
        {
            return m_OperationName;
        }
    }
}
