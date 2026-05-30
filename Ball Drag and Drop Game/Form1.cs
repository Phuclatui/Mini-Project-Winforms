using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Event
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        Point followMouse;

        Point startGame;

        int speed;


        public Form1()
        {
            InitializeComponent();
            form1 = this;

            Image imageBall = Image.FromFile("ball.ico");
            pictureBox1.Image = imageBall;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            startGame = pictureBox1.Location;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            followMouse = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - followMouse.X;
                int dy = e.Y - followMouse.Y;

                pictureBox1.Left += dx;
                pictureBox1.Top += dy;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += speed;


            if (panel1.Bounds.Contains(pictureBox1.Bounds))
            {

                timer1.Stop();
                MessageBox.Show("Congragulation", "Finish");
                NewGame();
            }

            if (pictureBox1.Top >= form1.ClientSize.Height)
            {
                timer1.Stop();
                MessageBox.Show("Lose");
                NewGame();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Exit", "Confirmed", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Exit", "Confirmed", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void NewGame()
        {
            pictureBox1.Location = startGame;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            speed = 10;
        }

    }
}
