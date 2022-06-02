namespace biblioteka
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.chitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblDataSet = new biblioteka.biblDataSet();
            this.chitaTableAdapter = new biblioteka.biblDataSetTableAdapters.ChitaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.кодЧитателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.действиеБилетаДоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.взятоКнигDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возвращеноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.действиеБилетаДоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.biblDataSet1 = new biblioteka.biblDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet1)).BeginInit();
            this.SuspendLayout();
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
            // chitaTableAdapter
            // 
            this.chitaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(562, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удаление по коду";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 2;
            // 
            // кодЧитателяDataGridViewTextBoxColumn
            // 
            this.кодЧитателяDataGridViewTextBoxColumn.DataPropertyName = "Код читателя";
            this.кодЧитателяDataGridViewTextBoxColumn.HeaderText = "Код читателя";
            this.кодЧитателяDataGridViewTextBoxColumn.Name = "кодЧитателяDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // действиеБилетаДоDataGridViewTextBoxColumn
            // 
            this.действиеБилетаДоDataGridViewTextBoxColumn.DataPropertyName = "Действие билета до";
            this.действиеБилетаДоDataGridViewTextBoxColumn.HeaderText = "Действие билета до";
            this.действиеБилетаДоDataGridViewTextBoxColumn.Name = "действиеБилетаДоDataGridViewTextBoxColumn";
            // 
            // взятоКнигDataGridViewTextBoxColumn
            // 
            this.взятоКнигDataGridViewTextBoxColumn.DataPropertyName = "Взято книг";
            this.взятоКнигDataGridViewTextBoxColumn.HeaderText = "Взято книг";
            this.взятоКнигDataGridViewTextBoxColumn.Name = "взятоКнигDataGridViewTextBoxColumn";
            // 
            // возвращеноDataGridViewTextBoxColumn
            // 
            this.возвращеноDataGridViewTextBoxColumn.DataPropertyName = "Возвращено";
            this.возвращеноDataGridViewTextBoxColumn.HeaderText = "Возвращено";
            this.возвращеноDataGridViewTextBoxColumn.Name = "возвращеноDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn1,
            this.действиеБилетаДоDataGridViewTextBoxColumn1,
            this.статусБилетаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chitaBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            // 
            // действиеБилетаДоDataGridViewTextBoxColumn1
            // 
            this.действиеБилетаДоDataGridViewTextBoxColumn1.DataPropertyName = "Действие билета до";
            this.действиеБилетаДоDataGridViewTextBoxColumn1.HeaderText = "Действие билета до";
            this.действиеБилетаДоDataGridViewTextBoxColumn1.Name = "действиеБилетаДоDataGridViewTextBoxColumn1";
            // 
            // статусБилетаDataGridViewTextBoxColumn
            // 
            this.статусБилетаDataGridViewTextBoxColumn.DataPropertyName = "Статус Билета";
            this.статусБилетаDataGridViewTextBoxColumn.HeaderText = "Статус Билета";
            this.статусБилетаDataGridViewTextBoxColumn.Name = "статусБилетаDataGridViewTextBoxColumn";
            // 
            // chitaBindingSource1
            // 
            this.chitaBindingSource1.DataMember = "Chita";
            this.chitaBindingSource1.DataSource = this.biblDataSet1;
            // 
            // biblDataSet1
            // 
            this.biblDataSet1.DataSetName = "biblDataSet";
            this.biblDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Код читателя",
            "Имя",
            "Фамилия",
            "Действие билета до",
            "Статус билета"});
            this.comboBox1.Location = new System.Drawing.Point(12, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(562, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(562, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Добавить читателя";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Введите искомое слово";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выберите категорию поиска";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Активен",
            "Неактивен"});
            this.comboBox2.Location = new System.Drawing.Point(278, 276);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(278, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 20);
            this.textBox3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(278, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Введите имя читателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(278, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Измените статус билета";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(278, 229);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(106, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(278, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Фамилию читателя";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 323);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Учет читателей";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private biblDataSet biblDataSet;
        private System.Windows.Forms.BindingSource chitaBindingSource;
        private biblDataSetTableAdapters.ChitaTableAdapter chitaTableAdapter;
       
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЧитателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn действиеБилетаДоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn взятоКнигDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возвращеноDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЧитателяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn взятоКнигDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn возвращеноDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private biblDataSet biblDataSet1;
        private System.Windows.Forms.BindingSource chitaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn действиеБилетаДоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусБилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
    }
}