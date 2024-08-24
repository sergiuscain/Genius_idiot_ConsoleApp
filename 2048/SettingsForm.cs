using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void saveSettings_Button_Click(object sender, EventArgs e)
        {
            try
            {
                PlayForm.blockSize = int.Parse(blockSize_TextBox.Text);
                PlayForm.mapSize = int.Parse(mapSize_TextBox.Text);
                if (int.Parse(blockSize_TextBox.Text) < 10 || int.Parse(blockSize_TextBox.Text) > 200 || int.Parse(mapSize_TextBox.Text) < 2 || int.Parse(mapSize_TextBox.Text) > 10)
                    return;
                else
                    this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Unable to save settings. Perhaps you entered incorrect data.");
            }
       }
    }
}
