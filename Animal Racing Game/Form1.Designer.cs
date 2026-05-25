namespace KTTTC4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MSFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileRun = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBRabbit = new System.Windows.Forms.RadioButton();
            this.rBTurtle = new System.Windows.Forms.RadioButton();
            this.rBdog = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pBRabbit = new System.Windows.Forms.PictureBox();
            this.pBTurtle = new System.Windows.Forms.PictureBox();
            this.pBDog = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PbMoveDog = new System.Windows.Forms.PictureBox();
            this.pBMoveTurtle = new System.Windows.Forms.PictureBox();
            this.pBMoveRabbit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lbRank = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBRabbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTurtle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMoveDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMoveTurtle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMoveRabbit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSFile});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MSFile
            // 
            this.MSFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNew,
            this.fileRun,
            this.fileExit});
            this.MSFile.Name = "MSFile";
            this.MSFile.Size = new System.Drawing.Size(46, 24);
            this.MSFile.Text = "File";
            // 
            // fileNew
            // 
            this.fileNew.Name = "fileNew";
            this.fileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileNew.Size = new System.Drawing.Size(224, 26);
            this.fileNew.Text = "New";
            this.fileNew.Click += new System.EventHandler(this.fileNew_Click);
            // 
            // fileRun
            // 
            this.fileRun.Name = "fileRun";
            this.fileRun.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.fileRun.Size = new System.Drawing.Size(224, 26);
            this.fileRun.Text = "Run";
            this.fileRun.Click += new System.EventHandler(this.fileRun_Click);
            // 
            // fileExit
            // 
            this.fileExit.Name = "fileExit";
            this.fileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.fileExit.Size = new System.Drawing.Size(224, 26);
            this.fileExit.Text = "Exit";
            this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "ANIMAL RACE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rBRabbit);
            this.groupBox1.Controls.Add(this.rBTurtle);
            this.groupBox1.Controls.Add(this.rBdog);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pBRabbit);
            this.groupBox1.Controls.Add(this.pBTurtle);
            this.groupBox1.Controls.Add(this.pBDog);
            this.groupBox1.Location = new System.Drawing.Point(175, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time(Second)";
            // 
            // rBRabbit
            // 
            this.rBRabbit.AutoSize = true;
            this.rBRabbit.Location = new System.Drawing.Point(226, 114);
            this.rBRabbit.Name = "rBRabbit";
            this.rBRabbit.Size = new System.Drawing.Size(75, 20);
            this.rBRabbit.TabIndex = 11;
            this.rBRabbit.TabStop = true;
            this.rBRabbit.Text = "Racer 2";
            this.rBRabbit.UseVisualStyleBackColor = true;
            // 
            // rBTurtle
            // 
            this.rBTurtle.AutoSize = true;
            this.rBTurtle.Location = new System.Drawing.Point(376, 112);
            this.rBTurtle.Name = "rBTurtle";
            this.rBTurtle.Size = new System.Drawing.Size(75, 20);
            this.rBTurtle.TabIndex = 10;
            this.rBTurtle.TabStop = true;
            this.rBTurtle.Text = "Racer 3";
            this.rBTurtle.UseVisualStyleBackColor = true;
            // 
            // rBdog
            // 
            this.rBdog.AutoSize = true;
            this.rBdog.Location = new System.Drawing.Point(81, 112);
            this.rBdog.Name = "rBdog";
            this.rBdog.Size = new System.Drawing.Size(75, 20);
            this.rBdog.TabIndex = 9;
            this.rBdog.TabStop = true;
            this.rBdog.Text = "Racer 1";
            this.rBdog.UseVisualStyleBackColor = true;
            this.rBdog.CheckedChanged += new System.EventHandler(this.rBdog_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "lbTurtle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "lbTrabbit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "lbTDog";
            // 
            // pBRabbit
            // 
            this.pBRabbit.BackgroundImage = global::KTTTC4.Properties.Resources.how_to_draw_a_rabbit_featured_image_1200;
            this.pBRabbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBRabbit.Location = new System.Drawing.Point(209, 33);
            this.pBRabbit.Name = "pBRabbit";
            this.pBRabbit.Size = new System.Drawing.Size(114, 59);
            this.pBRabbit.TabIndex = 5;
            this.pBRabbit.TabStop = false;
            // 
            // pBTurtle
            // 
            this.pBTurtle.BackgroundImage = global::KTTTC4.Properties.Resources.depositphotos_36544771_stock_illustration_cute_turtle_cartoon__1_;
            this.pBTurtle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBTurtle.Location = new System.Drawing.Point(354, 34);
            this.pBTurtle.Name = "pBTurtle";
            this.pBTurtle.Size = new System.Drawing.Size(114, 59);
            this.pBTurtle.TabIndex = 4;
            this.pBTurtle.TabStop = false;
            // 
            // pBDog
            // 
            this.pBDog.BackgroundImage = global::KTTTC4.Properties.Resources.how_to_draw_a_running_dog_featured_image_1200;
            this.pBDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBDog.Location = new System.Drawing.Point(70, 34);
            this.pBDog.Name = "pBDog";
            this.pBDog.Size = new System.Drawing.Size(114, 59);
            this.pBDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDog.TabIndex = 3;
            this.pBDog.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score";
            // 
            // txtScore
            // 
            this.txtScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScore.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtScore.Location = new System.Drawing.Point(707, 137);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(69, 57);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "1000";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtScore.Click += new System.EventHandler(this.txtScore_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PbMoveDog
            // 
            this.PbMoveDog.BackgroundImage = global::KTTTC4.Properties.Resources.how_to_draw_a_running_dog_featured_image_1200;
            this.PbMoveDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbMoveDog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbMoveDog.Dock = System.Windows.Forms.DockStyle.Left;
            this.PbMoveDog.Location = new System.Drawing.Point(0, 0);
            this.PbMoveDog.Name = "PbMoveDog";
            this.PbMoveDog.Size = new System.Drawing.Size(114, 78);
            this.PbMoveDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMoveDog.TabIndex = 12;
            this.PbMoveDog.TabStop = false;
            this.PbMoveDog.Click += new System.EventHandler(this.PbMoveDog_Click);
            // 
            // pBMoveTurtle
            // 
            this.pBMoveTurtle.BackgroundImage = global::KTTTC4.Properties.Resources.depositphotos_36544771_stock_illustration_cute_turtle_cartoon__1_;
            this.pBMoveTurtle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBMoveTurtle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBMoveTurtle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBMoveTurtle.Location = new System.Drawing.Point(0, 0);
            this.pBMoveTurtle.Name = "pBMoveTurtle";
            this.pBMoveTurtle.Size = new System.Drawing.Size(114, 78);
            this.pBMoveTurtle.TabIndex = 12;
            this.pBMoveTurtle.TabStop = false;
            // 
            // pBMoveRabbit
            // 
            this.pBMoveRabbit.BackgroundImage = global::KTTTC4.Properties.Resources.how_to_draw_a_rabbit_featured_image_1200;
            this.pBMoveRabbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBMoveRabbit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBMoveRabbit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBMoveRabbit.Location = new System.Drawing.Point(0, 0);
            this.pBMoveRabbit.Name = "pBMoveRabbit";
            this.pBMoveRabbit.Size = new System.Drawing.Size(113, 78);
            this.pBMoveRabbit.TabIndex = 12;
            this.pBMoveRabbit.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.PbMoveDog);
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.pBMoveRabbit);
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 78);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Pink;
            this.panel3.Controls.Add(this.pBMoveTurtle);
            this.panel3.Location = new System.Drawing.Point(0, 454);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 78);
            this.panel3.TabIndex = 15;
            // 
            // Timer
            // 
            this.Timer.Interval = 16;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lbRank
            // 
            this.lbRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRank.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbRank.Location = new System.Drawing.Point(348, 218);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(150, 52);
            this.lbRank.TabIndex = 16;
            this.lbRank.Text = "label6";
            this.lbRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.lbRank);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "20242053TPE1-Phạm Hoàng Phúc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBRabbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTurtle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMoveDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMoveTurtle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMoveRabbit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MSFile;
        private System.Windows.Forms.ToolStripMenuItem fileNew;
        private System.Windows.Forms.ToolStripMenuItem fileRun;
        private System.Windows.Forms.ToolStripMenuItem fileExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pBRabbit;
        private System.Windows.Forms.PictureBox pBTurtle;
        private System.Windows.Forms.PictureBox pBDog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton rBRabbit;
        private System.Windows.Forms.RadioButton rBTurtle;
        private System.Windows.Forms.RadioButton rBdog;
        private System.Windows.Forms.PictureBox PbMoveDog;
        private System.Windows.Forms.PictureBox pBMoveTurtle;
        private System.Windows.Forms.PictureBox pBMoveRabbit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lbRank;
    }
}

