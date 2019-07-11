using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDK_Example
{
    public partial class UserControlPlusMinus : UserControl
    {
        public delegate void Action();
        private Action actionPlus;
        private Action actionMinus;
        bool bInitDone = false;

        public UserControlPlusMinus()
        {
            InitializeComponent();
        }

        public void Init(string strTextLabel, Action ActPlus, Action ActMinus)
        {
            labelName.Text = strTextLabel;
            actionMinus = ActMinus;
            actionPlus = ActPlus;
            bInitDone = true;
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            if (actionPlus == null)
                return;
            if (bInitDone)
                actionPlus();
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            if (actionMinus == null)
                return;
            if (bInitDone)
                actionMinus();
        }
    }
}
