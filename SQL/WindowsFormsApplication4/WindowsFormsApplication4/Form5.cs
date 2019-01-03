using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void оценкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оценкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database61DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database61DataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.database61DataSet.Оценки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1,a2,a3,res;
            a1 = Convert.ToInt32(оценка_1TextBox.Text);
            a2 = Convert.ToInt32(оценка_2TextBox.Text);
            a3 = Convert.ToInt32(оценка_3TextBox.Text);
            res = (a1 + a2 + a3) / 3;
            средний_балTextBox.Text = Convert.ToString(res);
            
        }
    }
}
