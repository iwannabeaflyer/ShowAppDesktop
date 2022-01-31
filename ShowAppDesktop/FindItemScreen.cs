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
        public FindItemScreen(JsonObject jsonObject)
        {
            InitializeComponent();
            jObject = jsonObject;

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
                //Add notification about selecting only 1 item
                MessageBox.Show(LanguageManager.GetTranslation("pickOneItem"));
                return;
            }

            this.DialogResult = DialogResult.Yes;
            ////Get selected item from the listbox
            //int i = listBoxItems.SelectedIndex;
            ////Open it
            //OpenItemScreen openItem = new OpenItemScreen(results[i]);
            //openItem.ShowDialog();
            Console.WriteLine("Not Implemented");
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItems.Count != 1)
            {
                //Add notification about selecting only 1 item
                MessageBox.Show(LanguageManager.GetTranslation("pickOneItem"));
                return;
            }

            //Find the equal of the selected item in the jsobobject
            //Open a EditItemScreen

            this.DialogResult = DialogResult.OK;
            Console.WriteLine("Not Implemented");
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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