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
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        static string player1, player2;

        string PlayerName;
        int LoosingCount;
        int WinningCount;
        int TieCount;
        DateTime PlayingDate;
        int TourCount;


        public Form1()
        {
            InitializeComponent();
        }
        public static void setplayersname(string n1, string n2)
        {
            player1 = n1;
            player2 = n2;
        } //تابع ادخال أسماء اللاعبين
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برمجة الطالب أحمد فاطمة (Ahmad_43273)", "Tic Tac Toe About");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // خيار الخروج
        private void butten_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn) {
                label1.ForeColor = Color.Black;
                label3.ForeColor = Color.Red;
                b.Text = "X"; b.BackColor = Color.Ivory; }
            else {
                label1.ForeColor = Color.Red;
                label3.ForeColor = Color.Black;
                b.Text = "O"; b.BackColor = Color.Pink; }


            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkforwinner();


            if ((!turn) && (label3.Text == "Computer"))
            {
                computer_make_move();
            }


        } // أزرار اللعب
        private void checkforwinner()
        {
            bool there_is_a_winner = false;

            // فحص الأسطر
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

             // فحص الأعمدة
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

             // فحص الأقطار
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;




            if (there_is_a_winner)
            {
                //disableButtens();


                string winner = "";

                if (turn)
                {
                    winner = player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();

                    label1.ForeColor = Color.Black;
                    label3.ForeColor = Color.Red;
                    label2.ForeColor = Color.Black;
                    x_loos_count.Text = (Int32.Parse(x_loos_count.Text) + 1).ToString();
                    tour_count.Text = (Int32.Parse(tour_count.Text) + 1).ToString();

                 

                }
                else
                {
                    winner = player1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();

                    label1.ForeColor = Color.Red;
                    label3.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    o_loos_count.Text = (Int32.Parse(o_loos_count.Text) + 1).ToString();
                    tour_count.Text = (Int32.Parse(tour_count.Text) + 1).ToString();


                }

                

                foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Visible = false;
                    }
                    catch { }
                }
                lbmsg.Text = winner + "Wins!!";
                pncont.Visible = true;

               
            }


            else
            {

                if (turn_count == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    label1.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label2.ForeColor = Color.Red;
                    foreach (Control c in Controls)
                    {
                        try
                        {
                            Button b = (Button)c;
                            b.Visible = false;
                        }
                        catch { }
                    }
                    lbmsg.Text = "        تعادل";
                    pncont.Visible = true;


                    turn = true;

                }
            }

        } // تابع البحث عن الرابح
        private void disableButtens()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        } // 
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            label1.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.BackColor = Color.LightCyan;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }

        } // خيار لعبة جديدة
        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.ForeColor = Color.Red;
                    b.Text = "X";
                }

                else
                {
                    b.ForeColor = Color.Red;
                    b.Text = "O";
                }
            }

        } // حدث ضغط زر اللعب
        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        } // حدث ترك زر اللعب
        private void resetCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        } // خيار تصفير العداد
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'informationDataSet.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.informationDataSet.history);
            Form2 f2 = new Form2();
            f2.ShowDialog();
           
            label1.Text = player1;
            label3.Text = player2;
            linkLabel1.Links.Add(0, 0, "https://www.facebook.com/ahmadfatemh");

            
        } // تحميل الفورم الأول
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void computer_make_move()
        {
            //priority 1:  get tick tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            Button move = null;

            //look for tic tac toe opportunities
            move = look_for_win_or_block("O"); //look for win
            if (move == null)
            {
                move = look_for_win_or_block("X"); //look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end if
                }//end if
            }//end if

            move.PerformClick();
        }
        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }
        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }
        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void A1_MouseCaptureChanged(object sender, EventArgs e)
        {
        }
        private void btply_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------
            turn = true;
            turn_count = 0;

            label1.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            foreach (Control c in Controls)
            {
                try
                {
                    pncont.Visible = false;
                    Button b = (Button)c;
                    b.Visible = true;
                    b.BackColor = Color.LightCyan;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
             //-----------------------------------------------------
        }
        private void btend_Click(object sender, EventArgs e)
        {


                PlayerName = player1;
                LoosingCount = Int32.Parse(x_loos_count.Text);
                WinningCount = Int32.Parse(x_win_count.Text);
                TieCount = Int32.Parse(draw_count.Text);
                PlayingDate = dateTimePicker1.Value;
                TourCount = Int32.Parse(tour_count.Text);
                historyTableAdapter adapter1 = new historyTableAdapter();
                adapter1.Insert(PlayerName, LoosingCount, WinningCount, TieCount, TourCount, PlayingDate);
                adapter1.Dispose();
                this.Update();


                PlayerName = player2;
                LoosingCount = Int32.Parse(o_loos_count.Text);
                WinningCount = Int32.Parse(o_win_count.Text);
                TieCount = Int32.Parse(draw_count.Text);
                PlayingDate = dateTimePicker1.Value;
                TourCount = Int32.Parse(tour_count.Text);
                historyTableAdapter adapter2 = new historyTableAdapter();
                adapter2.Insert(PlayerName, LoosingCount, WinningCount, TieCount, TourCount, PlayingDate);
                adapter2.Dispose();
                this.Update();
            


            Application.Exit();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void lbmsg_Click(object sender, EventArgs e)
        {

        }

        private void pncont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void playingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void playingHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog(this);
        }



    }
}

