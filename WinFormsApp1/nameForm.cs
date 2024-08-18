using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniusIdiot_WinForms
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        private void enterName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text))
                MessageBox.Show("Введите своё имя!!");
            else if (nameTextBox.Text.Any(c => char.IsNumber(c)))
                MessageBox.Show("Имя не может содержать цифры!!");
            else
                this.DialogResult = DialogResult.OK;
        }
    }
}
