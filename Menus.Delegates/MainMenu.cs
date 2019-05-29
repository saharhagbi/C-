using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        public void Show()
        {
            Menu mainMenu = new Menu("Main Menu", null);
            Menu showDateOrTime = new Menu("Show Date/Time", mainMenu);
            Menu versionAndDigits = new Menu("Version And Digits", mainMenu);

            OperationItem showVersion = new OperationItem("Show Version");
            showVersion.Operation += Methods.ShowVersion;

            OperationItem showDate = new OperationItem("Show Date");
            showDate.Operation += Methods.ShowDate;

            OperationItem showTime = new OperationItem("Show Time");
            showTime.Operation += Methods.ShowTime;

            OperationItem countDigits = new OperationItem("Count Digits");
            countDigits.Operation += Methods.CountDigits;

            showDateOrTime.AddItem(showDate);
            showDateOrTime.AddItem(showTime);

            versionAndDigits.AddItem(countDigits);
            versionAndDigits.AddItem(showVersion);

            mainMenu.AddItem(showDateOrTime);
            mainMenu.AddItem(versionAndDigits);

            mainMenu.OnClick();
        }
    }
}

