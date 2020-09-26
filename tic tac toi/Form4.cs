using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tic_tac_toi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void historyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.informationDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'informationDataSet.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.informationDataSet.history);

        }
    }
}
