namespace _12labbib
{
    partial class MainForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.booksBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDb4DataSet = new _12labbib.LibraryDb4DataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDbDataSet = new _12labbib.LibraryDbDataSet();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new _12labbib.LibraryDbDataSetTableAdapters.BooksTableAdapter();
            this.iDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.libraryDb2DataSet = new _12labbib.LibraryDb2DataSet();
            this.booksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter1 = new _12labbib.LibraryDb2DataSetTableAdapters.BooksTableAdapter();
            this.booksTableAdapter2 = new _12labbib.LibraryDb4DataSetTableAdapters.BooksTableAdapter();
            this.booksBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryDb2DataSet1 = new _12labbib.LibraryDb2DataSet1();
            this.booksBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter3 = new _12labbib.LibraryDb2DataSet1TableAdapters.BooksTableAdapter();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDb4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDb2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDb2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(703, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.Date,
            this.Client,
            this.Tovar,
            this.Number});
            this.dataGridView2.DataSource = this.booksBindingSource6;
            this.dataGridView2.Location = new System.Drawing.Point(12, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(639, 394);
            this.dataGridView2.TabIndex = 4;
            // 
            // booksBindingSource3
            // 
            this.booksBindingSource3.DataMember = "Books";
            this.booksBindingSource3.DataSource = this.libraryDb4DataSet;
            // 
            // libraryDb4DataSet
            // 
            this.libraryDb4DataSet.DataSetName = "LibraryDb4DataSet";
            this.libraryDb4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDbDataSetBindingSource;
            // 
            // libraryDbDataSetBindingSource
            // 
            this.libraryDbDataSetBindingSource.DataSource = this.libraryDbDataSet;
            this.libraryDbDataSetBindingSource.Position = 0;
            // 
            // libraryDbDataSet
            // 
            this.libraryDbDataSet.DataSetName = "LibraryDbDataSet";
            this.libraryDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.libraryDbDataSetBindingSource;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // iDToolStripLabel
            // 
            this.iDToolStripLabel.Name = "iDToolStripLabel";
            this.iDToolStripLabel.Size = new System.Drawing.Size(21, 22);
            this.iDToolStripLabel.Text = "ID:";
            // 
            // iDToolStripTextBox
            // 
            this.iDToolStripTextBox.Name = "iDToolStripTextBox";
            this.iDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripLabel,
            this.iDToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(820, 25);
            this.fillByToolStrip.TabIndex = 5;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(657, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 89);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // libraryDb2DataSet
            // 
            this.libraryDb2DataSet.DataSetName = "LibraryDb2DataSet";
            this.libraryDb2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource2
            // 
            this.booksBindingSource2.DataMember = "Books";
            this.booksBindingSource2.DataSource = this.libraryDb2DataSet;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // booksTableAdapter2
            // 
            this.booksTableAdapter2.ClearBeforeFill = true;
            // 
            // booksBindingSource4
            // 
            this.booksBindingSource4.DataMember = "Books";
            this.booksBindingSource4.DataSource = this.libraryDbDataSetBindingSource;
            // 
            // booksBindingSource5
            // 
            this.booksBindingSource5.DataMember = "Books";
            this.booksBindingSource5.DataSource = this.libraryDbDataSetBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // libraryDb2DataSet1
            // 
            this.libraryDb2DataSet1.DataSetName = "LibraryDb2DataSet1";
            this.libraryDb2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource6
            // 
            this.booksBindingSource6.DataMember = "Books";
            this.booksBindingSource6.DataSource = this.libraryDb2DataSet1;
            // 
            // booksTableAdapter3
            // 
            this.booksTableAdapter3.ClearBeforeFill = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client";
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            // 
            // Tovar
            // 
            this.Tovar.DataPropertyName = "Tovar";
            this.Tovar.HeaderText = "Tovar";
            this.Tovar.Name = "Tovar";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDb4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDb2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDb2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource libraryDbDataSetBindingSource;
        private LibraryDbDataSet libraryDbDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDbDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.ToolStripLabel iDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private LibraryDb2DataSet libraryDb2DataSet;
        private System.Windows.Forms.BindingSource booksBindingSource2;
        private LibraryDb2DataSetTableAdapters.BooksTableAdapter booksTableAdapter1;
        private LibraryDb4DataSet libraryDb4DataSet;
        private System.Windows.Forms.BindingSource booksBindingSource3;
        private LibraryDb4DataSetTableAdapters.BooksTableAdapter booksTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource booksBindingSource5;
        private System.Windows.Forms.BindingSource booksBindingSource4;
        private LibraryDb2DataSet1 libraryDb2DataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource6;
        private LibraryDb2DataSet1TableAdapters.BooksTableAdapter booksTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
    }
}