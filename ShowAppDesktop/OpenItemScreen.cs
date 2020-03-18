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
            textBox_EnName.Text = item.EnName;
            textBox_AltName.Text = item.AltName;
            textBox_Episodes.Text = item.Episodes.ToString();
            textBox_Description.Text = item.Description;
            foreach (string s in item.Genres)
            {
                listBox_Genres.Items.Add(s);
            }
            textBox_Score.Text = item.Score.ToString();
            textBox_Runtime.Text = item.RunTime.ToString();
            textBox_Notes.Text = item.Notes;
            checkBox_Watched.Checked = item.Watched;
            checkBox_Ending.Checked = item.HasEnd;
        }
    }
}
