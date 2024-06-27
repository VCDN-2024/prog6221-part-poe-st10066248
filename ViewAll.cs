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
    public partial class ViewAll : Form
    {
        public ViewAll()
        {
            InitializeComponent();
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {
            ViewAll viewAll = new ViewAll();

            RecipeManager recipeManager = new RecipeManager();
            recipeManager.DisplayAllRecipes();
        }
    }
}
