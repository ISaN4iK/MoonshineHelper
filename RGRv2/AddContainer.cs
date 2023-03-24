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
    public partial class AddContainer : Form
    {
        public static string connectionString = "Database=Moonshine;Data Source=localhost;User Id=root;Password=root";
        public static MySqlConnection database = new MySqlConnection(connectionString);

        public AddContainer()
        {
            InitializeComponent();
        }

        private void AddContainer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.moonshineDataSet.material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.name_of_container". При необходимости она может быть перемещена или удалена.
            this.name_of_containerTableAdapter.Fill(this.moonshineDataSet.name_of_container);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            database.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO container (Code_name, ID_name_of_container, Container_volume, ID_material)VALUES ('"
                        + maskedTextBoxCodeName.Text
                        + "', "
                        + comboBoxCodeContainer.SelectedValue
                        + ", "
                        + numericUpDownVolume.Value
                        + ", "
                        + comboBoxMaterial.SelectedValue
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
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM container "
                                    + " WHERE Code_name = '"
                                    + maskedTextBoxCodeName.Text + "'", database);

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

        private void buttonAddCont_Click(object sender, EventArgs e)
        {
            AddTypeContainer form = new AddTypeContainer();
            form.ShowDialog();
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            AddMaterial form = new AddMaterial();
            form.ShowDialog();
        }

        private void AddContainer_Activated(object sender, EventArgs e)
        {
            this.materialTableAdapter.Fill(this.moonshineDataSet.material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.name_of_container". При необходимости она может быть перемещена или удалена.
            this.name_of_containerTableAdapter.Fill(this.moonshineDataSet.name_of_container);
        }
    }
}