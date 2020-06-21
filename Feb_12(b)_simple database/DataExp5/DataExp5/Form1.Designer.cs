namespace DataExp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInsertData = new System.Windows.Forms.Button();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSLNo = new System.Windows.Forms.TextBox();
            this.cardetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carModelsDataSet = new DataExp3.CarModelsDataSet();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtQouteRef = new System.Windows.Forms.TextBox();
            this.car_detailTableAdapter = new DataExp3.CarModelsDataSetTableAdapters.car_detailTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemInQuote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalQuoteVal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.txtStatusOfQuote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carModelsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertData
            // 
            this.btnInsertData.Location = new System.Drawing.Point(15, 354);
            this.btnInsertData.Name = "btnInsertData";
            this.btnInsertData.Size = new System.Drawing.Size(120, 47);
            this.btnInsertData.TabIndex = 4;
            this.btnInsertData.Text = "Insert Data";
            this.btnInsertData.UseVisualStyleBackColor = true;
            this.btnInsertData.Click += new System.EventHandler(this.btnInsertData_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(151, 354);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(120, 47);
            this.btnUpdateData.TabIndex = 5;
            this.btnUpdateData.Text = "Update Data";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Location = new System.Drawing.Point(290, 354);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(120, 47);
            this.btnDeleteData.TabIndex = 6;
            this.btnDeleteData.Text = "Delete Data";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sl no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cust Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quote Ref";
            // 
            // txtSLNo
            // 
            this.txtSLNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardetailBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.txtSLNo.Location = new System.Drawing.Point(110, 263);
            this.txtSLNo.Name = "txtSLNo";
            this.txtSLNo.Size = new System.Drawing.Size(49, 22);
            this.txtSLNo.TabIndex = 10;
            // 
            // cardetailBindingSource
            // 
            this.cardetailBindingSource.DataMember = "car_detail";
            this.cardetailBindingSource.DataSource = this.carModelsDataSet;
            // 
            // carModelsDataSet
            // 
            this.carModelsDataSet.DataSetName = "CarModelsDataSet";
            this.carModelsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(178, 263);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(188, 22);
            this.txtCustName.TabIndex = 11;
            // 
            // txtQouteRef
            // 
            this.txtQouteRef.Location = new System.Drawing.Point(385, 263);
            this.txtQouteRef.Name = "txtQouteRef";
            this.txtQouteRef.Size = new System.Drawing.Size(167, 22);
            this.txtQouteRef.TabIndex = 12;
            // 
            // car_detailTableAdapter
            // 
            this.car_detailTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 232);
            this.dataGridView1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Location = new System.Drawing.Point(889, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 93);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Box :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search anything :";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(17, 53);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(236, 22);
            this.textBoxSearch.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quote Date";
            // 
            // txtItemInQuote
            // 
            this.txtItemInQuote.Location = new System.Drawing.Point(745, 263);
            this.txtItemInQuote.Name = "txtItemInQuote";
            this.txtItemInQuote.Size = new System.Drawing.Size(167, 22);
            this.txtItemInQuote.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(742, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Item in Quote";
            // 
            // txtTotalQuoteVal
            // 
            this.txtTotalQuoteVal.Location = new System.Drawing.Point(936, 263);
            this.txtTotalQuoteVal.Name = "txtTotalQuoteVal";
            this.txtTotalQuoteVal.Size = new System.Drawing.Size(134, 22);
            this.txtTotalQuoteVal.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(933, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Quote value";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 313);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 21);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Quoted";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(107, 313);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 21);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Offer pending";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(249, 313);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(110, 21);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.Text = "Enq Revised";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(380, 313);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(124, 21);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.Text = "Quote Revised";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(515, 313);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(94, 21);
            this.checkBox5.TabIndex = 26;
            this.checkBox5.Text = "PO Recvd";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(650, 313);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(102, 21);
            this.checkBox6.TabIndex = 27;
            this.checkBox6.Text = "Negotiation";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(769, 313);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(114, 21);
            this.checkBox7.TabIndex = 28;
            this.checkBox7.Text = "Enq Dropped";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // txtStatusOfQuote
            // 
            this.txtStatusOfQuote.Location = new System.Drawing.Point(456, 379);
            this.txtStatusOfQuote.Name = "txtStatusOfQuote";
            this.txtStatusOfQuote.Size = new System.Drawing.Size(317, 22);
            this.txtStatusOfQuote.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Status Of Quote :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(582, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 22);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardetailBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.txtID.Location = new System.Drawing.Point(31, 263);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(49, 22);
            this.txtID.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1174, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 96);
            this.button1.TabIndex = 34;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtStatusOfQuote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtTotalQuoteVal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemInQuote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQouteRef);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtSLNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.btnInsertData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quote Status ver 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carModelsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsertData;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSLNo;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtQouteRef;
        private CarModelsDataSet carModelsDataSet;
        private System.Windows.Forms.BindingSource cardetailBindingSource;
        private CarModelsDataSetTableAdapters.car_detailTableAdapter car_detailTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemInQuote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalQuoteVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TextBox txtStatusOfQuote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

