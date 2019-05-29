using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public sealed class OperationItem : MenuItem
    {
        public event Action Operation;

        public OperationItem(string i_OperationName)
        {
            m_OperationName = i_OperationName;
        }

        public override string ItemName()
        {
            return m_OperationName;
        }

        public override void OnClick()
        {
            if (Operation != null)
            {
                Operation.Invoke();
            }
        }
    }
}
