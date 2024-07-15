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
 * Look to get raw data from websites to automate filling in or updating items (html agility pack)
 * Don't look too much to Code Metrics since a good bit of the lower score is the initializing the many input / fields
     */

namespace ShowAppDesktop
{
    public partial class MainScreen : Form
    {
        #region Variables
        private string jsonString = "";
        //private string cmd;
        private bool IsChanged = false;
        public JsonObject jsonObject = JsonSingleton.Instance;
        //private JsonObject jsonObject = new JsonObject();
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
            button_Search.Text = LanguageManager.GetTranslation("bttnSearch");
            button_Save.Text = LanguageManager.GetTranslation("bttnSave");
            button_Load.Text = LanguageManager.GetTranslation("bttnLoad");
            button_Settings.Text = LanguageManager.GetTranslation("bttnSettings");
            button_Quit.Text = LanguageManager.GetTranslation("bttnExit");
            button_Open.Text = LanguageManager.GetTranslation("bttnOpen");
            button_Edit_Selected.Text = LanguageManager.GetTranslation("bttnEdit");

            //REMOVE ONCE DONE TESTING LOADING, SAVING, OPENING, EDITTING
            jsonObject.Items.Clear();
            jsonString = new StreamReader(Constants.TEMPJSONFILE).ReadToEnd();


            if (!string.IsNullOrEmpty(jsonString))
            {
                jsonObject = Deserialize(jsonString);
                RepopulateList();
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //Open basicly a copy of the OpenItemScreen but with more instructions
            //After Saving, add the item to the JsonObject and the listboxItems
            AddItemScreen addItemScreen = new AddItemScreen();
            addItemScreen.ShowDialog();

            if (addItemScreen.DialogResult == DialogResult.OK)
            {
                jsonObject.Items.Add(addItemScreen.model);
                listBoxItems.Items.Add(addItemScreen.model.ReturnName());
                addItemScreen.Close();
            }
            else if (addItemScreen.DialogResult == DialogResult.Cancel)
            {
                addItemScreen.Close();
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItems.Count > 1 || listBoxItems.SelectedIndex == -1 || listBoxItems.SelectedIndex > listBoxItems.Items.Count) return;

            listBoxItems.Items.RemoveAt(listBoxItems.SelectedIndex);
            listBoxItems.ClearSelected();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            FindItemScreen findItemScreen = new FindItemScreen(this, jsonObject);
            findItemScreen.ShowDialog();

            if (findItemScreen.DialogResult == DialogResult.OK)
            {
                RepopulateList();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //Save the updated jsonObject
            MainSave();
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            MainLoad();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            //Open an settings screen to change language
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            if (IsChanged)
            {
                //Open popup to ask if you want to save
                DialogResult result = MessageBox.Show("There are currently unsaved changes, do you want to continue?", "Unsaved changes", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;

                //initate saving
                MainSave();
            }

            Application.Exit();
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1 || listBoxItems.SelectedItems.Count > 1) return;
            ModelItem openItem = jsonObject.Items[listBoxItems.SelectedIndex];
            OpenItemScreen openItemScreen = new OpenItemScreen(openItem);
            openItemScreen.ShowDialog();

            //ListViewItem temp = listBoxItems.SelectedItem;

        }

        private void button_Edit_Selected_Click(object sender, EventArgs e)
        {
            int index = listBoxItems.SelectedIndex;
            if (index == -1) return;

            ModelItem openItem = jsonObject.Items[index];
            EditItemScreen editItemScreen = new EditItemScreen(openItem);
            DialogResult dialogResult = editItemScreen.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ApplyEdit(ref editItemScreen, index);
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            RepopulateList();
        }
        #endregion

        #region MainFunctions
        private void MainAdd()
        {

        }

        private void MainFind()
        {

        }

        private void MainEdit()
        {

        }

        private void MainLoad()
        {
            Console.WriteLine(LanguageManager.GetTranslation("load"));
            jsonObject.Items.Clear();
            jsonString = LoadFile();
            if (!string.IsNullOrEmpty(jsonString))
            {
                jsonObject = Deserialize(jsonString);
                RepopulateList();
            }

            Console.WriteLine(LanguageManager.GetTranslation("loadComplete"));
        }

        private void RepopulateList()
        {
            listBoxItems.Items.Clear();
            foreach (ModelItem item in jsonObject.Items)
            {
                //ListViewItem listViewItem = new ListViewItem();
                //listViewItem.Name = item.ReturnName();
                //listViewItem.Tag = item;

                //listBoxItems.Items.Add(listViewItem);
                listBoxItems.Items.Add(item.ReturnName());
            }
        }

        private void MainSave()
        {
            jsonString = Serialize(jsonObject);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = Constants.OPENFILEFILTER;
            saveFileDialog.Title = "Save an Json File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, jsonString);
                IsChanged = false;
            }
        }

        private void MainSettings()
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
            Console.WriteLine(fileName);
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

        private string Serialize(JsonObject jsonObject)
        {
            string json = JsonSerializer.Serialize(jsonObject);
            return json;
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
            return ob;
        }

        public void ApplyEdit(ref EditItemScreen editItemScreen, int index)
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
