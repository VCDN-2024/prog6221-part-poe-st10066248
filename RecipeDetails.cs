using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeAppGUI
{
    public partial class RecipeDetails : Form
    {
        public RecipeDetails()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecipeManager recipeManager = new RecipeManager();
            RecipeDetails recipeDetails = new RecipeDetails();
            string name = textBox1.Text;
            double quantity = Convert.ToDouble(textBox2.Text); 
            string unit = listBox1.Text;   
            int calories = Convert.ToInt32(textBox3.Text);
            string FoodGroup = listBox2.Text;

            
            AddRecipe addRecipe = new AddRecipe();
            Recipe recipe = new Recipe(addRecipe.Name);
            recipe.AddIngredient(new Ingredient(name, quantity, unit, calories, FoodGroup));
           
            RecipeSteps steps = new RecipeSteps();  
            steps.ShowDialog();
        }
    }
}
