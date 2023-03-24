using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RGRv2
{
    public partial class AddTypeContainer : Form
    {
        public static string connectionString = "Database=Moonshine;Data Source=localhost;User Id=root;Password=root";
        public static MySqlConnection database = new MySqlConnection(connectionString);

        public AddTypeContainer()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            database.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Name_of_container (Name) VALUES ('"
                        + maskedTextBoxName.Text
                        + "')", database);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("SQL-запрос: \n\n" + cmd.CommandText + "\n\nбыл выполнен успешно", "Запись успешно добaвлена", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n" + cmd.CommandText, "Произошла ошибка при добавлении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            database.Close();
            OnChangeSymbol(sender, e);
        }
        private void OnChangeSymbol(object sender, EventArgs e)
        {
            database.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM Name_of_container "
                                    + " WHERE Name = '"
                                    + maskedTextBoxName.Text + "'", database);

            try
            {
                int Amount_of_strings = System.Convert.ToInt32(cmd.ExecuteScalar());
                if (Amount_of_strings > 0)
                {
                    this.buttonAdd.Enabled = false;
                }
                else
                {
                    this.buttonAdd.Enabled = true;
                }
            }
            catch (MySqlException ex) { }
            database.Close();
        }
    }
}
