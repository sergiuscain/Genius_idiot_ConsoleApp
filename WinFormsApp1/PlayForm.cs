using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace GeniusIdiot_WinForms
{
    public partial class PlayForm : Form
    {
        Form formtoopen;
        public PlayForm(Form main)
        {
            InitializeComponent();
            MainMenuForm.ActiveForm.Hide();
            formtoopen = main;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            MainMenuForm.ActiveForm.Show();
            this.Close();
        }
    }
}
