namespace DataCon1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_dat2DataSet = new DataCon1.db_dat2DataSet();
            this.sellingHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellingHistoryTableAdapter = new DataCon1.db_dat2DataSetTableAdapters.SellingHistoryTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whoBuyerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whatTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howManyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whatTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eachValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toTalValDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dat2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.whoBuyerDataGridViewTextBoxColumn,
            this.whatTypeDataGridViewTextBoxColumn,
            this.howManyDataGridViewTextBoxColumn,
            this.whatTimeDataGridViewTextBoxColumn,
            this.buyerTypeDataGridViewTextBoxColumn,
            this.eachValueDataGridViewTextBoxColumn,
            this.toTalValDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sellingHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(110, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(384, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // db_dat2DataSet
            // 
            this.db_dat2DataSet.DataSetName = "db_dat2DataSet";
            this.db_dat2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellingHistoryBindingSource
            // 
            this.sellingHistoryBindingSource.DataMember = "SellingHistory";
            this.sellingHistoryBindingSource.DataSource = this.db_dat2DataSet;
            // 
            // sellingHistoryTableAdapter
            // 
            this.sellingHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // whoBuyerDataGridViewTextBoxColumn
            // 
            this.whoBuyerDataGridViewTextBoxColumn.DataPropertyName = "WhoBuyer";
            this.whoBuyerDataGridViewTextBoxColumn.HeaderText = "WhoBuyer";
            this.whoBuyerDataGridViewTextBoxColumn.Name = "whoBuyerDataGridViewTextBoxColumn";
            // 
            // whatTypeDataGridViewTextBoxColumn
            // 
            this.whatTypeDataGridViewTextBoxColumn.DataPropertyName = "WhatType";
            this.whatTypeDataGridViewTextBoxColumn.HeaderText = "WhatType";
            this.whatTypeDataGridViewTextBoxColumn.Name = "whatTypeDataGridViewTextBoxColumn";
            // 
            // howManyDataGridViewTextBoxColumn
            // 
            this.howManyDataGridViewTextBoxColumn.DataPropertyName = "HowMany";
            this.howManyDataGridViewTextBoxColumn.HeaderText = "HowMany";
            this.howManyDataGridViewTextBoxColumn.Name = "howManyDataGridViewTextBoxColumn";
            // 
            // whatTimeDataGridViewTextBoxColumn
            // 
            this.whatTimeDataGridViewTextBoxColumn.DataPropertyName = "WhatTime";
            this.whatTimeDataGridViewTextBoxColumn.HeaderText = "WhatTime";
            this.whatTimeDataGridViewTextBoxColumn.Name = "whatTimeDataGridViewTextBoxColumn";
            // 
            // buyerTypeDataGridViewTextBoxColumn
            // 
            this.buyerTypeDataGridViewTextBoxColumn.DataPropertyName = "BuyerType";
            this.buyerTypeDataGridViewTextBoxColumn.HeaderText = "BuyerType";
            this.buyerTypeDataGridViewTextBoxColumn.Name = "buyerTypeDataGridViewTextBoxColumn";
            // 
            // eachValueDataGridViewTextBoxColumn
            // 
            this.eachValueDataGridViewTextBoxColumn.DataPropertyName = "EachValue";
            this.eachValueDataGridViewTextBoxColumn.HeaderText = "EachValue";
            this.eachValueDataGridViewTextBoxColumn.Name = "eachValueDataGridViewTextBoxColumn";
            // 
            // toTalValDataGridViewTextBoxColumn
            // 
            this.toTalValDataGridViewTextBoxColumn.DataPropertyName = "ToTalVal";
            this.toTalValDataGridViewTextBoxColumn.HeaderText = "ToTalVal";
            this.toTalValDataGridViewTextBoxColumn.Name = "toTalValDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 343);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dat2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private db_dat2DataSet db_dat2DataSet;
        private System.Windows.Forms.BindingSource sellingHistoryBindingSource;
        private db_dat2DataSetTableAdapters.SellingHistoryTableAdapter sellingHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoBuyerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn howManyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eachValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toTalValDataGridViewTextBoxColumn;
    }
}

