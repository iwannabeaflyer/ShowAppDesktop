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
    public partial class OpenItemScreen : Form
    {
        public OpenItemScreen(ModelItem item)
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

            button_Close.Text = LanguageManager.GetTranslation("bttnClose");

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

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            this.Close();
        }
    }
}
