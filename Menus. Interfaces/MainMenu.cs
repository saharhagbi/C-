using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        public void Show()
        {
            Menu mainMenu = new Menu("Main Menu", null);
            Menu ShowDateOrTime = new Menu("Show Date/Time", mainMenu);
            Menu VersionAndDigits = new Menu("Version And Digits", mainMenu);

            ShowDateOrTime.AddItem(new ShowDate());
            ShowDateOrTime.AddItem(new ShowTime());

            VersionAndDigits.AddItem(new CountDigits());
            VersionAndDigits.AddItem(new ShowVersion());

            mainMenu.AddItem(ShowDateOrTime);
            mainMenu.AddItem(VersionAndDigits);

            mainMenu.OnClick();
        }        
    }
}

