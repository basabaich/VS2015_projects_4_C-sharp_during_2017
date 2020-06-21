namespace SimplData
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label eidLabel;
            System.Windows.Forms.Label genderLabel;
            this.empDataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.empDataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataDataSet = new SimplData.EmpDataDataSet();
            this.empDataTableAdapter = new SimplData.EmpDataDataSetTableAdapters.EmpDataTableAdapter();
            this.tableAdapterManager = new SimplData.EmpDataDataSetTableAdapters.TableAdapterManager();
            this.empDataDataSet2 = new SimplData.EmpDataDataSet2();
            this.empDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empDataTableAdapter1 = new SimplData.EmpDataDataSet2TableAdapters.EmpDataTableAdapter();
            this.tableAdapterManager1 = new SimplData.EmpDataDataSet2TableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.eidListBox = new System.Windows.Forms.ListBox();
            this.genderCheckBox = new System.Windows.Forms.CheckBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            eidLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingNavigator)).BeginInit();
            this.empDataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // empDataBindingNavigator
            // 
            this.empDataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empDataBindingNavigator.BindingSource = this.empDataBindingSource;
            this.empDataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empDataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empDataBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.empDataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.empDataBindingNavigatorSaveItem});
            this.empDataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empDataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empDataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empDataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empDataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empDataBindingNavigator.Name = "empDataBindingNavigator";
            this.empDataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empDataBindingNavigator.Size = new System.Drawing.Size(730, 27);
            this.empDataBindingNavigator.TabIndex = 0;
            this.empDataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // empDataBindingNavigatorSaveItem
            // 
            this.empDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empDataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empDataBindingNavigatorSaveItem.Image")));
            this.empDataBindingNavigatorSaveItem.Name = "empDataBindingNavigatorSaveItem";
            this.empDataBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.empDataBindingNavigatorSaveItem.Text = "Save Data";
            this.empDataBindingNavigatorSaveItem.Click += new System.EventHandler(this.empDataBindingNavigatorSaveItem_Click_1);
            // 
            // empDataBindingSource
            // 
            this.empDataBindingSource.DataMember = "EmpData";
            this.empDataBindingSource.DataSource = this.empDataDataSet;
            // 
            // empDataDataSet
            // 
            this.empDataDataSet.DataSetName = "EmpDataDataSet";
            this.empDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empDataTableAdapter
            // 
            this.empDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpDataTableAdapter = this.empDataTableAdapter;
            this.tableAdapterManager.UpdateOrder = SimplData.EmpDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empDataDataSet2
            // 
            this.empDataDataSet2.DataSetName = "EmpDataDataSet2";
            this.empDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empDataBindingSource1
            // 
            this.empDataBindingSource1.DataMember = "EmpData";
            this.empDataBindingSource1.DataSource = this.empDataDataSet2;
            // 
            // empDataTableAdapter1
            // 
            this.empDataTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EmpDataTableAdapter = this.empDataTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = SimplData.EmpDataDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(150, 63);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDataBindingSource1, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(216, 60);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(120, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(150, 88);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameListBox
            // 
            this.nameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empDataBindingSource1, "Name", true));
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 16;
            this.nameListBox.Location = new System.Drawing.Point(216, 88);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(120, 84);
            this.nameListBox.TabIndex = 4;
            // 
            // eidLabel
            // 
            eidLabel.AutoSize = true;
            eidLabel.Location = new System.Drawing.Point(150, 190);
            eidLabel.Name = "eidLabel";
            eidLabel.Size = new System.Drawing.Size(32, 17);
            eidLabel.TabIndex = 5;
            eidLabel.Text = "Eid:";
            // 
            // eidListBox
            // 
            this.eidListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empDataBindingSource1, "Eid", true));
            this.eidListBox.FormattingEnabled = true;
            this.eidListBox.ItemHeight = 16;
            this.eidListBox.Location = new System.Drawing.Point(216, 190);
            this.eidListBox.Name = "eidListBox";
            this.eidListBox.Size = new System.Drawing.Size(120, 84);
            this.eidListBox.TabIndex = 6;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(150, 297);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 17);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender:";
            // 
            // genderCheckBox
            // 
            this.genderCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.empDataBindingSource1, "Gender", true));
            this.genderCheckBox.Location = new System.Drawing.Point(216, 292);
            this.genderCheckBox.Name = "genderCheckBox";
            this.genderCheckBox.Size = new System.Drawing.Size(120, 24);
            this.genderCheckBox.TabIndex = 8;
            this.genderCheckBox.Text = "checkBox1";
            this.genderCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 410);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(eidLabel);
            this.Controls.Add(this.eidListBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderCheckBox);
            this.Controls.Add(this.empDataBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingNavigator)).EndInit();
            this.empDataBindingNavigator.ResumeLayout(false);
            this.empDataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmpDataDataSet empDataDataSet;
        private EmpDataDataSetTableAdapters.EmpDataTableAdapter empDataTableAdapter;
        private EmpDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource empDataBindingSource;
        private System.Windows.Forms.BindingNavigator empDataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton empDataBindingNavigatorSaveItem;
        private EmpDataDataSet2 empDataDataSet2;
        private System.Windows.Forms.BindingSource empDataBindingSource1;
        private EmpDataDataSet2TableAdapters.EmpDataTableAdapter empDataTableAdapter1;
        private EmpDataDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.ListBox eidListBox;
        private System.Windows.Forms.CheckBox genderCheckBox;
    }
}

