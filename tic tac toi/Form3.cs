using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tic_tac_toi.InformationDataSetTableAdapters;

namespace tic_tac_toi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'informationDataSet.playersInfo' table. You can move, or remove it, as needed.
            this.playersInfoTableAdapter.Fill(this.informationDataSet.playersInfo);
            // TODO: This line of code loads data into the 'informationDataSet.playersInfo' table. You can move, or remove it, as needed.
            //this.playersInfoTableAdapter.Fill(this.informationDataSet.playersInfo);
            string PlayerName = textBox1.Text;
            string FirstName = textBox2.Text;
            string LastName = textBox3.Text;
            string Mobile = textBox4.Text;
            DateTime BrithDate = dateTimePicker1.Value;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string PlayerName = textBox1.Text;
            string FirstName = textBox2.Text;
            string LastName = textBox3.Text;
            string Mobile = textBox4.Text;
            DateTime BrithDate = dateTimePicker1.Value;
            playersInfoTableAdapter plta = new playersInfoTableAdapter();
            plta.Insert(PlayerName, FirstName, LastName, Mobile, BrithDate);
            plta.Dispose();
            this.Update();
            this.Close();
            //Form2 f2 = new Form2();
            //f2.Refresh();
            //f2.Update();
            
            
        }
    }
}
