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
    public partial class FormAddMoonshine : Form
    {
        public static string connectionString = "Database=Moonshine;Data Source=localhost;User Id=root;Password=root";
        public static MySqlConnection database = new MySqlConnection(connectionString);
        public FormAddMoonshine()
        {
            InitializeComponent();
        }
        private void FormAddMoonshine_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.container". При необходимости она может быть перемещена или удалена.
            this.containerTableAdapter.Fill(this.moonshineDataSet.container);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            database.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO moonshine (Name, Cost_price, alcohol, Batch_size, ID_Container, Num_of_distillation) VALUES ('"
                        + maskedTextBoxName.Text
                        + "', "
                        + numericUpDownCost.Value
                        + ", "
                        + numericUpDownAlcohol.Value
                        + ", "
                        + numericUpDownButch.Value
                        + ", "
                        + comboBoxCodeName.SelectedValue
                        + ", "
                        + numericUpDownDistillation.Value
                        + ") ", database);
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
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM moonshine "
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