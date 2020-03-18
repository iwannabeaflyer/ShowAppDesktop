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
using System.IO;

namespace ShowAppDesktop
{
    public partial class MainScreen : Form
    {
        //private MainSingleton main;
        private string jsonString = "";
        private string cmd;
        private bool IsChanged = false;
        private JsonObject jsonObject = new JsonObject();
        Configuration config;

        public MainScreen()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            Console.WriteLine(ConfigurationManager.AppSettings.Get("lang"));
            LanguageManager.SetCulture(ConfigurationManager.AppSettings.Get("lang"));
            //main = new MainSingleton();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            welcomeMessage.Text = LanguageManager.GetTranslation("programStart");
            button_Add.Text = LanguageManager.GetTranslation("cmdAdd");
            button_Remove.Text = LanguageManager.GetTranslation("cmdRemove");
            button_Search.Text = LanguageManager.GetTranslation("cmdFind");
            button_Edit.Text = LanguageManager.GetTranslation("cmdEdit");
            button_Save.Text = LanguageManager.GetTranslation("cmdSave");
            button_Load.Text = LanguageManager.GetTranslation("cmdLoad");
            button_Settings.Text = LanguageManager.GetTranslation("cmdSettings");
            button_Quit.Text = LanguageManager.GetTranslation("cmdExit");
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
            MainLoad(ref jsonObject, ref jsonString);
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {

        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            if (IsChanged)
            {
                //Try to save
            }

            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            int index = listBox1.SelectedIndex;
            Console.WriteLine("Currently {0}, is selected with an index of {1}",curItem, index);
        }

        private void MainLoad(ref JsonObject jsonObject, ref string jsonString)
        {
            Console.WriteLine(LanguageManager.GetTranslation("load"));
            jsonObject.Items.Clear();
            jsonString = LoadFile();
            if(!String.IsNullOrEmpty(jsonString))
                jsonObject = Deserialize(jsonString);

            foreach (ModelItem item in jsonObject.Items)
            {
                listBox1.Items.Add(item.ReturnName());            }
            Console.WriteLine(LanguageManager.GetTranslation("loadComplete"));
        }

        /// <summary>
        /// Load a specific file into a string using the given fileName, if none is given it will ask for one
        /// </summary>
        /// <param name="fileName">Name of the file you want to look in, can be empty</param>
        /// <returns>The entire content of a file as a string</returns>
        private string LoadFile()
        {
            StreamReader sr;
            string path = "";
            //Console.WriteLine(LanguageManager.GetTranslation("loadMode"));
            //DialogResult confirmResult;
            //using (ConfirmScreen confirm = new ConfirmScreen())
            //{
            //    confirmResult = confirm.ShowDialog();
            //    if (confirmResult == DialogResult.Yes)
            //    {
            //        Console.WriteLine(LanguageManager.GetTranslation("directoryPath"));
            //        //TODO: Add a way to enter the new path
            //        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            //        {
            //            path = folderBrowserDialog.SelectedPath;
            //            Console.WriteLine(path);
            //        }
            //        //path = Console.ReadLine();
            //    }
            //}

            Console.WriteLine(LanguageManager.GetTranslation("loadFileName"));
            string fileName = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open json file";
                openFileDialog.Filter = Constants.OPENFILEFILTER;
                openFileDialog.InitialDirectory = Constants.OPENFILEDIR;
                DialogResult dialogResult = openFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    return null;
                }
            }
            string line = "";
            try
            {
                using (sr = new StreamReader(fileName))
                {
                    line = sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
            return line;
        }

        /// <summary>
        /// Deserialize a json string to a list of ModelItems
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns>List of ModelItems made using the json string</returns>
        private JsonObject Deserialize(string jsonString)
        {
            JsonObject ob = new JsonObject();
            ob = JsonSerializer.Deserialize<JsonObject>(jsonString);
            /*            
            List<ModelItem> result = new List<ModelItem>();
            split jsonString into modelitems objects
            jsonString = jsonString.TrimStart('{').TrimEnd('}');
            string[] temp = jsonString.Split('{', '}');
            Add the important information to a model
            for (int i = 1; i < temp.Length; i += 2)
            {
                result.Add(new ModelItem(temp[i]));
            }*/
            return ob;
        }
    }
}
