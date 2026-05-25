namespace Học_ListView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rBNữ = new System.Windows.Forms.RadioButton();
            this.Lv1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.SmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.LargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.cbChangeView = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Education Level:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sex:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 22);
            this.textBox2.TabIndex = 2;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(158, 103);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 20);
            this.rbNam.TabIndex = 3;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Male";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // rBNữ
            // 
            this.rBNữ.AutoSize = true;
            this.rBNữ.Location = new System.Drawing.Point(222, 103);
            this.rBNữ.Name = "rBNữ";
            this.rBNữ.Size = new System.Drawing.Size(74, 20);
            this.rBNữ.TabIndex = 4;
            this.rBNữ.TabStop = true;
            this.rBNữ.Text = "Female";
            this.rBNữ.UseVisualStyleBackColor = true;
            this.rBNữ.CheckedChanged += new System.EventHandler(this.rBNữ_CheckedChanged);
            // 
            // Lv1
            // 
            this.Lv1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Lv1.HideSelection = false;
            this.Lv1.Location = new System.Drawing.Point(46, 142);
            this.Lv1.Name = "Lv1";
            this.Lv1.Size = new System.Drawing.Size(410, 299);
            this.Lv1.TabIndex = 7;
            this.Lv1.UseCompatibleStateImageBehavior = false;
            this.Lv1.View = System.Windows.Forms.View.Details;
            this.Lv1.SelectedIndexChanged += new System.EventHandler(this.Lv1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(366, 67);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Delete";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // SmallIcon
            // 
            this.SmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallIcon.ImageStream")));
            this.SmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallIcon.Images.SetKeyName(0, "woman.png");
            this.SmallIcon.Images.SetKeyName(1, "man.png");
            // 
            // LargeIcon
            // 
            this.LargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeIcon.ImageStream")));
            this.LargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.LargeIcon.Images.SetKeyName(0, "woman.png");
            this.LargeIcon.Images.SetKeyName(1, "man.png");
            // 
            // cbChangeView
            // 
            this.cbChangeView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangeView.FormattingEnabled = true;
            this.cbChangeView.IntegralHeight = false;
            this.cbChangeView.Location = new System.Drawing.Point(308, 102);
            this.cbChangeView.Name = "cbChangeView";
            this.cbChangeView.Size = new System.Drawing.Size(148, 24);
            this.cbChangeView.TabIndex = 8;
            this.cbChangeView.SelectedIndexChanged += new System.EventHandler(this.cbChangeView_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.cbChangeView);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lv1);
            this.Controls.Add(this.rBNữ);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phuclatui";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rBNữ;
        private System.Windows.Forms.ListView Lv1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.ImageList SmallIcon;
        private System.Windows.Forms.ImageList LargeIcon;
        private System.Windows.Forms.ComboBox cbChangeView;
    }
}

