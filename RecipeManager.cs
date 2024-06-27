using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RecipeAppGUI
{
 
    public class RecipeManager
    {
        private List<Recipe> recipes = new List<Recipe>();


        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public void DisplayAllRecipes() // fucntion that deipslays all the recipes to user 
        {
            if (recipes.Count == 0)
            {
                MessageBox.Show("No recipes available.");
                
            }

            var sortedRecipes = recipes.OrderBy(r => r.Name).ToList();
            Console.WriteLine("Recipes:");
            foreach (var recipe in sortedRecipes)
            {
                MessageBox.Show(recipe.Name);
            }
        }

        public Recipe GetRecipeByName(string name)
        {
            return recipes.FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

       
    }
}

