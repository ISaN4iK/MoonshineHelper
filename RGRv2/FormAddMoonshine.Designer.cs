
namespace RGRv2
{
    partial class FormAddMoonshine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMoonshine));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDistillation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownButch = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlcohol = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBoxName = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCodeName = new System.Windows.Forms.ComboBox();
            this.containerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moonshineDataSet = new RGRv2.moonshineDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.containerTableAdapter = new RGRv2.moonshineDataSetTableAdapters.containerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistillation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownButch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlcohol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonshineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(34, 290);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(527, 38);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Количество перегонов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Размер паритии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Содержание алкоголя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Себестоимость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Название";
            // 
            // numericUpDownDistillation
            // 
            this.numericUpDownDistillation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownDistillation.Location = new System.Drawing.Point(278, 219);
            this.numericUpDownDistillation.Name = "numericUpDownDistillation";
            this.numericUpDownDistillation.Size = new System.Drawing.Size(100, 26);
            this.numericUpDownDistillation.TabIndex = 26;
            // 
            // numericUpDownButch
            // 
            this.numericUpDownButch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownButch.Location = new System.Drawing.Point(278, 121);
            this.numericUpDownButch.Name = "numericUpDownButch";
            this.numericUpDownButch.Size = new System.Drawing.Size(100, 26);
            this.numericUpDownButch.TabIndex = 25;
            // 
            // numericUpDownAlcohol
            // 
            this.numericUpDownAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAlcohol.Location = new System.Drawing.Point(278, 85);
            this.numericUpDownAlcohol.Name = "numericUpDownAlcohol";
            this.numericUpDownAlcohol.Size = new System.Drawing.Size(100, 26);
            this.numericUpDownAlcohol.TabIndex = 24;
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCost.Location = new System.Drawing.Point(278, 50);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(100, 26);
            this.numericUpDownCost.TabIndex = 23;
            // 
            // maskedTextBoxName
            // 
            this.maskedTextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxName.Location = new System.Drawing.Point(278, 15);
            this.maskedTextBoxName.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.maskedTextBoxName.Name = "maskedTextBoxName";
            this.maskedTextBoxName.Size = new System.Drawing.Size(258, 26);
            this.maskedTextBoxName.TabIndex = 22;
            this.maskedTextBoxName.TextChanged += new System.EventHandler(this.OnChangeSymbol);
            // 
            // comboBoxCodeName
            // 
            this.comboBoxCodeName.DataSource = this.containerBindingSource;
            this.comboBoxCodeName.DisplayMember = "Code_name";
            this.comboBoxCodeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCodeName.FormattingEnabled = true;
            this.comboBoxCodeName.Location = new System.Drawing.Point(278, 169);
            this.comboBoxCodeName.Name = "comboBoxCodeName";
            this.comboBoxCodeName.Size = new System.Drawing.Size(260, 28);
            this.comboBoxCodeName.TabIndex = 34;
            this.comboBoxCodeName.ValueMember = "ID_Container";
            // 
            // containerBindingSource
            // 
            this.containerBindingSource.DataMember = "container";
            this.containerBindingSource.DataSource = this.moonshineDataSet;
            // 
            // moonshineDataSet
            // 
            this.moonshineDataSet.DataSetName = "moonshineDataSet";
            this.moonshineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Кодовое название упаковки";
            // 
            // containerTableAdapter
            // 
            this.containerTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddMoonshine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 349);
            this.Controls.Add(this.comboBoxCodeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDistillation);
            this.Controls.Add(this.numericUpDownButch);
            this.Controls.Add(this.numericUpDownAlcohol);
            this.Controls.Add(this.numericUpDownCost);
            this.Controls.Add(this.maskedTextBoxName);
            this.MinimumSize = new System.Drawing.Size(615, 388);
            this.Name = "FormAddMoonshine";
            this.Text = "FormAddMoonshine";
            this.Load += new System.EventHandler(this.FormAddMoonshine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistillation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownButch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlcohol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonshineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDistillation;
        private System.Windows.Forms.NumericUpDown numericUpDownButch;
        private System.Windows.Forms.NumericUpDown numericUpDownAlcohol;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxName;
        private System.Windows.Forms.ComboBox comboBoxCodeName;
        private System.Windows.Forms.Label label5;
        private moonshineDataSet moonshineDataSet;
        private System.Windows.Forms.BindingSource containerBindingSource;
        private moonshineDataSetTableAdapters.containerTableAdapter containerTableAdapter;
    }
}