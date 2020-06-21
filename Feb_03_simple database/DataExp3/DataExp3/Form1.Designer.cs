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
            this.btnFirstData = new System.Windows.Forms.Button();
            this.btnLastData = new System.Windows.Forms.Button();
            this.btnPrevData = new System.Windows.Forms.Button();
            this.btnNextData = new System.Windows.Forms.Button();
            this.btnInsertData = new System.Windows.Forms.Button();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFirstData
            // 
            this.btnFirstData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFirstData.Location = new System.Drawing.Point(447, 37);
            this.btnFirstData.Name = "btnFirstData";
            this.btnFirstData.Size = new System.Drawing.Size(120, 34);
            this.btnFirstData.TabIndex = 0;
            this.btnFirstData.Text = "First Data";
            this.btnFirstData.UseVisualStyleBackColor = true;
            this.btnFirstData.Click += new System.EventHandler(this.btnFirstData_Click);
            // 
            // btnLastData
            // 
            this.btnLastData.Location = new System.Drawing.Point(447, 82);
            this.btnLastData.Name = "btnLastData";
            this.btnLastData.Size = new System.Drawing.Size(120, 34);
            this.btnLastData.TabIndex = 1;
            this.btnLastData.Text = "Last Data";
            this.btnLastData.UseVisualStyleBackColor = true;
            this.btnLastData.Click += new System.EventHandler(this.btnLastData_Click);
            // 
            // btnPrevData
            // 
            this.btnPrevData.Location = new System.Drawing.Point(447, 127);
            this.btnPrevData.Name = "btnPrevData";
            this.btnPrevData.Size = new System.Drawing.Size(120, 34);
            this.btnPrevData.TabIndex = 2;
            this.btnPrevData.Text = "Prev Data";
            this.btnPrevData.UseVisualStyleBackColor = true;
            this.btnPrevData.Click += new System.EventHandler(this.btnPrevData_Click);
            // 
            // btnNextData
            // 
            this.btnNextData.Location = new System.Drawing.Point(447, 172);
            this.btnNextData.Name = "btnNextData";
            this.btnNextData.Size = new System.Drawing.Size(120, 34);
            this.btnNextData.TabIndex = 3;
            this.btnNextData.Text = "Next Data";
            this.btnNextData.UseVisualStyleBackColor = true;
            this.btnNextData.Click += new System.EventHandler(this.btnNextData_Click);
            // 
            // btnInsertData
            // 
            this.btnInsertData.Location = new System.Drawing.Point(447, 217);
            this.btnInsertData.Name = "btnInsertData";
            this.btnInsertData.Size = new System.Drawing.Size(120, 34);
            this.btnInsertData.TabIndex = 4;
            this.btnInsertData.Text = "Insert Data";
            this.btnInsertData.UseVisualStyleBackColor = true;
            this.btnInsertData.Click += new System.EventHandler(this.btnInsertData_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(447, 262);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(120, 34);
            this.btnUpdateData.TabIndex = 5;
            this.btnUpdateData.Text = "Update Data";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Location = new System.Drawing.Point(447, 307);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(120, 34);
            this.btnDeleteData.TabIndex = 6;
            this.btnDeleteData.Text = "Delete Data";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registration No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Car Model :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Car make : ";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(179, 37);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(100, 22);
            this.txtRegNo.TabIndex = 10;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(179, 118);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(124, 22);
            this.txtCarModel.TabIndex = 11;
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(179, 198);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(124, 22);
            this.txtCarMake.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 356);
            this.Controls.Add(this.txtCarMake);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.btnInsertData);
            this.Controls.Add(this.btnNextData);
            this.Controls.Add(this.btnPrevData);
            this.Controls.Add(this.btnLastData);
            this.Controls.Add(this.btnFirstData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirstData;
        private System.Windows.Forms.Button btnLastData;
        private System.Windows.Forms.Button btnPrevData;
        private System.Windows.Forms.Button btnNextData;
        private System.Windows.Forms.Button btnInsertData;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarMake;
    }
}

