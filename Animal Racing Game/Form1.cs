using System;
using System.Drawing;

using System.Windows.Forms;

namespace KTTTC4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtScore_Click(object sender, System.EventArgs e)
        {

        }

        private void rBdog_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void fileNew_Click(object sender, System.EventArgs e)
        {
            Timer.Enabled = false;
            lbRank.Visible = false;

            timeDog = 0.00;
            timeTurtle = 0.00;
            timeRabbit = 0.00;

            label3.Text = "0.00";
            label4.Text = "0.00";
            label5.Text = "0.00";



            PbMoveDog.Dock = DockStyle.None;
            PbMoveDog.Location = new Point(0, 0);

            pBMoveRabbit.Dock = DockStyle.None;
            pBMoveRabbit.Location = new Point(0, 0);

            pBMoveTurtle.Dock = DockStyle.None;
            pBMoveTurtle.Location = new Point(0, 0);
        }

        private void fileRun_Click(object sender, System.EventArgs e)
        {
            Timer.Enabled = true;
            Timer.Start();

        }

        private void PbMoveDog_Click(object sender, System.EventArgs e)
        {

        }

        double timeDog = 0.00;
        double timeTurtle = 0.00;
        double timeRabbit = 0.00;
        private void Timer_Tick(object sender, System.EventArgs e)
        {
            int x = ExtentionProgram.RandomSpeed();
            int y = ExtentionProgram.RandomSpeed();
            int z = ExtentionProgram.RandomSpeed();

            int x1 = ExtentionProgram.RandomSpeedBuffandNeft();
            int y1 = ExtentionProgram.RandomSpeedBuffandNeft();
            int z1 = ExtentionProgram.RandomSpeedBuffandNeft();


            if (PbMoveDog.Right >= panel1.Right)
                PbMoveDog.Left += 0;
            else
                PbMoveDog.Left += x + x1;

            if (pBMoveRabbit.Right >= panel1.Right)
                pBMoveRabbit.Left += 0;
            else
                pBMoveRabbit.Left += z + z1;

            if (pBMoveTurtle.Right >= panel1.Right)
                pBMoveTurtle.Left += 0;
            else
                pBMoveTurtle.Left += y + y1;

            TimeRun();

            if (PbMoveDog.Right >= panel1.Right && pBMoveRabbit.Right >= panel1.Right && pBMoveTurtle.Right >= panel1.Right)
            {
                Timer.Stop();
                finish();
            }


        }


        private void TimeRun()
        {


            if (PbMoveDog.Right >= panel1.Right)
                label3.Text = (timeDog / (double)1000).ToString("0.00");
            else
            {
                timeDog += Timer.Interval;
                label3.Text = (timeDog / (double)1000).ToString("0.00");
            }


            if (pBMoveRabbit.Right >= panel1.Right)
                label4.Text = (timeRabbit / (double)1000).ToString("0.00");
            else
            {
                timeRabbit += Timer.Interval;
                label4.Text = (timeRabbit / (double)1000).ToString("0.00");
            }

            if (pBMoveTurtle.Right >= panel1.Right)
                label5.Text = (timeTurtle / (double)1000).ToString("0.00");
            else
            {
                timeTurtle += Timer.Interval;
                label5.Text = (timeTurtle / (double)1000).ToString("0.00");
            }
        }


        private void finish()
        {
            lbRank.Visible = true;
            double rank1 = timeDog;
            double rank2 = timeRabbit;
            double rank3 = timeTurtle;


            if (rank1 == rank2 && rank2 == rank3)
            {
                lbRank.Text = "RACER 1, RACER 2, RACER 3 WIN !!!";
                if (rBdog.Checked || rBRabbit.Checked || rBTurtle.Checked)
                {
                    AddScore();
                }
                else
                    MinusScore();

            }

            else if (rank1 == rank2 && rank2 > rank3)
            {
                lbRank.Text = "RACER 3 WIN!!!";
                if (rBTurtle.Checked)
                {
                    AddScore();
                }
                else
                    MinusScore();
            }


            else if (rank2 == rank3 && rank3 > rank1)
            {
                lbRank.Text = "RACER 1 WIN!!!";
                if (rBdog.Checked)
                {
                    AddScore();
                }
                else
                    MinusScore();
            }


            else if (rank1 == rank3 && rank3 > rank2)
            {
                lbRank.Text = "RACER 2 WIN!!!";
                if (rBRabbit.Checked)
                {
                    AddScore();
                }
                else
                    MinusScore();
            }

            //


            else if (rank1 == rank2 && rank2 < rank3)
            {
                lbRank.Text = "RACER 1, RACER 2 WIN!!!";
                if (rBRabbit.Checked || rBdog.Checked)
                {
                    AddScore();
                }
                else
                    MinusScore();
            }

            else if (rank2 == rank3 && rank3 < rank1)
            {
                lbRank.Text = "RACER 2, RACER 3 WIN!!!";
                if (rBRabbit.Checked || rBTurtle.Checked)
                {
                    AddScore();
                }
                else
                    MinusScore();
            }


            else if (rank1 == rank3 && rank3 < rank2)
            {
                lbRank.Text = "RACER 1, RACER 3 WIN!!!";
                if (rBTurtle.Checked || rBdog.Checked)
                {
                    AddScore();
                }
                else
                    MinusScore();
            }

            else
            {
                if (rank1 > rank2 && rank2 > rank3)
                {
                    lbRank.Text = "RACER 3 WIN!!!";
                    if (rBTurtle.Checked)
                    {
                        AddScore();
                    }
                    else
                        MinusScore();
                }
                else if (rank1 > rank3 && rank3 > rank2)
                {
                    lbRank.Text = "RACER 2 WIN!!!";
                    if (rBRabbit.Checked)
                    {
                        AddScore();
                    }
                    else
                        MinusScore();
                }
                else if (rank2 > rank1 && rank1 > rank3)
                {
                    lbRank.Text = "RACER 3 WIN!!!";
                    if (rBTurtle.Checked)
                    {
                        AddScore();
                    }
                    else
                        MinusScore();
                }
                else if (rank2 > rank3 && rank3 > rank1)
                {
                    lbRank.Text = "RACER 1 WIN!!!";
                    if (rBdog.Checked)
                    {
                        AddScore();
                    }
                    else
                        MinusScore();
                }

                else if (rank3 > rank2 && rank2 > rank1)
                {
                    lbRank.Text = "RACER 1 WIN!!!";
                    if (rBdog.Checked)
                    {
                        AddScore();
                    }
                    else
                        MinusScore();
                }

                else if (rank3 > rank1 && rank1 > rank2)
                {
                    lbRank.Text = "RACER 2 WIN!!!";
                    if (rBRabbit.Checked)
                    {
                        AddScore();
                    }
                    else
                        MinusScore();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbRank.Visible = false;
        }

        private void AddScore()
        {
            int score = int.Parse(txtScore.Text);
            score += 100;

            txtScore.Text = score.ToString();
        }

        private void MinusScore()
        {
            int score = int.Parse(txtScore.Text);

            score -= 100;
            txtScore.Text = score.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Kết thúc chương trình ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

public static class ExtentionProgram
{
    static Random random = new Random();

    public static int RandomSpeed()
    {
        return random.Next(5, 7);
    }

    public static int RandomSpeedBuffandNeft()
    {
        return random.Next(-2, 5);
    }

}


