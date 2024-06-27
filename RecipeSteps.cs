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
    public partial class RecipeSteps : Form
    {
        public RecipeSteps()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecipeManager recipeManager = new RecipeManager();
            AddStep addStep = new AddStep();
            int numOfSteps= Convert.ToInt32(numericUpDown1.Value);


            for (int i = 0; i < numOfSteps; i++)
            {

                addStep.ShowDialog();  
                
               
            }
            addStep.Close();
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
