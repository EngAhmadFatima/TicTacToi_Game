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
    public partial class Form2 : Form
    {
        bool aginst_computer = true;
       
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.setplayersname(p1.Text, p2.Text);
            if (p1.Text == "" | p2.Text == "")
            {
                MessageBox.Show("Enter Player Name");
            }
            
            if (p1.Text == p2.Text)
            {
                MessageBox.Show("Tow Players Have The Same Name!");
                p1.Focus();
            }
            else
            {
                this.Close();
            }

        }

        private void p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                button1.PerformClick();
        } // حدث ضغط اينتر عندما يكون المؤشر في مربع النص

        private void p1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar.ToString() == "\r")
                p2.Focus();
        } // حدث ضغط اينتر عندما يكون المؤشر في مربع النص

        private void p2_TextChanged(object sender, EventArgs e)
        {
            if(p2.Text.ToUpper() == "Computer")
                aginst_computer = true;
            else
                aginst_computer = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'informationDataSet.playersInfo' table. You can move, or remove it, as needed.
            this.playersInfoTableAdapter.Fill(this.informationDataSet.playersInfo);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                p2.Text = "Computer";
                panel1.Enabled = false;
                p1.Focus();
                p2.ReadOnly = true;
            }
            else
            {
                p2.Text = "";
                p2.ReadOnly = false;
            }
               
        }

        private void ex2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                p2.Text = "";
                panel1.Enabled = true;
                p1.Focus();
                p2.ReadOnly = false;
            }
             
        }

        private void p1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //p1.Text = (string)listBox1.SelectedValue;
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //p2.Text = (string)listBox2.SelectedValue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog(this);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            p1.Text = (string)comboBox1.SelectedValue;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            p2.Text = (string)comboBox2.SelectedValue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
