using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Configuration;

namespace ShowAppDesktop
{
    public partial class MainScreen : Form
    {
        private MainSingleton main;

        public MainScreen()
        {
            InitializeComponent();
            main = new MainSingleton();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            welcomeMessage.Text = "Welcome to the program";
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {

        }

        private void button_Search_Click(object sender, EventArgs e)
        {

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {

        }

        private void button_Load_Click(object sender, EventArgs e)
        {

        }

        private void button_Settings_Click(object sender, EventArgs e)
        {

        }

        private void button_Quit_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            int index = listBox1.SelectedIndex;
            Console.WriteLine("Currently {0}, is selected with an index of {1}",curItem, index);
        }
    }
}
