using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class Menu : MenuItem
    {
        string m_MenuTitle;
        private List<MenuItem> m_AllItems = new List<MenuItem>();

        public Menu(string i_MenuTitle, Menu i_BackTopPreviousMenu)
        {
            m_AllItems.Add(new Back(i_BackTopPreviousMenu));
            m_MenuTitle = i_MenuTitle;
        }

        public void AddItem(MenuItem i_item)
        {
            m_AllItems.Add(i_item);
        }

        public void OnClick()
        {
            int ConsoleNumberOfChoice = 1;

            StringBuilder Message = new StringBuilder();

            Console.Clear();
            Message.Append(string.Format("{0}: {1}{1}", m_MenuTitle, Environment.NewLine));

            foreach (MenuItem item in m_AllItems)
            {
                Message.Append(string.Format("{0}. {1}{2}", ConsoleNumberOfChoice, item.ItemName(), Environment.NewLine));
                ConsoleNumberOfChoice++;
            }

            Console.WriteLine(Message);
            ChooseOption(Message);
        }

        public void ChooseOption(StringBuilder i_Message)
        {
            while (true)
            {
                int choice = getUserChoiceByRange(0, m_AllItems.Count) - 1;
                Console.Clear();

                m_AllItems[choice].OnClick();

                if (choice == 0)
                {
                    break;
                }

                Console.WriteLine(i_Message);
            }
        }

        private int getUserChoiceByRange(int i_Start, int i_End)
        {
            int parseChoice;
            string userChoice;
            bool isItParse;

            userChoice = Console.ReadLine();
            isItParse = int.TryParse(userChoice, out parseChoice);

            while (!isItParse || parseChoice < i_Start || parseChoice > i_End)
            {
                userChoice = Console.ReadLine();
                Console.WriteLine("Invalid Choise! Choose number between {0} to {1}", i_Start, i_End);
                isItParse = int.TryParse(userChoice, out parseChoice);
            }

            return parseChoice;
        }

        public string ItemName()
        {
            return m_MenuTitle;
        }

        public class Back : MenuItem
        {
            private string m_Name = "Back";
            Menu m_BackTopPreviousMenu;

            public Back(Menu i_BackTopPreviousMenu)
            {
                if (i_BackTopPreviousMenu == null)
                {
                    m_Name = "Exit";
                }
                else
                {
                    m_Name = string.Format("Back to {0}", i_BackTopPreviousMenu.ItemName());
                }

                m_BackTopPreviousMenu = i_BackTopPreviousMenu;
            }

            public void OnClick()
            {
                if (m_BackTopPreviousMenu != null)
                {
                    Console.WriteLine("Backed To the {0}", m_BackTopPreviousMenu.ItemName());
                }
            }

            public string ItemName()
            {
                return m_Name;
            }
        }
    }
}

