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
    public partial class RecepiesForm : Form
    {
        public static string pathForProducts;
        public static string pathForRecepies;
        public static decimal recipeKkal = 0;
        
        public static int index = 0;
        public static List<Recipe> recepies = new List<Recipe>();

        public static Recipe recipe = new Recipe();
        public static List<Ingredient> ingredients = new List<Ingredient>();

        public RecepiesForm()
        {
            InitializeComponent();
            pathForProducts = MainForm.pathForProducts;
            pathForRecepies = MainForm.pathForRecepies;
        }

        private void RecepiesForm_Load(object sender, EventArgs e)
        {
            ReadRecepiesFromDataBase();
            cBoxRecepies.SelectedItem = "*Новый рецепт*";
            MessageBox.Show("Для того, чтобы создать новый рецепт в правом верхнем углу в выпадающем списке выберите пункт \"Новый рецепт\". Название и описание рецепта вводятся в соответствующие окна. Ингредиенты добавляются с помощью панели посередине. Если такой продукт существует, он добавится в общиу список, если нет - в диалоговом окне вам будет предложенно ввести его калорийность на 100 грамм. Если введенный продукт уже существует, он автоматически заменится. Удалить ингредиент можно по названию или выделив соответствующую строку. Для удаления выбранного рецепта нажмите кнопку с крестиком в верхнем правом углу экрана. Для удаления другого рецепта введите его название в соответствующее окно снизу. Для сохранения текущего рецепта нажмите кнопку с буквой S. Если такого рецепта еще нет в списке, то он сохранится, если же есть - обновится старый. Для переключения между рецептами используйте выпадающее меню справа. При переходе от текущего рецепта к новому, текущий не сохранится.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для того, чтобы создать новый рецепт в правом верхнем углу в выпадающем списке выберите пункт \"Новый рецепт\". Название и описание рецепта вводятся в соответствующие окна. Ингредиенты добавляются с помощью панели посередине. Если такой продукт существует, он добавится в общиу список, если нет - в диалоговом окне вам будет предложенно ввести его калорийность на 100 грамм. Если введенный продукт уже существует, он автоматически заменится. Удалить ингредиент можно по названию или выделив соответствующую строку. Для удаления выбранного рецепта нажмите кнопку с крестиком в верхнем правом углу экрана. Для удаления другого рецепта введите его название в соответствующее окно снизу. Для сохранения текущего рецепта нажмите кнопку с буквой S. Если такого рецепта еще нет в списке, то он сохранится, если же есть - обновится старый. Для переключения между рецептами используйте выпадающее меню справа. При переходе от текущего рецепта к новому, текущий не сохранится.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            string name = txtBoxNameAdd.Text.Trim();
            if (name == "" || name == null)
            {
                MessageBox.Show("У ингредента должно быть называние!");
                return;
            }
            if (!decimal.TryParse(txtBoxCountAdd.Text, out decimal gramms) || gramms <= 0)
            {
                MessageBox.Show("Количество продукта измеряется положительным числом!");
                return;
            }
            Product product = FindProduct(name);
            if (product.Name == "Not Found")
            {
                if (MessageBox.Show($"Продукт \"{name}\" не обнаружен! Добавить его?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show("Введите калорийность продукта (на 100 грамм) в диалоговом окне.");

                    InputForm inputForm = new InputForm();
                    inputForm.ShowDialog();
                    decimal kkal = inputForm.Result;
                    ProductsForm productsForm = new ProductsForm();
                    product = new Product(name, kkal);
                    productsForm.AddProduct(product);
                }
                else
                    return;
            }

            bool isFound = false;
            foreach (var item in ingredients)
            {
                if (item.Product.Name == name)
                {
                    ingredients.Remove(item);
                }
                else continue;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString() == name)
                    {
                        dataGridView.Rows.RemoveAt(row.Index);
                        isFound = true;
                        break;
                    }
                }

                dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
                if (isFound)
                    break;
            }

            MessageBox.Show($"Ингредиент \"{name}\" успешно добавлен!");
            Ingredient ingredient = new Ingredient(product, gramms);
            ingredients.Add(ingredient);
            dataGridView.Rows.Add(ingredient.Product.Name, gramms);
            dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
            recipeKkal += ingredient.Kkal;
            lblRecipeKkal.Text = $"Общая калорийность: {recipeKkal} ккал";
           
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            string name = txtBoxNameDelete.Text.Trim();
            if (name == "" || name == null)
            {
                MessageBox.Show("Введите ингредиент, которй нужно удалить!");
                return;
            }

            bool isFound = false;
            foreach (var item in ingredients)
            {
                if (item.Product.Name == name)
                {
                    ingredients.Remove(item); 
                    recipeKkal -= item.Kkal;
                    lblRecipeKkal.Text = $"Общая калорийность: {recipeKkal} ккал";
                }
                else continue;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString() == name)
                    {
                        dataGridView.Rows.RemoveAt(row.Index);
                        isFound = true;
                        break;
                    }
                }

                dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
                if (isFound)
                    break;
            }
            if (!isFound)
            {
                MessageBox.Show($"Ингредиент \"{name}\" не содержится в списке ингредиентов!");
                return;
            }

            MessageBox.Show($"Ингредиент \"{name}\" успешно удален!");
            txtBoxNameDelete.Text = name;
        }

        private void brnDeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView.SelectedCells[0].RowIndex;
                string name = dataGridView.Rows[index].Cells[0].Value.ToString();

                foreach (var item in ingredients)
                {
                    if (item.Product.Name == name)
                    {
                        ingredients.Remove(item);
                        recipeKkal += item.Kkal;
                        lblRecipeKkal.Text = $"Общая калорийность: {recipeKkal} ккал";
                        break;
                    }
                }

                MessageBox.Show($"Выделенный ингредиент \"{name}\" успешно удален!");
                dataGridView.Rows.RemoveAt(index);
            }
            catch (Exception)
            {
                MessageBox.Show("Строка не выделена!");
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtBoxRecipeName.Text.Trim();
            if (name == "" || name == null)
            {
                MessageBox.Show("Укажите название рецепта!");
                return;
            }

            string text = txtBoxRecipeText.Text.Trim();
            if (text == "" || text == null)
            {
                MessageBox.Show("Укажите описание рецепта!");
                return;
            }

            if (ingredients.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один ингредиент!");
                return;
            }

            recipe = new Recipe(name, ingredients, text);
            txtBoxRecipeName.Text = name;
            txtBoxRecipeText.Text = text;

            AddRecipeToDataBase(recipe);
            ReadRecepiesFromDataBase();
            cBoxRecepies.SelectedItem = name;
            MessageBox.Show($"Рецепт {name} успешно добавлен!");
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtBoxRecipeName.Text.Trim();
            if (name == "" || name == null)
            {
                MessageBox.Show("Вы не можете удалить данный рецепт, так как у него нет названия!");
                return;
            }
            if (MessageBox.Show($"Вы уверены, что хотите удалить данный рецепт (\"{name}\")?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (!RemoveRecipeFromDataBase(name))
            {
                MessageBox.Show($"Текущий рецепт \"{name}\" еще не сохранен!");
                return;
            }

            MessageBox.Show($"Текущий рецепт \"{name}\" успешно удален!");
            ClearElements();
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            string name = txtBoxDeleteRecipe.Text.Trim();
            if (name == "" || name == null)
            {
                MessageBox.Show("Укажите название рецепта!");
                return;
            }

            if (MessageBox.Show($"Вы уверены, что хотите удалить рецепт \"{name}\"?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (!RemoveRecipeFromDataBase(name))
            {
                MessageBox.Show($"Рецепт \"{name}\" не найден!");
                return;
            }

            if (txtBoxRecipeName.Text.Trim() == name)
                ClearElements();
            ReadRecepiesFromDataBase();

            MessageBox.Show($"Рецепт \"{name}\" успешно удален!");
            txtBoxDeleteRecipe.Text = name;
        }

        private void UpdateFormElements()
        {
            ingredients = recipe.Ingredients;
            if(recipe.Name != null)
                txtBoxRecipeName.Text = recipe.Name;
            if (recipe.Text != null)
                txtBoxRecipeText.Text = recipe.Text;

            dataGridView.Rows.Clear();
            if (recipe.Ingredients != null)
                foreach (var item in recipe.Ingredients)
                {
                    dataGridView.Rows.Add(item.Product.Name, item.Count);
                }

            cBoxRecepies.Items.Clear();
            if (recepies != null)
                foreach (var item in recepies)
                {
                    cBoxRecepies.Items.Add(item.Name);
                }
            cBoxRecepies.Items.Add("*Новый рецепт*");
            dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
            lblRecipeKkal.Text = $"Общая калорийность: {recipe.Kkal} ккал";
        }

        private void ClearElements()
        {
            ingredients = new List<Ingredient>();
            recipe = new Recipe();
            txtBoxRecipeName.Text = "";
            txtBoxRecipeText.Text = "";
            txtBoxNameAdd.Text = "";
            txtBoxNameDelete.Text = "";
            txtBoxCountAdd.Text = "";
            txtBoxDeleteRecipe.Text = "";
            dataGridView.Rows.Clear();
            recipeKkal = 0;
            lblRecipeKkal.Text = $"Общая калорийность: 0 ккал";
        }






        public static Product FindProduct(string name)
        {
            Product product = new Product();
            XmlDocument xProdDoc = new XmlDocument();
            try
            {
                xProdDoc.Load(pathForProducts);
                XmlElement xRoot = xProdDoc.DocumentElement;

                XmlNode node = xRoot.SelectSingleNode($"product[@name='{name}']");
                if (node == null)
                    return new Product("Not Found", 0);

                string val = node.SelectSingleNode("kkal").InnerText;
                if (decimal.TryParse(val, out decimal kkal))
                    product = new Product(name, kkal);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка доступа к файлу!");
            }

            return product;
        }
        public static void AddRecipeToDataBase(Recipe recipe)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(pathForRecepies);
            XmlElement xRoot = xDoc.DocumentElement;

            bool isInBase = RemoveRecipeFromDataBase(recipe.Name);

            // создаем новый элемент
            XmlElement userElem = xDoc.CreateElement("recipe");

            // создаем атрибут name
            XmlAttribute nameAttr = xDoc.CreateAttribute("name");
            nameAttr.AppendChild(xDoc.CreateTextNode(recipe.Name));

            // создаем элементы
            XmlElement ingElem = xDoc.CreateElement("ingredients");
            string ingreds = "";
            foreach (var ing in recipe.Ingredients)
                ingreds += $"{ing.Product.Name},{ing.Count}\n";
            ingElem.AppendChild(xDoc.CreateTextNode(ingreds));

            XmlElement kkalElem = xDoc.CreateElement("kkal");
            kkalElem.AppendChild(xDoc.CreateTextNode(recipe.Kkal.ToString()));

            XmlElement textElem = xDoc.CreateElement("text");
            textElem.AppendChild(xDoc.CreateTextNode(recipe.Text));


            userElem.Attributes.Append(nameAttr);
            userElem.AppendChild(ingElem);
            userElem.AppendChild(kkalElem);
            userElem.AppendChild(textElem);

            xRoot.AppendChild(userElem);
            xDoc.Save(pathForRecepies);
            if (isInBase)
                RemoveRecipeFromDataBase(recipe.Name);
        }

        public static bool RemoveRecipeFromDataBase(string name)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(pathForRecepies);
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNode node = xRoot.SelectSingleNode($"recipe[@name='{name}']");
            if (node != null)
                xRoot.RemoveChild(node);
            else return false;

            xDoc.Save(pathForRecepies);
            return true;
        }

        public void ReadRecepiesFromDataBase()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(pathForRecepies);
            XmlElement xRoot = xDoc.DocumentElement;

            //XmlNode node = xRoot.SelectSingleNode($"recipe[@name='{name}']");
            XmlNodeList childnodes = xRoot.SelectNodes("recipe");
            if (childnodes == null)
                return;

            recepies.Clear();
            foreach (XmlNode n in childnodes)
            {
                try
                {
                    string name = n.SelectSingleNode("@name").Value;
                    double kkal;
                    if (double.TryParse(n.SelectSingleNode("kkal").InnerText, out kkal)) { }
                    string text = n.SelectSingleNode("text").InnerText;
                    string[] listOfIngredients = n.SelectSingleNode("ingredients").InnerText.Split(new char[] { '\n' });
                    List<Ingredient> ingredients = new List<Ingredient>();
                    foreach (var ing in listOfIngredients)
                    {
                        if (ing == "" || ing == null) continue;
                        string[] parts = ing.Split(new char[] { ',' });
                        string nameOfProduct = parts[0];
                        Product product = FindProduct(nameOfProduct);
                        decimal count = 0;
                        if (decimal.TryParse(parts[1], out count)) { }

                        ingredients.Add(new Ingredient(product, count));
                    }
                    recepies.Add(new Recipe(name, ingredients, text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при работе с файлом! " + ex.Message);
                }
            }
            cBoxRecepies.Items.Clear();
            if (recepies != null)
                foreach (var item in recepies)
                {
                    cBoxRecepies.Items.Add(item.Name);
                }
            cBoxRecepies.Items.Add("*Новый рецепт*");
        }

        private void cBoxRecepies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxRecepies.SelectedItem.ToString() == null)
                return;
            string name = cBoxRecepies.SelectedItem.ToString();

            if (name == "*Новый рецепт*")
            {
                ClearElements();
                return;
            }

            if(recepies != null)
            foreach (var item in recepies)
            {
                if (item.Name == name)
                {
                    recipe = item;
                    UpdateFormElements();
                    return;
                }
            }
        }

    }
}
