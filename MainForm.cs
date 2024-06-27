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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRecipe addRecipe = new AddRecipe();  
            this.Visible = false;
            addRecipe.ShowDialog();
            this.Visible = true;    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchRecipe searchRecipe = new SearchRecipe(); 
            this.Visible = false;
            searchRecipe.ShowDialog();  
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             
            this.Visible = false;
            
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
