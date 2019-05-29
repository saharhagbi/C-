using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Interfaces.MainMenu firstTest = new Interfaces.MainMenu();
            Delegates.MainMenu secondTest = new Delegates.MainMenu();

            firstTest.Show();
            secondTest.Show();
        }
    }     
}
