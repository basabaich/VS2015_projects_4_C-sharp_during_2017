namespace DataHandleInCSharp1
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
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbxAlbum = new System.Windows.Forms.ComboBox();
            this.gridPhotoAlbum = new System.Windows.Forms.DataGridView();
            this.lblAlbum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(603, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 45);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbxAlbum
            // 
            this.cmbxAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxAlbum.FormattingEnabled = true;
            this.cmbxAlbum.Location = new System.Drawing.Point(183, 22);
            this.cmbxAlbum.Name = "cmbxAlbum";
            this.cmbxAlbum.Size = new System.Drawing.Size(287, 24);
            this.cmbxAlbum.TabIndex = 1;
            // 
            // gridPhotoAlbum
            // 
            this.gridPhotoAlbum.AllowUserToOrderColumns = true;
            this.gridPhotoAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPhotoAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPhotoAlbum.Location = new System.Drawing.Point(26, 65);
            this.gridPhotoAlbum.Name = "gridPhotoAlbum";
            this.gridPhotoAlbum.RowTemplate.Height = 24;
            this.gridPhotoAlbum.Size = new System.Drawing.Size(652, 187);
            this.gridPhotoAlbum.TabIndex = 2;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(130, 25);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(47, 17);
            this.lblAlbum.TabIndex = 3;
            this.lblAlbum.Text = "&Album";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 329);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.gridPhotoAlbum);
            this.Controls.Add(this.cmbxAlbum);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAlbumData";
            ((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbxAlbum;
        private System.Windows.Forms.DataGridView gridPhotoAlbum;
        private System.Windows.Forms.Label lblAlbum;
    }
}

