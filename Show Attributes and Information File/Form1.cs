using System.IO;
using System.Windows.Forms;

namespace FileAndDir1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public void GetIn4(string FileName)
        {
            textBox1.Clear();

            textBox1.Text = Path.GetFileName(FileName) + "\r\n";
            textBox1.AppendText("Created: " + File.GetCreationTime(FileName) + "\r\n");
            textBox1.AppendText("Last Modifiers: " + File.GetLastWriteTime(FileName) + "\r\n");
            textBox1.AppendText("Last Accessed: " + File.GetLastAccessTime(FileName) + "\r\n");
        }

        private void tbIn_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Clear();

            if (e.KeyCode == Keys.Enter)
            {

                string FileName = @tbIn.Text;

                if (File.Exists(FileName))
                {
                    GetIn4(FileName);
                    StreamReader stream = new StreamReader(FileName);
                    try
                    {
                        textBox1.AppendText(stream.ReadToEnd());
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        stream.Close();
                    }
                }

                else if (Directory.Exists(FileName))
                {
                    string[] arrDir = Directory.GetFiles(FileName);
                    textBox1.AppendText("Directory contents: " + "\r\n");
                    foreach (var file in arrDir)
                    {
                        textBox1.AppendText(file + "\r\n");
                    }

                }

                else
                    MessageBox.Show(tbIn.Text + " does not exist", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }




}
