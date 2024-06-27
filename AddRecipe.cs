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
    public partial class AddRecipe : Form
    {
        public AddRecipe()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecipeManager recipeManager = new RecipeManager();
            RecipeDetails recipeDetails = new RecipeDetails();
            this.Visible = true;
            recipeDetails.ShowDialog(); 
            this.Visible = false;

            string name = textBox1.Text;
            Recipe recipe = new Recipe(name);
            
        }
    }
}
