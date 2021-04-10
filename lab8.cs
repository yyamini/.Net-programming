using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void emp_jBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emp_jBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.emp_j' table. You can move, or remove it, as needed.
            this.emp_jTableAdapter.Fill(this.masterDataSet.emp_j);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
