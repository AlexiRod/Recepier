using System;
using System.Collections.Generic;
using System.Text;

namespace My_Recepies
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string Text { get; set; }
        public decimal Kkal { get; set; }

        public Recipe() { }

        public Recipe(string name, List<Ingredient> ingredients, string text)
        {
            Name = name;
            Ingredients = ingredients;
            Text = text;

            foreach (var ing in Ingredients)
                Kkal += ing.Kkal;
        }

        public string WriteIngredients()
        {
            string ret = "Ингредиенты:\n";
            foreach (var ing in Ingredients)
            {
                ret += $"{ing.Product.Name} - {ing.Count} г ({ing.Kkal} Ккал)\n";
            }
            ret += "Общая калорийность: " + Kkal + "\n";

            return ret;
        }

        public string WriteAllRecipe()
        {
            string ret = $"\"{Name}\"\n" + WriteIngredients() + $"Описание рецепта:\n{Text}";
            return ret;
        }
    }
}
