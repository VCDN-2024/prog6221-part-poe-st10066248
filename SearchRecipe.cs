using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecipeAppGUI
{
    public partial class SearchRecipe : Form
    {
        public SearchRecipe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void SearchRecipe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecipeManager recipeManager = new RecipeManager();
            
            string name = textBox1.Text;

            Recipe recipe = recipeManager.GetRecipeByName(name);
            if (recipe != null)
            {
                recipe.DisplayRecipe();
            }
            else
            {
                MessageBox.Show("Recipe not found.");
            }
        }
    }
}
