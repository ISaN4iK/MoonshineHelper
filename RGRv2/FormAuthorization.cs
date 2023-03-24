using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGRv2
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            if(login != "asd" || password != "asd")
            {
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                MessageBox.Show("Вы что-то ввели не так", "Ошибка авторизации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                FormMoonshine formMain = new FormMoonshine();
                formMain.ShowDialog();
                this.Close();
            }
        }
    }
}
