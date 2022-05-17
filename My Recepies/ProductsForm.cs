using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace My_Recepies
{
    public partial class ProductsForm : Form
    {
        public static string pathForProducts;


        #region Элементы формы

        public ProductsForm()
        {
            InitializeComponent();
            pathForProducts = MainForm.pathForProducts;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
            MessageBox.Show("Список существующий продуктов с их калорийностью находится слева. Для добавления нового продукта введите информацию о нем в соответствующие окна. Если такой продукт уже существует, он обновится. Удалить продукт можно по его названию или же выделив соответствующую строку.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Список существующий продуктов с их калорийностью находится слева. Для добавления нового продукта введите информацию о нем в соответствующие окна. Если такой продукт уже существует, он обновится. Удалить продукт можно по его названию или же выделив соответствующую строку.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = txtBoxNameAdd.Text.Trim();
            if (name == "" || name == null)
            {
                MessageBox.Show("У продукта должно быть называние!");
                return;
            }
            if (!decimal.TryParse(txtBoxKkalAdd.Text, out decimal kkal) || kkal <= 0)
            {
                MessageBox.Show("Калорийность продукта должна быть положительным числом!");
                return;
            }
            Product product = new Product(name, kkal);
            AddProduct(product);
            txtBoxNameAdd.Text = name;
            MessageBox.Show($"Продукт \"{name}\" успешно добавлен!");
            UpdateDataGrid();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string name = txtBoxNameDelete.Text.Trim();
            if (name == "" || name == null)
            {
                MessageBox.Show("У продукта должно быть называние!");
                return;
            }

            txtBoxNameDelete.Text = name;
            if (RemoveProductFromDataBase(name))
                MessageBox.Show($"Продукт \"{name}\" успешно удален!");
            else
                MessageBox.Show($"Продукт \"{name}\" не найден!");
            UpdateDataGrid();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView.SelectedCells[0].RowIndex;
                string name = dataGridView.Rows[index].Cells[0].Value.ToString();
                RemoveProductFromDataBase(name);
                MessageBox.Show("Удалена строка " + name);
                dataGridView.Rows.RemoveAt(index);
            }
            catch (Exception)
            {
                MessageBox.Show("Строка не выделена!");
            }
        }

        private void UpdateDataGrid()
        {
            XmlDocument xDoc = new XmlDocument();

            try
            {
                xDoc.Load(pathForProducts);
                XmlElement xRoot = xDoc.DocumentElement;
                XmlNodeList productNodes = xRoot.SelectNodes("product");

                dataGridView.Rows.Clear();
                foreach (XmlNode n in productNodes)
                    try 
                    {
                        string name = n.SelectSingleNode("@name").Value;
                        string kkal = n.SelectSingleNode("kkal").InnerText;
                        dataGridView.Rows.Add(name, kkal);
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Ошибка базы данных! Соответствующее поле не найдено!");
                    }
                dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка доступа к файлу!");
            }
            
        }

        #endregion


        #region Работа с файлами

        public void AddProduct(Product product)
        {
            XmlDocument xDoc = new XmlDocument();
            if (RemoveProductFromDataBase(product.Name)) { }
            AddProductToDataBase(product);
            //xDoc.Save(pathForProducts);
        }

        

        public static void AddProductToDataBase(Product product)
        {
            XmlDocument xDoc = new XmlDocument();
            try
            {
                xDoc.Load(pathForProducts);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка доступа к файлу!");
                return;
            }

            XmlElement xRoot = xDoc.DocumentElement;

            XmlElement userElem = xDoc.CreateElement("product");

            XmlAttribute nameAttr = xDoc.CreateAttribute("name");
            nameAttr.AppendChild(xDoc.CreateTextNode(product.Name));

            XmlElement kkalElem = xDoc.CreateElement("kkal");
            kkalElem.AppendChild(xDoc.CreateTextNode(product.Kkal.ToString()));

            userElem.Attributes.Append(nameAttr);
            userElem.AppendChild(kkalElem);

            xRoot.AppendChild(userElem);
            xDoc.Save(pathForProducts);
        }

        public static bool RemoveProductFromDataBase(string name)
        {
            XmlDocument xDoc = new XmlDocument();
            try
            {
                xDoc.Load(pathForProducts);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка доступа к файлу!");
                return false;
            }
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNode node = xRoot.SelectSingleNode($"product[@name='{name}']");
            if (node != null)
                xRoot.RemoveChild(node);
            else return false;

            xDoc.Save(pathForProducts);
            return true;
        }

        #endregion

       
    }
}
