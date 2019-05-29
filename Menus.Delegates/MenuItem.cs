using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        protected string m_OperationName;
        public abstract string ItemName();
        public abstract void OnClick();
    }
}
