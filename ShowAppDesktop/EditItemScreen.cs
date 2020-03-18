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
        public EditItemScreen(ModelItem item)
        {
            InitializeComponent();
            model = item;
            textBox_EnName.Text = item.EnName;
            textBox_AltName.Text = item.AltName;
            numericUpDown_Episodes.Value = item.Episodes;
            textBox_Description.Text = item.Description;
            numericUpDown_Score.Value = item.Score;
            numericUpDown_Runtime.Value = item.RunTime % Constants.MINUTES;
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
    }
}
