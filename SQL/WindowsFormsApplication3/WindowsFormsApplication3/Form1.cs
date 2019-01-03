using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class LWP04Main : Form
    {
        LWP04Children dlg = new LWP04Children();
        public LWP04Main()
        {
            InitializeComponent();
        }

        private void ButtonShowChildren_Click(object sender, EventArgs e)
        {
            if (!dlg.Visible)
                dlg.Show(this);

        }
    }
}
