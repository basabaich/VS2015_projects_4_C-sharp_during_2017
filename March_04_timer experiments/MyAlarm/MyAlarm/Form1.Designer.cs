namespace MyAlarm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtBoxDispT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartAlarm = new System.Windows.Forms.Button();
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.numHr = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numSec = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetAlrm = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtB2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtBoxDispT
            // 
            this.txtBoxDispT.BackColor = System.Drawing.Color.Red;
            this.txtBoxDispT.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDispT.ForeColor = System.Drawing.Color.Yellow;
            this.txtBoxDispT.Location = new System.Drawing.Point(196, 44);
            this.txtBoxDispT.Name = "txtBoxDispT";
            this.txtBoxDispT.Size = new System.Drawing.Size(183, 47);
            this.txtBoxDispT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Now : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set Time : ";
            // 
            // btnStartAlarm
            // 
            this.btnStartAlarm.Location = new System.Drawing.Point(74, 115);
            this.btnStartAlarm.Name = "btnStartAlarm";
            this.btnStartAlarm.Size = new System.Drawing.Size(134, 27);
            this.btnStartAlarm.TabIndex = 3;
            this.btnStartAlarm.Text = "Start Alarm";
            this.btnStartAlarm.UseVisualStyleBackColor = true;
            this.btnStartAlarm.Click += new System.EventHandler(this.btnStartAlarm_Click);
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.Location = new System.Drawing.Point(245, 115);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(134, 27);
            this.btnStopAlarm.TabIndex = 4;
            this.btnStopAlarm.Text = "Stop Alarm";
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            // 
            // numHr
            // 
            this.numHr.Location = new System.Drawing.Point(121, 29);
            this.numHr.Name = "numHr";
            this.numHr.Size = new System.Drawing.Size(63, 22);
            this.numHr.TabIndex = 5;
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(214, 29);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(63, 22);
            this.numMin.TabIndex = 6;
            // 
            // numSec
            // 
            this.numSec.Location = new System.Drawing.Point(317, 30);
            this.numSec.Name = "numSec";
            this.numSec.Size = new System.Drawing.Size(63, 22);
            this.numSec.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetAlrm);
            this.groupBox1.Controls.Add(this.numSec);
            this.groupBox1.Controls.Add(this.numMin);
            this.groupBox1.Controls.Add(this.numHr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting :";
            // 
            // btnSetAlrm
            // 
            this.btnSetAlrm.Location = new System.Drawing.Point(165, 72);
            this.btnSetAlrm.Name = "btnSetAlrm";
            this.btnSetAlrm.Size = new System.Drawing.Size(125, 27);
            this.btnSetAlrm.TabIndex = 8;
            this.btnSetAlrm.Text = "Set Alarm";
            this.btnSetAlrm.UseVisualStyleBackColor = true;
            this.btnSetAlrm.Click += new System.EventHandler(this.btnSetAlrm_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(473, 269);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(99, 50);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit ";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "beep sound";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(420, 35);
            this.txtB2.Multiline = true;
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(151, 131);
            this.txtB2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 331);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStopAlarm);
            this.Controls.Add(this.btnStartAlarm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDispT);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtBoxDispT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartAlarm;
        private System.Windows.Forms.Button btnStopAlarm;
        private System.Windows.Forms.NumericUpDown numHr;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numSec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnSetAlrm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtB2;
    }
}

