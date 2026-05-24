using System;
using System.Windows.Forms;

namespace Học_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //load column ListView
            Lv1.Columns.Add("Full name", 100, HorizontalAlignment.Right);
            Lv1.Columns.Add("Education Level", 100, HorizontalAlignment.Center);
            Lv1.Columns.Add("Registration Date ", 100, HorizontalAlignment.Center);

            //setup properties for listview
            cbChangeView.DropDownStyle = ComboBoxStyle.DropDown;
            Lv1.SmallImageList = SmallIcon;
            Lv1.LargeImageList = LargeIcon;


            cbChangeView.MaxDropDownItems = 5;

            cbChangeView.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbChangeView.AutoCompleteMode = AutoCompleteMode.Suggest;

            //load Item for ComboBox
            cbChangeView.Items.Add("Detail");
            cbChangeView.Items.Add("LargeIcon");
            cbChangeView.Items.Add("SmallIcon");
            cbChangeView.Items.Add("List");
            cbChangeView.Items.Add("Title");

        }

        private void Lv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                ListViewItem item1 = new ListViewItem(textBox1.Text);
                item1.SubItems.Add(textBox2.Text);
                item1.SubItems.Add(DateTime.Now.ToShortDateString().ToString());

                Lv1.Items.Add(item1);

                if (rbNam.Checked || rBNữ.Checked)
                {
                    if (rbNam.Checked)
                    {
                        item1.ImageIndex = 1;
                    }

                    if (rBNữ.Checked)
                    {
                        item1.ImageIndex = 0;
                    }
                }
            }


        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Lv1.SelectedItems)
            {
                Lv1.Items.Remove(item);
            }
        }

        private void btChangeView_Click(object sender, EventArgs e)
        {

        }

        private void cbChangeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChangeView.SelectedItem != null)
            {
                if (cbChangeView.SelectedItem.ToString() == "Detail")
                {
                    Lv1.View = View.Details;
                }

                if (cbChangeView.SelectedItem.ToString() == "LargeIcon")
                {
                    Lv1.View = View.LargeIcon;
                }

                if (cbChangeView.SelectedItem.ToString() == "SmallIcon")
                {
                    Lv1.View = View.SmallIcon;
                }

                if (cbChangeView.SelectedItem.ToString() == "List")
                {
                    Lv1.View = View.List;
                }

                if (cbChangeView.SelectedItem.ToString() == "Title")
                {
                    Lv1.View = View.Tile;
                }
            }

        }

        private void rBNữ_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
