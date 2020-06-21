using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimplData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDataDataSet2.EmpData' table. You can move, or remove it, as needed.
            this.empDataTableAdapter1.Fill(this.empDataDataSet2.EmpData);
            // TODO: This line of code loads data into the 'empDataDataSet.EmpData' table. You can move, or remove it, as needed.
            this.empDataTableAdapter.Fill(this.empDataDataSet.EmpData);
            // TODO: This line of code loads data into the 'empDataDataSet.EmpData' table. You can move, or remove it, as needed.
            this.empDataTableAdapter.Fill(this.empDataDataSet.EmpData);

        }

        private void empDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empDataDataSet);

        }

        private void empDataBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.empDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empDataDataSet);

        }
    }
}
