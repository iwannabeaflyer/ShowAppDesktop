using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowAppDesktop
{
    public partial class FindItemScreen : Form
    {
        public JsonObject jObject;
        private List<ModelItem> results = new List<ModelItem>();
        private MainScreen mainScreen;
        public FindItemScreen(MainScreen main, JsonObject jsonObject)
        {
            InitializeComponent();
            jObject = jsonObject;
            mainScreen = main;

            Console.WriteLine("Populating Find List");
            foreach (ModelItem item in jObject.Items)
            {
                listBoxItems.Items.Add(item.ReturnName());
                results.Add(item);
            }

            //do buttons and labels
            label_Search.Text = LanguageManager.GetTranslation("lblSearch");
            button_Open.Text = LanguageManager.GetTranslation("bttnOpen");
            button_Edit.Text = LanguageManager.GetTranslation("bttnEdit");
            button_Search.Text = LanguageManager.GetTranslation("bttnSearch");
            button_Close.Text = LanguageManager.GetTranslation("bttnClose");

            comboBox1.Items.Add(LanguageManager.GetTranslation("lblEnglish"));
            comboBox1.Items.Add(LanguageManager.GetTranslation("lblAlternative"));
            comboBox1.Items.Add(LanguageManager.GetTranslation("lblDescription"));
            comboBox1.Items.Add(LanguageManager.GetTranslation("lblGenres"));
            comboBox1.SelectedIndex = 0;

        }

        private void button_Search_Click(object sender, EventArgs e)
        {   //Get selected combo box item
            int selected = comboBox1.SelectedIndex;

            if (searchTextBox.Text.Length == 0)
            {
                MessageBox.Show(LanguageManager.GetTranslation("messageNoResults"));
                return;
            }

            //This code only selects all items that match
            listBoxItems.SelectedItems.Clear();
            for (int i = 0; i < listBoxItems.Items.Count; i++)
            {
                if (listBoxItems.Items[i].ToString().ToLower().Replace(" ", "").Contains(searchTextBox.Text.ToLower()))
                {
                    listBoxItems.SetSelected(i, true);
                }
            }
            if(listBoxItems.SelectedItems.Count == 0)
            {
                MessageBox.Show(LanguageManager.GetTranslation("messageNoResults"));
            }

            //This code picks out all of the items that match and repopulate the list with only these items
            ////Loop through all items and look for a string match from the searchbar
            //results = FindMatch(selected, searchTextBox.Text);
            ////Add the results to the listbox
            //if (results.Count > 0)
            //    {
            //        Console.WriteLine("Repopulation the listbox");
            //        listBoxItems.Items.Clear();
            //        foreach (ModelItem item in results)
            //        {
            //            listBoxItems.Items.Add(item.ReturnName());
            //        }
            //    }
            //    else
            //    {   //nothing has been found
            //        MessageBox.Show(LanguageManager.GetTranslation("messageNoResults"));
            //    }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItems.Count != 1)
            {
                MessageBox.Show(LanguageManager.GetTranslation("pickOneItem"));
                return;
            }
            OpenItemScreen openItemScreen = new OpenItemScreen(jObject.Items[listBoxItems.SelectedIndex]);
            openItemScreen.ShowDialog();
            
            this.DialogResult = DialogResult.Yes;
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItems.Count != 1)
            {
                MessageBox.Show(LanguageManager.GetTranslation("pickOneItem"));
                return;
            }
            int index = listBoxItems.SelectedIndex;

            EditItemScreen editItemScreen = new EditItemScreen(jObject.Items[index]);
            editItemScreen.ShowDialog();

            if (editItemScreen.DialogResult == DialogResult.OK)
            {
                mainScreen.ApplyEdit(ref editItemScreen, index);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<ModelItem> FindMatch(int index, string s)
        {
            s = s.ToLower();
            List<ModelItem> result = new List<ModelItem>();
            switch (index)
            {
                case 0: //English
                    foreach (ModelItem item in jObject.Items)
                    {
                        if (item.EnName.ToLower().Contains(s))
                        {
                            result.Add(item);
                        }
                    }
                    break;
                case 1: //Alternative
                    foreach (ModelItem item in jObject.Items)
                    {
                        if (item.AltName.ToLower().Contains(s))
                        {
                            result.Add(item);
                        }
                    }
                    break;
                case 2: //Description
                    foreach (ModelItem item in jObject.Items)
                    {
                        if (item.Description.ToLower().Contains(s))
                        {
                            result.Add(item);
                        }
                    }
                    break;
                case 3: //Genres
                    foreach (ModelItem item in jObject.Items)
                    {
                        foreach (string genre in item.Genres)
                        {
                            if (genre.ToLower().Contains(s))
                            {
                                result.Add(item);
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            results.Clear();
            return result;
        }
    }
}