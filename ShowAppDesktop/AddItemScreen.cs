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
    public partial class AddItemScreen : Form
    {
        public ModelItem model { get; set; }
        private int index;
        public AddItemScreen()
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
            model = new ModelItem();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            listBox_Genres.Items.Add(textBox_Edit.Text);
            textBox_Edit.Clear();
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
            listBox_Genres.SetSelected(0, false);
            textBox_Edit.Clear();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Saving object to Model");
            model.EnName = textBox_EnName.Text;
            model.AltName = textBox_AltName.Text;
            model.Episodes = (ushort)numericUpDown_Episodes.Value;
            model.Description = textBox_Description.Text;
            numericUpDown_Score.Value = model.Score;
            model.Episodes = (ushort)numericUpDown_RuntimeEpisode.Value;
            model.RunTime = (uint)numericUpDown_RuntimeTotal.Value;
            model.Notes = textBox_Notes.Text;
            foreach (string s in listBox_Genres.Items)
            {
                model.Genres.Add(s);
            }
            model.Watched = checkBox_Watched.Checked;
            model.HasEnd = checkBox_Ending.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}