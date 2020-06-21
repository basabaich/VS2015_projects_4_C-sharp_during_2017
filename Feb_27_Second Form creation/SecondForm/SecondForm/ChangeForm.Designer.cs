namespace SecondForm
{
    partial class ChangeForm
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
            this.btnNewForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewForm
            // 
            this.btnNewForm.Location = new System.Drawing.Point(100, 84);
            this.btnNewForm.Name = "btnNewForm";
            this.btnNewForm.Size = new System.Drawing.Size(248, 62);
            this.btnNewForm.TabIndex = 0;
            this.btnNewForm.Text = "Open a new form !!";
            this.btnNewForm.UseVisualStyleBackColor = true;
            this.btnNewForm.Click += new System.EventHandler(this.btnNewForm_Click);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 242);
            this.Controls.Add(this.btnNewForm);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm ver 1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewForm;
    }
}

