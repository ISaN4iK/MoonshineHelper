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
    public partial class FormMoonshine : Form
    {
        public static string connectionString = "Database=Moonshine;Data Source=localhost;User Id=root;Password=root";
        public static MySqlConnection database = new MySqlConnection(connectionString);   
        public FormMoonshine()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.moonshineDataSet.material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.name_of_container". При необходимости она может быть перемещена или удалена.
            this.name_of_containerTableAdapter.Fill(this.moonshineDataSet.name_of_container);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.flavors". При необходимости она может быть перемещена или удалена.
            this.flavorsTableAdapter.Fill(this.moonshineDataSet.flavors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.container". При необходимости она может быть перемещена или удалена.
            this.containerTableAdapter.Fill(this.moonshineDataSet.container);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.moonshinePreview". При необходимости она может быть перемещена или удалена.
            this.moonshinePreviewTableAdapter.Fill(this.moonshineDataSet.moonshinePreview);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.moonshine". При необходимости она может быть перемещена или удалена.
            this.moonshineTableAdapter.Fill(this.moonshineDataSet.moonshine);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddMoonshine form = new FormAddMoonshine();
            form.ShowDialog();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            moonshineTableAdapter.Update(moonshineDataSet.moonshine);
        }

        private void FormMoonshine_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.moonshineDataSet.material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.name_of_container". При необходимости она может быть перемещена или удалена.
            this.name_of_containerTableAdapter.Fill(this.moonshineDataSet.name_of_container);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.flavors". При необходимости она может быть перемещена или удалена.
            this.flavorsTableAdapter.Fill(this.moonshineDataSet.flavors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.container". При необходимости она может быть перемещена или удалена.
            this.containerTableAdapter.Fill(this.moonshineDataSet.container);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.moonshinePreview". При необходимости она может быть перемещена или удалена.
            this.moonshineTableAdapter.Fill(this.moonshineDataSet.moonshine);

        }

        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            int i = this.moonshineBindingSource.Find("Name", toolStripTextBoxSearch.Text);
            if (i == -1)
            {
                DataView dv = new DataView(this.moonshineDataSet.moonshine as DataTable);
                dv.RowFilter = string.Format("Name LIKE '%{0}%'", this.toolStripTextBoxSearch.Text);
                if (dv.Count != 0)
                {
                    i = this.moonshineBindingSource.Find("Name", dv[0]["Name"]);
                }
                dv.Dispose();
            }
            this.moonshineBindingSource.Position = i;
        }

        private void toolStripButtonSetFlaver_Click(object sender, EventArgs e)
        {
            SetFlaver form = new SetFlaver();
            form.ShowDialog();
        }

        private void toolStripButtonAddContainer_Click(object sender, EventArgs e)
        {
            AddContainer form = new AddContainer();
            form.ShowDialog();
        }

        private void toolStripButtonAddFlower_Click(object sender, EventArgs e)
        {
            AddFlaver form = new AddFlaver();
            form.ShowDialog();
        }

        private void toolStripButtonSaveCont_Click(object sender, EventArgs e)
        {
            this.containerTableAdapter.Update(this.moonshineDataSet.container);
        }

        private void toolStripButtonSaveTypeCont_Click(object sender, EventArgs e)
        {
            this.name_of_containerTableAdapter.Update(this.moonshineDataSet.name_of_container);
        }

        private void toolStripButtonSaveMaterial_Click(object sender, EventArgs e)
        {
            this.materialTableAdapter.Update(this.moonshineDataSet.material);

        }

        private void buttonAddCont_Click(object sender, EventArgs e)
        {
            AddContainer form = new AddContainer();
            form.ShowDialog();
        }

        private void buttonAddFlaver_Click(object sender, EventArgs e)
        {
            AddFlaver form = new AddFlaver();
            form.ShowDialog();
        }

        private void buttonAddTypeCont_Click(object sender, EventArgs e)
        {
            AddTypeContainer form = new AddTypeContainer();
            form.ShowDialog();
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            AddMaterial form = new AddMaterial();
            form.ShowDialog();
        }
    }
}
