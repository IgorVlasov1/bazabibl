namespace biblioteka
{
    partial class Form9
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодВыданнойКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяЧитателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияЧитателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uchetVidBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.biblDataSet = new biblioteka.biblDataSet();
            this.uchetVidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetVidTableAdapter = new biblioteka.biblDataSetTableAdapters.UchetVidTableAdapter();
            this.uchetVidBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetVidBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetVidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetVidBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодВыданнойКнигиDataGridViewTextBoxColumn,
            this.датаВыдачиDataGridViewTextBoxColumn,
            this.имяЧитателяDataGridViewTextBoxColumn,
            this.фамилияЧитателяDataGridViewTextBoxColumn,
            this.названиеКнигиDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uchetVidBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодВыданнойКнигиDataGridViewTextBoxColumn
            // 
            this.кодВыданнойКнигиDataGridViewTextBoxColumn.DataPropertyName = "Код выданной книги";
            this.кодВыданнойКнигиDataGridViewTextBoxColumn.HeaderText = "Код выданной книги";
            this.кодВыданнойКнигиDataGridViewTextBoxColumn.Name = "кодВыданнойКнигиDataGridViewTextBoxColumn";
            this.кодВыданнойКнигиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаВыдачиDataGridViewTextBoxColumn
            // 
            this.датаВыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.Name = "датаВыдачиDataGridViewTextBoxColumn";
            // 
            // имяЧитателяDataGridViewTextBoxColumn
            // 
            this.имяЧитателяDataGridViewTextBoxColumn.DataPropertyName = "Имя читателя";
            this.имяЧитателяDataGridViewTextBoxColumn.HeaderText = "Имя читателя";
            this.имяЧитателяDataGridViewTextBoxColumn.Name = "имяЧитателяDataGridViewTextBoxColumn";
            // 
            // фамилияЧитателяDataGridViewTextBoxColumn
            // 
            this.фамилияЧитателяDataGridViewTextBoxColumn.DataPropertyName = "Фамилия читателя";
            this.фамилияЧитателяDataGridViewTextBoxColumn.HeaderText = "Фамилия читателя";
            this.фамилияЧитателяDataGridViewTextBoxColumn.Name = "фамилияЧитателяDataGridViewTextBoxColumn";
            // 
            // названиеКнигиDataGridViewTextBoxColumn
            // 
            this.названиеКнигиDataGridViewTextBoxColumn.DataPropertyName = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.HeaderText = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.Name = "названиеКнигиDataGridViewTextBoxColumn";
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            // 
            // uchetVidBindingSource2
            // 
            this.uchetVidBindingSource2.DataMember = "UchetVid";
            this.uchetVidBindingSource2.DataSource = this.biblDataSet;
            // 
            // biblDataSet
            // 
            this.biblDataSet.DataSetName = "biblDataSet";
            this.biblDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uchetVidBindingSource
            // 
            this.uchetVidBindingSource.DataMember = "UchetVid";
            this.uchetVidBindingSource.DataSource = this.biblDataSet;
            // 
            // biblDataSetBindingSource
            // 
            this.biblDataSetBindingSource.DataSource = this.biblDataSet;
            this.biblDataSetBindingSource.Position = 0;
            // 
            // uchetVidTableAdapter
            // 
            this.uchetVidTableAdapter.ClearBeforeFill = true;
            // 
            // uchetVidBindingSource1
            // 
            this.uchetVidBindingSource1.DataMember = "UchetVid";
            this.uchetVidBindingSource1.DataSource = this.biblDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(475, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите имя";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(475, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите фамилию";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(660, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetVidBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetVidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetVidBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private biblDataSet biblDataSet;
        private System.Windows.Forms.BindingSource biblDataSetBindingSource;
        private System.Windows.Forms.BindingSource uchetVidBindingSource;
        private biblDataSetTableAdapters.UchetVidTableAdapter uchetVidTableAdapter;
        private System.Windows.Forms.BindingSource uchetVidBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВыданнойКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяЧитателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияЧитателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uchetVidBindingSource2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}