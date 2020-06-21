namespace FormClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.textLength = new System.Windows.Forms.TextBox();
            this.textBreadth = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Breadth :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result :";
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(180, 150);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(122, 29);
            this.btnVolume.TabIndex = 3;
            this.btnVolume.Text = "Volume";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(308, 150);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(122, 29);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(180, 25);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(250, 22);
            this.textLength.TabIndex = 5;
            // 
            // textBreadth
            // 
            this.textBreadth.Location = new System.Drawing.Point(180, 60);
            this.textBreadth.Name = "textBreadth";
            this.textBreadth.Size = new System.Drawing.Size(250, 22);
            this.textBreadth.TabIndex = 6;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(180, 207);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(250, 22);
            this.textResult.TabIndex = 7;
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(180, 101);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(250, 22);
            this.textHeight.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Height :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 253);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textBreadth);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.TextBox textBreadth;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Label label4;
    }
}

