using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Recepies
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static string pathForProducts = "D:/Recepies/products.xml";
        public static string pathForRecepies = "D:/Recepies/recepies.xml";

        private void btnProductsList_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.ShowDialog();
        }

        private void btnRecepiesList_Click(object sender, EventArgs e)
        {
            RecepiesForm form = new RecepiesForm();
            form.ShowDialog();
        }

        private void btnProductsConfirm_Click(object sender, EventArgs e)
        {
            pathForProducts = txtBoxProducts.Text.Trim();

            if (File.Exists(pathForProducts))
            {
                MessageBox.Show("Путь к файлу успешно сохранен!");
                btnProductsList.Enabled = true;
                return;
            }
            MessageBox.Show("Путь к файлу не найден!");
        }

        private void btnRecepiesConfirm_Click(object sender, EventArgs e)
        {
            pathForRecepies = txtBoxRecepies.Text.Trim();

            if (File.Exists(pathForRecepies))
            {
                MessageBox.Show("Путь к файлу успешно сохранен!");
                btnRecepiesList.Enabled = true;
                return;
            }
            MessageBox.Show("Путь к файлу не найден!");
        }
    }
}
