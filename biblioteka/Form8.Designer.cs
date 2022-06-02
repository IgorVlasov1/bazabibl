namespace biblioteka
{
    partial class Form8
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblDataSet = new biblioteka.biblDataSet();
            this.knigiprilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knigiprilTableAdapter = new biblioteka.biblDataSetTableAdapters.KnigiprilTableAdapter();
            this.chitaTableAdapter = new biblioteka.biblDataSetTableAdapters.ChitaTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.chitaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.knigiprilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.knigiprilBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выдать книгу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите имя читателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите фамилию";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите дату выдачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Название книги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите автора";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.chitaBindingSource;
            this.comboBox1.DisplayMember = "Имя";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "Имя";
            // 
            // chitaBindingSource
            // 
            this.chitaBindingSource.DataMember = "Chita";
            this.chitaBindingSource.DataSource = this.biblDataSet;
            // 
            // biblDataSet
            // 
            this.biblDataSet.DataSetName = "biblDataSet";
            this.biblDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knigiprilBindingSource
            // 
            this.knigiprilBindingSource.DataMember = "Knigipril";
            this.knigiprilBindingSource.DataSource = this.biblDataSet;
            // 
            // knigiprilTableAdapter
            // 
            this.knigiprilTableAdapter.ClearBeforeFill = true;
            // 
            // chitaTableAdapter
            // 
            this.chitaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.chitaBindingSource1;
            this.comboBox2.DisplayMember = "Фамилия";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(129, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "Фамилия";
            // 
            // chitaBindingSource1
            // 
            this.chitaBindingSource1.DataMember = "Chita";
            this.chitaBindingSource1.DataSource = this.biblDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.knigiprilBindingSource1;
            this.comboBox3.DisplayMember = "Название";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 144);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(129, 21);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.ValueMember = "Название";
            // 
            // knigiprilBindingSource1
            // 
            this.knigiprilBindingSource1.DataMember = "Knigipril";
            this.knigiprilBindingSource1.DataSource = this.biblDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.knigiprilBindingSource2;
            this.comboBox4.DisplayMember = "Автор";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(12, 184);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(129, 21);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.ValueMember = "Автор";
            // 
            // knigiprilBindingSource2
            // 
            this.knigiprilBindingSource2.DataMember = "Knigipril";
            this.knigiprilBindingSource2.DataSource = this.biblDataSet;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(149, 260);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form8";
            this.Text = "Выдача книги";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private biblDataSet biblDataSet;
        private System.Windows.Forms.BindingSource knigiprilBindingSource;
        private biblDataSetTableAdapters.KnigiprilTableAdapter knigiprilTableAdapter;
        private System.Windows.Forms.BindingSource chitaBindingSource;
        private biblDataSetTableAdapters.ChitaTableAdapter chitaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource chitaBindingSource1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource knigiprilBindingSource1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource knigiprilBindingSource2;
    }
}