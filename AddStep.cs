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
    public partial class AddStep : Form
    {
        public AddStep()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecipeManager recipeManager = new RecipeManager();
            AddRecipe addRecipe = new AddRecipe();
            Recipe recipe = new Recipe(addRecipe.Name);
            RecipeDetails recipeDetails = new RecipeDetails();
            string description = textBox1.Text;

            recipe.AddStep(new RecipeStep(description));
            AddStep addStep = new AddStep();    
            addStep.Close();    
        }
    }
}
