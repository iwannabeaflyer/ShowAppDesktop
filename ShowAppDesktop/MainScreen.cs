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

/* TODO
 * Split up Runtime in Total and per episode
 * Change the OpenItemScreen so it has numerUpDowns
 * Find a way to easily edit the genres
 * Remove all translations of in what function you are
 * Add translations for the new screen interfaces
 * Add the following methods:
 * MainAdd()
 * MainFind()
 * MainRemove()
 * MainSave()
 * MainSettings()
 * And the rest of the Auxiliary functions
     */

namespace ShowAppDesktop
{
    public partial class MainScreen : Form
    {
        #region Variables
        private string jsonString = "";
        //private string cmd;
        private bool IsChanged = false;
        private JsonObject jsonObject = new JsonObject();
        Configuration config;
        #endregion

        #region Interface
        public MainScreen()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            LanguageManager.SetCulture(ConfigurationManager.AppSettings.Get("lang"));
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            button_Add.Text = LanguageManager.GetTranslation("bttnAdd");
            button_Remove.Text = LanguageManager.GetTranslation("bttnRemove");
            button_Search.Text = LanguageManager.GetTranslation("bttnFind");
            button_Edit.Text = LanguageManager.GetTranslation("bttnEdit");
            button_Save.Text = LanguageManager.GetTranslation("bttnSave");
            button_Load.Text = LanguageManager.GetTranslation("bttnLoad");
            button_Settings.Text = LanguageManager.GetTranslation("bttnSettings");
            button_Quit.Text = LanguageManager.GetTranslation("bttnExit");
            button_Open.Text = LanguageManager.GetTranslation("bttnOpen");
            button_Edit_Selected.Text = LanguageManager.GetTranslation("bttnEdit");
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

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1) return;

            ModelItem openItem = jsonObject.Items[listBoxItems.SelectedIndex];
            OpenItemScreen openItemScreen = new OpenItemScreen(openItem);
            openItemScreen.ShowDialog();
        }

        private void button_Edit_Selected_Click(object sender, EventArgs e)
        {
            int index = listBoxItems.SelectedIndex;
            if (index == -1) return;

            ModelItem openItem = jsonObject.Items[index];
            Console.WriteLine(openItem.ReturnName());
            EditItemScreen editItemScreen = new EditItemScreen(openItem);
            DialogResult dialogResult = editItemScreen.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                IsChanged = true;
                jsonObject.Items[index].EnName = editItemScreen.textBox_EnName.Text;
                jsonObject.Items[index].AltName = editItemScreen.textBox_AltName.Text;
                jsonObject.Items[index].Episodes = (ushort)editItemScreen.numericUpDown_Episodes.Value;
                jsonObject.Items[index].Description = editItemScreen.textBox_Description.Text;
                jsonObject.Items[index].Score = (byte)editItemScreen.numericUpDown_Score.Value;
                jsonObject.Items[index].RunTime = (ushort)editItemScreen.numericUpDown_RuntimeEpisode.Value;
                jsonObject.Items[index].Notes = editItemScreen.textBox_Notes.Text;

                jsonObject.Items[index].Genres.Clear();
                foreach (var s in editItemScreen.listBox_Genres.Items)
                {
                    jsonObject.Items[index].Genres.Add(FirstToUpper(s.ToString()));
                }
                
                jsonObject.Items[index].Watched = editItemScreen.checkBox_Watched.Checked;
                jsonObject.Items[index].HasEnd = editItemScreen.checkBox_Ending.Checked;
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
        }

        #endregion

        #region MainFunctions
        private void MainAdd(ref JsonObject jsonObject, ref bool isChanged)
        {

        }

        private void MainFind(JsonObject jsonObject)
        {

        }

        private void MainEdit(ref JsonObject jsonObject, ref bool isChanged)
        {

        }

        private void MainLoad(ref JsonObject jsonObject, ref string jsonString)
        {
            Console.WriteLine(LanguageManager.GetTranslation("load"));
            jsonObject.Items.Clear();
            jsonString = LoadFile();
            if (!string.IsNullOrEmpty(jsonString))
            {
                jsonObject = Deserialize(jsonString);
                listBoxItems.Items.Clear();
                foreach (ModelItem item in jsonObject.Items)
                {
                    listBoxItems.Items.Add(item.ReturnName());
                }
            }

            Console.WriteLine(LanguageManager.GetTranslation("loadComplete"));
        }

        private void MainSave(ref JsonObject jsonObject, ref bool isChanged, ref string jsonString)
        {

        }

        private void MainSettings(ref Configuration config)
        {

        }
        #endregion

        #region AuxiliaryFunctions
        /// <summary>
        /// Load a specific file into a string using the given fileName, if none is given it will ask for one
        /// </summary>
        /// <param name="fileName">Name of the file you want to look in, can be empty</param>
        /// <returns>The entire content of a file as a string</returns>
        private string LoadFile()
        {
            StreamReader sr;
            //string path = "";
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

        /// <summary>
        /// Change a string so the first letter is uppercase
        /// </summary>
        /// <param name="s">string to change</param>
        /// <returns>the given string with the first character as uppercase</returns>
        private string FirstToUpper(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            return s.First().ToString().ToUpper() + s.Substring(1);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                string curItem = listBoxItems.SelectedItem.ToString();
                int index = listBoxItems.SelectedIndex;
                Console.WriteLine("Currently {0}, is selected with an index of {1}", curItem, index);
                //This replaces the old item with a new one in a list
                //listBoxItems.Items.RemoveAt(index);
                //listBoxItems.Items.Insert(index, curItem + "*");
                //listBoxItems.SetSelected(index, true);
            }
        }
    }
}
