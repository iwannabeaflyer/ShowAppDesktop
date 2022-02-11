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
    public partial class EditItemScreen : Form
    {
        public ModelItem model { get; set; }
        private int index;
        public EditItemScreen(ModelItem item)
        {
            InitializeComponent();

            label_EnName.Text = LanguageManager.GetTranslation("lblEnglish");
            label_AltName.Text = LanguageManager.GetTranslation("lblAlternative");
            label_Episodes.Text = LanguageManager.GetTranslation("lblEpisodes");
            label_Genres.Text = LanguageManager.GetTranslation("lblGenres");
            label_Description.Text = LanguageManager.GetTranslation("lblDescription");
            label_RuntimeEpisode.Text = LanguageManager.GetTranslation("lblRuntimeEpisodes");
            label_RuntimeTotal.Text = LanguageManager.GetTranslation("lblRuntimeTotal");
            label_Score.Text = LanguageManager.GetTranslation("lblScore");
            label_Watched.Text = LanguageManager.GetTranslation("lblWatched");
            label_Ending.Text = LanguageManager.GetTranslation("lblEnding");
            label_Notes.Text = LanguageManager.GetTranslation("lblNotes");

            button_Edit.Text = LanguageManager.GetTranslation("bttnEdit");
            button_Delete.Text = LanguageManager.GetTranslation("bttnDelete");
            button_Save.Text = LanguageManager.GetTranslation("bttnSave");
            button_Cancel.Text = LanguageManager.GetTranslation("bttnCancel");

            model = item;
            textBox_EnName.Text = item.EnName;
            textBox_AltName.Text = item.AltName;
            numericUpDown_Episodes.Value = item.Episodes;
            textBox_Description.Text = item.Description;
            numericUpDown_Score.Value = item.Score;
            numericUpDown_RuntimeEpisode.Value = item.RunTime / item.Episodes;
            numericUpDown_RuntimeTotal.Value = item.RunTime;
            textBox_Notes.Text = item.Notes;
            foreach (string s in item.Genres)
            {
                listBox_Genres.Items.Add(s);
            }
            checkBox_Watched.Checked = item.Watched;
            checkBox_Ending.Checked = item.HasEnd;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void listBox_Genres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Genres.SelectedItem != null)
            {
                textBox_Edit.Text = listBox_Genres.SelectedItem.ToString();
                index = listBox_Genres.SelectedIndex;
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            listBox_Genres.Items.RemoveAt(index);
            listBox_Genres.Items.Insert(index, textBox_Edit.Text);
            listBox_Genres.SetSelected(index, false);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            listBox_Genres.Items.RemoveAt(listBox_Genres.SelectedIndex);
            listBox_Genres.SetSelected(0,false);
            textBox_Edit.Clear();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            listBox_Genres.Items.Add(char.ToUpper(textBox_Edit.Text[0]) + textBox_Edit.Text.Substring(1).ToLower());
            textBox_Edit.Clear();
        }
    }
}