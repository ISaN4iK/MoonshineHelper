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
    public partial class SetFlaver : Form
    {
        public SetFlaver()
        {
            InitializeComponent();
        }

        private void SetFlaver_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.additional_flavors". При необходимости она может быть перемещена или удалена.
            this.additional_flavorsTableAdapter.Fill(this.moonshineDataSet.additional_flavors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.flavors". При необходимости она может быть перемещена или удалена.
            this.flavorsTableAdapter.Fill(this.moonshineDataSet.flavors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moonshineDataSet.moonshine". При необходимости она может быть перемещена или удалена.
            this.moonshineTableAdapter.Fill(this.moonshineDataSet.moonshine);

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            this.additional_flavorsTableAdapter.Update(moonshineDataSet.additional_flavors);
        }
    }
}
