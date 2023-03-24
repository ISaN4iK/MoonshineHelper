
namespace RGRv2
{
    partial class AddContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContainer));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxCodeName = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCodeContainer = new System.Windows.Forms.ComboBox();
            this.nameofcontainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moonshineDataSet = new RGRv2.moonshineDataSet();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.name_of_containerTableAdapter = new RGRv2.moonshineDataSetTableAdapters.name_of_containerTableAdapter();
            this.materialTableAdapter = new RGRv2.moonshineDataSetTableAdapters.materialTableAdapter();
            this.buttonAddCont = new System.Windows.Forms.Button();
            this.buttonAddMaterial = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nameofcontainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonshineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Кодовое название упаковки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Тип тары";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Материал тары";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Обьём одной тары";
            // 
            // maskedTextBoxCodeName
            // 
            this.maskedTextBoxCodeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxCodeName.Location = new System.Drawing.Point(324, 26);
            this.maskedTextBoxCodeName.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.maskedTextBoxCodeName.Name = "maskedTextBoxCodeName";
            this.maskedTextBoxCodeName.Size = new System.Drawing.Size(258, 26);
            this.maskedTextBoxCodeName.TabIndex = 38;
            this.maskedTextBoxCodeName.TextChanged += new System.EventHandler(this.OnChangeSymbol);
            // 
            // comboBoxCodeContainer
            // 
            this.comboBoxCodeContainer.DataSource = this.nameofcontainerBindingSource;
            this.comboBoxCodeContainer.DisplayMember = "Name";
            this.comboBoxCodeContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCodeContainer.FormattingEnabled = true;
            this.comboBoxCodeContainer.Location = new System.Drawing.Point(322, 65);
            this.comboBoxCodeContainer.Name = "comboBoxCodeContainer";
            this.comboBoxCodeContainer.Size = new System.Drawing.Size(260, 28);
            this.comboBoxCodeContainer.TabIndex = 39;
            this.comboBoxCodeContainer.ValueMember = "ID_name_of_container";
            // 
            // nameofcontainerBindingSource
            // 
            this.nameofcontainerBindingSource.DataMember = "name_of_container";
            this.nameofcontainerBindingSource.DataSource = this.moonshineDataSet;
            // 
            // moonshineDataSet
            // 
            this.moonshineDataSet.DataSetName = "moonshineDataSet";
            this.moonshineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DataSource = this.materialBindingSource;
            this.comboBoxMaterial.DisplayMember = "Material_name";
            this.comboBoxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(322, 142);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(260, 28);
            this.comboBoxMaterial.TabIndex = 40;
            this.comboBoxMaterial.ValueMember = "ID_Material";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "material";
            this.materialBindingSource.DataSource = this.moonshineDataSet;
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownVolume.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownVolume.Location = new System.Drawing.Point(322, 105);
            this.numericUpDownVolume.Name = "numericUpDownVolume";
            this.numericUpDownVolume.Size = new System.Drawing.Size(100, 26);
            this.numericUpDownVolume.TabIndex = 41;
            // 
            // name_of_containerTableAdapter
            // 
            this.name_of_containerTableAdapter.ClearBeforeFill = true;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddCont
            // 
            this.buttonAddCont.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddCont.Location = new System.Drawing.Point(26, 229);
            this.buttonAddCont.Name = "buttonAddCont";
            this.buttonAddCont.Size = new System.Drawing.Size(272, 48);
            this.buttonAddCont.TabIndex = 42;
            this.buttonAddCont.Text = "Добавить тип тары";
            this.buttonAddCont.UseVisualStyleBackColor = false;
            this.buttonAddCont.Click += new System.EventHandler(this.buttonAddCont_Click);
            // 
            // buttonAddMaterial
            // 
            this.buttonAddMaterial.Location = new System.Drawing.Point(322, 229);
            this.buttonAddMaterial.Name = "buttonAddMaterial";
            this.buttonAddMaterial.Size = new System.Drawing.Size(260, 48);
            this.buttonAddMaterial.TabIndex = 43;
            this.buttonAddMaterial.Text = "Добавить материал тары";
            this.buttonAddMaterial.UseVisualStyleBackColor = true;
            this.buttonAddMaterial.Click += new System.EventHandler(this.buttonAddMaterial_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(26, 294);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(556, 48);
            this.buttonAdd.TabIndex = 44;
            this.buttonAdd.Text = "Записать новую упаковку";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(633, 379);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonAddMaterial);
            this.Controls.Add(this.buttonAddCont);
            this.Controls.Add(this.numericUpDownVolume);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.comboBoxCodeContainer);
            this.Controls.Add(this.maskedTextBoxCodeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(649, 418);
            this.Name = "AddContainer";
            this.Text = "Добавление упаковки ";
            this.Activated += new System.EventHandler(this.AddContainer_Activated);
            this.Load += new System.EventHandler(this.AddContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameofcontainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonshineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodeName;
        private System.Windows.Forms.ComboBox comboBoxCodeContainer;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.NumericUpDown numericUpDownVolume;
        private moonshineDataSet moonshineDataSet;
        private System.Windows.Forms.BindingSource nameofcontainerBindingSource;
        private moonshineDataSetTableAdapters.name_of_containerTableAdapter name_of_containerTableAdapter;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private moonshineDataSetTableAdapters.materialTableAdapter materialTableAdapter;
        private System.Windows.Forms.Button buttonAddCont;
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.Button buttonAdd;
    }
}