namespace rec_rewild_room_editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            dateTimePicker1 = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            loadingScreenToolStripMenuItem = new ToolStripMenuItem();
            subroomToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            CheerCountBox = new TextBox();
            FavoriteCountBox = new TextBox();
            VisitorCountBox = new TextBox();
            FavoriteCount = new Label();
            VisitorCount = new Label();
            CheerCount = new Label();
            VisitCount = new Label();
            VisitCountBox = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(106, 225);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(141, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, loadingScreenToolStripMenuItem, subroomToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(949, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(35, 20);
            fileToolStripMenuItem.Text = "file";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "close";
            // 
            // loadingScreenToolStripMenuItem
            // 
            loadingScreenToolStripMenuItem.Name = "loadingScreenToolStripMenuItem";
            loadingScreenToolStripMenuItem.Size = new Size(96, 20);
            loadingScreenToolStripMenuItem.Text = "loading screen";
            loadingScreenToolStripMenuItem.Click += loadingScreenToolStripMenuItem_Click;
            // 
            // subroomToolStripMenuItem
            // 
            subroomToolStripMenuItem.Name = "subroomToolStripMenuItem";
            subroomToolStripMenuItem.Size = new Size(67, 20);
            subroomToolStripMenuItem.Text = "subroom";
            subroomToolStripMenuItem.Click += subroomToolStripMenuItem_Click; 
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(42, 20);
            helpToolStripMenuItem.Text = "help";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGray;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(22, 18);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Description";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 73);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 59);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 234);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 13;
            label3.Text = "image path";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 231);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(311, 23);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 137);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 50);
            textBox2.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(106, 44);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(258, 23);
            textBox4.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 141);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 9;
            label2.Text = "room Warning";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 44);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 8;
            label4.Text = "room Name";
            label4.Click += label4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(106, 195);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(258, 23);
            textBox5.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 195);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 14;
            label5.Text = "room Id";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(checkBox6);
            panel1.Controls.Add(checkBox5);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(372, 44);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 174);
            panel1.TabIndex = 16;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(13, 138);
            checkBox6.Margin = new Padding(4, 3, 4, 3);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(116, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Custom Warning";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(13, 113);
            checkBox5.Margin = new Padding(4, 3, 4, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(71, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Violence";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(13, 88);
            checkBox3.Margin = new Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(103, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "IntenseMotion";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(13, 63);
            checkBox4.Margin = new Padding(4, 3, 4, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(102, 19);
            checkBox4.TabIndex = 2;
            checkBox4.Text = "FlashingLights";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(14, 38);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(64, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Mature";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(14, 13);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(57, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Scary ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(512, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 292);
            panel2.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(95, 257);
            button2.Name = "button2";
            button2.Size = new Size(67, 23);
            button2.TabIndex = 15;
            button2.Text = "set image";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 256);
            button1.Name = "button1";
            button1.Size = new Size(67, 23);
            button1.TabIndex = 14;
            button1.Text = "refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CheerCountBox
            // 
            CheerCountBox.Location = new Point(103, 271);
            CheerCountBox.Margin = new Padding(4, 3, 4, 3);
            CheerCountBox.Name = "CheerCountBox";
            CheerCountBox.Size = new Size(102, 23);
            CheerCountBox.TabIndex = 18;
            // 
            // FavoriteCountBox
            // 
            FavoriteCountBox.Location = new Point(102, 301);
            FavoriteCountBox.Margin = new Padding(4, 3, 4, 3);
            FavoriteCountBox.Name = "FavoriteCountBox";
            FavoriteCountBox.Size = new Size(102, 23);
            FavoriteCountBox.TabIndex = 19;
            // 
            // VisitorCountBox
            // 
            VisitorCountBox.Location = new Point(102, 330);
            VisitorCountBox.Margin = new Padding(4, 3, 4, 3);
            VisitorCountBox.Name = "VisitorCountBox";
            VisitorCountBox.Size = new Size(102, 23);
            VisitorCountBox.TabIndex = 20;
            // 
            // FavoriteCount
            // 
            FavoriteCount.AutoSize = true;
            FavoriteCount.Location = new Point(11, 304);
            FavoriteCount.Margin = new Padding(4, 0, 4, 0);
            FavoriteCount.Name = "FavoriteCount";
            FavoriteCount.Size = new Size(85, 15);
            FavoriteCount.TabIndex = 23;
            FavoriteCount.Text = "Favorite Count";
            // 
            // VisitorCount
            // 
            VisitorCount.AutoSize = true;
            VisitorCount.Location = new Point(20, 333);
            VisitorCount.Margin = new Padding(4, 0, 4, 0);
            VisitorCount.Name = "VisitorCount";
            VisitorCount.Size = new Size(76, 15);
            VisitorCount.TabIndex = 24;
            VisitorCount.Text = "Visitor Count";
            // 
            // CheerCount
            // 
            CheerCount.AutoSize = true;
            CheerCount.Location = new Point(22, 274);
            CheerCount.Margin = new Padding(4, 0, 4, 0);
            CheerCount.Name = "CheerCount";
            CheerCount.Size = new Size(74, 15);
            CheerCount.TabIndex = 25;
            CheerCount.Text = "Cheer Count";
            // 
            // VisitCount
            // 
            VisitCount.AutoSize = true;
            VisitCount.Location = new Point(31, 366);
            VisitCount.Margin = new Padding(4, 0, 4, 0);
            VisitCount.Name = "VisitCount";
            VisitCount.Size = new Size(65, 15);
            VisitCount.TabIndex = 27;
            VisitCount.Text = "Visit Count";
            // 
            // VisitCountBox
            // 
            VisitCountBox.Location = new Point(102, 363);
            VisitCountBox.Margin = new Padding(4, 3, 4, 3);
            VisitCountBox.Name = "VisitCountBox";
            VisitCountBox.Size = new Size(102, 23);
            VisitCountBox.TabIndex = 26;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(255, 225);
            dateTimePicker2.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(109, 23);
            dateTimePicker2.TabIndex = 28;
            dateTimePicker2.Value = new DateTime(2024, 6, 26, 17, 8, 8, 0);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(949, 396);
            Controls.Add(dateTimePicker2);
            Controls.Add(VisitCount);
            Controls.Add(VisitCountBox);
            Controls.Add(CheerCount);
            Controls.Add(VisitorCount);
            Controls.Add(FavoriteCount);
            Controls.Add(VisitorCountBox);
            Controls.Add(FavoriteCountBox);
            Controls.Add(CheerCountBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "rec rewild room editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadingScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.CheckBox checkBox4;
        public System.Windows.Forms.CheckBox checkBox5;
        public System.Windows.Forms.CheckBox checkBox6;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
        private Panel panel2;
        public PictureBox pictureBox1;
        public DateTimePicker dateTimePicker1;
        public TextBox CheerCountBox;
        public TextBox FavoriteCountBox;
        public TextBox VisitorCountBox;
        private Label FavoriteCount;
        private Label VisitorCount;
        private Label CheerCount;
        private Label VisitCount;
        public TextBox VisitCountBox;
        public DateTimePicker dateTimePicker2;
        private SaveFileDialog saveFileDialog1;
        private Button button1;
        private Button button2;
    }
}

