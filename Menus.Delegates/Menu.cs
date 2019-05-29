using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Delegates
{
    public sealed class Menu : MenuItem
    {
        private List<MenuItem> m_AllItems = new List<MenuItem>();

        public Menu(string i_MenuTitle, Menu i_BackTopPreviousMenu)
        {
            m_AllItems.Add(new Back(i_BackTopPreviousMenu));
            m_OperationName = i_MenuTitle;
        }

        public override string ItemName()
        {
            return m_OperationName;
        }

        public void AddItem(MenuItem i_MenuItem)
        {
            m_AllItems.Add(i_MenuItem);
        }

        public override void OnClick()
        {
            int ConsoleNumberOfChoice = 1;

            StringBuilder Message = new StringBuilder();

            Console.Clear();

            Message.Append(string.Format("{0}:wke {1}{1}", m_OperationName, Environment.NewLine));

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

        public class Back : MenuItem
        {
            Menu m_BackTopPreviousMenu;

            public Back(Menu i_BackTopPreviousMenu)
            {
                if (i_BackTopPreviousMenu == null)
                {
                    m_OperationName = "Exit";
                }
                else
                {
                    m_OperationName = string.Format("Back to {0}", i_BackTopPreviousMenu.ItemName());
                }
                m_BackTopPreviousMenu = i_BackTopPreviousMenu;
            }

            public override void OnClick()
            {
                if (m_BackTopPreviousMenu != null)
                {
                    Console.WriteLine("Backed To the {0}", m_BackTopPreviousMenu.ItemName());
                }

            }

            public override string ItemName()
            {
                return m_OperationName;
            }
        }
    }
}

