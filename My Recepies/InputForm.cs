using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace My_Recepies
{
    public partial class InputForm : Form
    {
        public decimal Result = 0;

        public InputForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "" || !decimal.TryParse(textBox.Text, out decimal a) || a <= 0)
            {
                MessageBox.Show("Значение должно быть положительным числом!");
                return;
            }

            Result = a;
            this.Close();
        }


    }
}
