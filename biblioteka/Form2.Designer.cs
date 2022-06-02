namespace biblioteka
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.knigiprilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.biblDataSet = new biblioteka.biblDataSet();
            this.knigiprilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knigiprilTableAdapter = new biblioteka.biblDataSetTableAdapters.KnigiprilTableAdapter();
            this.biblDataSet1 = new biblioteka.biblDataSet();
            this.knigiprilBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.переплетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПоступленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.переплетDataGridViewTextBoxColumn,
            this.датаПоступленияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.knigiprilBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(5, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(549, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удаление названию книги";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Код",
            "Название",
            "Автор",
            "Переплет",
            "Дата поступления"});
            this.comboBox1.Location = new System.Drawing.Point(15, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите искомое слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите категорию поиска";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(549, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(549, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "Добавить книгу";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Внести изменения";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(216, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(213, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Введите название книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(213, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Выберите дату поступления";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(549, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 38);
            this.button6.TabIndex = 21;
            this.button6.Text = "Выдать книгу";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // knigiprilBindingSource1
            // 
            this.knigiprilBindingSource1.DataMember = "Knigipril";
            this.knigiprilBindingSource1.DataSource = this.biblDataSet;
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
            // biblDataSet1
            // 
            this.biblDataSet1.DataSetName = "biblDataSet";
            this.biblDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knigiprilBindingSource2
            // 
            this.knigiprilBindingSource2.DataMember = "Knigipril";
            this.knigiprilBindingSource2.DataSource = this.biblDataSet1;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            // 
            // переплетDataGridViewTextBoxColumn
            // 
            this.переплетDataGridViewTextBoxColumn.DataPropertyName = "Переплет";
            this.переплетDataGridViewTextBoxColumn.HeaderText = "Переплет";
            this.переплетDataGridViewTextBoxColumn.Name = "переплетDataGridViewTextBoxColumn";
            // 
            // датаПоступленияDataGridViewTextBoxColumn
            // 
            this.датаПоступленияDataGridViewTextBoxColumn.DataPropertyName = "Дата поступления";
            this.датаПоступленияDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.датаПоступленияDataGridViewTextBoxColumn.Name = "датаПоступленияDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(692, 350);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Учет книг в зале";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiprilBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private biblDataSet biblDataSet;
        private System.Windows.Forms.BindingSource knigiprilBindingSource;
        private biblDataSetTableAdapters.KnigiprilTableAdapter knigiprilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПолученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource knigiprilBindingSource1;
        private biblDataSet biblDataSet1;
        private System.Windows.Forms.BindingSource knigiprilBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn переплетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПоступленияDataGridViewTextBoxColumn;
    }
}