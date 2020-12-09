namespace Mock_Exam
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_update = new System.Windows.Forms.Button();
            this.bttn_delete = new System.Windows.Forms.Button();
            this.bttn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_databaseDataSet = new Mock_Exam.test_databaseDataSet();
            this.testingTableAdapter = new Mock_Exam.test_databaseDataSetTableAdapters.testingTableAdapter();
            this.mainDatabaseDataSet = new Mock_Exam.MainDatabaseDataSet();
            this.maintableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.main_tableTableAdapter = new Mock_Exam.MainDatabaseDataSetTableAdapters.Main_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 0;
            // 
            // bttn_search
            // 
            this.bttn_search.Location = new System.Drawing.Point(364, 77);
            this.bttn_search.Name = "bttn_search";
            this.bttn_search.Size = new System.Drawing.Size(95, 20);
            this.bttn_search.TabIndex = 1;
            this.bttn_search.Text = "Search";
            this.bttn_search.UseVisualStyleBackColor = true;
            this.bttn_search.Click += new System.EventHandler(this.bttn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search for an Item:";
            // 
            // bttn_update
            // 
            this.bttn_update.Location = new System.Drawing.Point(363, 112);
            this.bttn_update.Name = "bttn_update";
            this.bttn_update.Size = new System.Drawing.Size(96, 23);
            this.bttn_update.TabIndex = 4;
            this.bttn_update.Text = "Update";
            this.bttn_update.UseVisualStyleBackColor = true;
            this.bttn_update.Click += new System.EventHandler(this.bttn_update_Click);
            // 
            // bttn_delete
            // 
            this.bttn_delete.Location = new System.Drawing.Point(363, 141);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(95, 23);
            this.bttn_delete.TabIndex = 5;
            this.bttn_delete.Text = "Delete";
            this.bttn_delete.UseVisualStyleBackColor = true;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            // 
            // bttn_add
            // 
            this.bttn_add.Location = new System.Drawing.Point(363, 170);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(95, 58);
            this.bttn_add.TabIndex = 6;
            this.bttn_add.Text = "Add A New Item";
            this.bttn_add.UseVisualStyleBackColor = true;
            this.bttn_add.Click += new System.EventHandler(this.bttn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "digital asset management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maintableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 316);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // testingBindingSource
            // 
            this.testingBindingSource.DataMember = "testing";
            this.testingBindingSource.DataSource = this.test_databaseDataSet;
            // 
            // test_databaseDataSet
            // 
            this.test_databaseDataSet.DataSetName = "test_databaseDataSet";
            this.test_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testingTableAdapter
            // 
            this.testingTableAdapter.ClearBeforeFill = true;
            // 
            // mainDatabaseDataSet
            // 
            this.mainDatabaseDataSet.DataSetName = "MainDatabaseDataSet";
            this.mainDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maintableBindingSource
            // 
            this.maintableBindingSource.DataMember = "Main_table";
            this.maintableBindingSource.DataSource = this.mainDatabaseDataSet;
            // 
            // main_tableTableAdapter
            // 
            this.main_tableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(472, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttn_add);
            this.Controls.Add(this.bttn_delete);
            this.Controls.Add(this.bttn_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_search);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_update;
        private System.Windows.Forms.Button bttn_delete;
        private System.Windows.Forms.Button bttn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private test_databaseDataSet test_databaseDataSet;
        private System.Windows.Forms.BindingSource testingBindingSource;
        private test_databaseDataSetTableAdapters.testingTableAdapter testingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private MainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource maintableBindingSource;
        private MainDatabaseDataSetTableAdapters.Main_tableTableAdapter main_tableTableAdapter;
    }
}

