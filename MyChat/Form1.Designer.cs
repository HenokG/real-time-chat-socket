namespace MyChat
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
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.connected = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connect = new System.Windows.Forms.PictureBox();
            this.userBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.myIp = new System.Windows.Forms.Label();
            this.friendsIp = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.myPort80 = new System.Windows.Forms.RadioButton();
            this.myPort81 = new System.Windows.Forms.RadioButton();
            this.friendsPortLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.stickerToggle = new System.Windows.Forms.PictureBox();
            this.stickerPanel = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.angry = new System.Windows.Forms.PictureBox();
            this.messagesList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.connected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stickerToggle)).BeginInit();
            this.stickerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angry)).BeginInit();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.White;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.Location = new System.Drawing.Point(374, 715);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(269, 34);
            this.messageBox.TabIndex = 8;
            this.messageBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "My Ip Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(1002, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Friends Ip Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(1002, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Friends Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(212, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "My Port";
            // 
            // connected
            // 
            this.connected.BackColor = System.Drawing.Color.Transparent;
            this.connected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connected.BackgroundImage")));
            this.connected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connected.Location = new System.Drawing.Point(1125, 153);
            this.connected.Name = "connected";
            this.connected.Size = new System.Drawing.Size(29, 24);
            this.connected.TabIndex = 13;
            this.connected.TabStop = false;
            this.connected.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(649, 715);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.Transparent;
            this.connect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connect.BackgroundImage")));
            this.connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.connect.Location = new System.Drawing.Point(1000, 140);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(119, 55);
            this.connect.TabIndex = 18;
            this.connect.TabStop = false;
            this.connect.Click += new System.EventHandler(this.connect_Click_1);
            // 
            // userBox1
            // 
            this.userBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userBox1.BackgroundImage")));
            this.userBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userBox1.Location = new System.Drawing.Point(821, 30);
            this.userBox1.Name = "userBox1";
            this.userBox1.Size = new System.Drawing.Size(164, 165);
            this.userBox1.TabIndex = 19;
            this.userBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(23, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 165);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // myIp
            // 
            this.myIp.AutoSize = true;
            this.myIp.BackColor = System.Drawing.Color.Transparent;
            this.myIp.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myIp.ForeColor = System.Drawing.Color.White;
            this.myIp.Location = new System.Drawing.Point(212, 57);
            this.myIp.Name = "myIp";
            this.myIp.Size = new System.Drawing.Size(30, 22);
            this.myIp.TabIndex = 21;
            this.myIp.Text = "Ip";
            // 
            // friendsIp
            // 
            this.friendsIp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsIp.Location = new System.Drawing.Point(1006, 53);
            this.friendsIp.Name = "friendsIp";
            this.friendsIp.Size = new System.Drawing.Size(157, 26);
            this.friendsIp.TabIndex = 23;
            this.friendsIp.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(343, -4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(10, 849);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(785, -38);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(10, 849);
            this.richTextBox2.TabIndex = 26;
            this.richTextBox2.Text = "";
            // 
            // myPort80
            // 
            this.myPort80.AutoSize = true;
            this.myPort80.BackColor = System.Drawing.Color.Transparent;
            this.myPort80.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPort80.ForeColor = System.Drawing.Color.White;
            this.myPort80.Location = new System.Drawing.Point(215, 117);
            this.myPort80.Name = "myPort80";
            this.myPort80.Size = new System.Drawing.Size(45, 23);
            this.myPort80.TabIndex = 28;
            this.myPort80.TabStop = true;
            this.myPort80.Text = "80";
            this.myPort80.UseVisualStyleBackColor = false;
            this.myPort80.CheckedChanged += new System.EventHandler(this.myPort80_CheckedChanged);
            // 
            // myPort81
            // 
            this.myPort81.AutoSize = true;
            this.myPort81.BackColor = System.Drawing.Color.Transparent;
            this.myPort81.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPort81.ForeColor = System.Drawing.Color.White;
            this.myPort81.Location = new System.Drawing.Point(215, 146);
            this.myPort81.Name = "myPort81";
            this.myPort81.Size = new System.Drawing.Size(45, 23);
            this.myPort81.TabIndex = 30;
            this.myPort81.TabStop = true;
            this.myPort81.Text = "81";
            this.myPort81.UseVisualStyleBackColor = false;
            // 
            // friendsPortLabel
            // 
            this.friendsPortLabel.AutoSize = true;
            this.friendsPortLabel.BackColor = System.Drawing.Color.Transparent;
            this.friendsPortLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsPortLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.friendsPortLabel.Location = new System.Drawing.Point(1002, 118);
            this.friendsPortLabel.Name = "friendsPortLabel";
            this.friendsPortLabel.Size = new System.Drawing.Size(50, 22);
            this.friendsPortLabel.TabIndex = 32;
            this.friendsPortLabel.Text = "Port";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(374, 586);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 36);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(421, 588);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(105, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // stickerToggle
            // 
            this.stickerToggle.BackColor = System.Drawing.Color.Transparent;
            this.stickerToggle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stickerToggle.BackgroundImage")));
            this.stickerToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stickerToggle.Location = new System.Drawing.Point(538, 588);
            this.stickerToggle.Name = "stickerToggle";
            this.stickerToggle.Size = new System.Drawing.Size(105, 34);
            this.stickerToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stickerToggle.TabIndex = 35;
            this.stickerToggle.TabStop = false;
            this.stickerToggle.Click += new System.EventHandler(this.stickerToggle_Click);
            // 
            // stickerPanel
            // 
            this.stickerPanel.BackColor = System.Drawing.Color.Transparent;
            this.stickerPanel.Controls.Add(this.pictureBox9);
            this.stickerPanel.Controls.Add(this.pictureBox8);
            this.stickerPanel.Controls.Add(this.pictureBox7);
            this.stickerPanel.Controls.Add(this.pictureBox6);
            this.stickerPanel.Controls.Add(this.angry);
            this.stickerPanel.Location = new System.Drawing.Point(649, 182);
            this.stickerPanel.Name = "stickerPanel";
            this.stickerPanel.Size = new System.Drawing.Size(130, 400);
            this.stickerPanel.TabIndex = 36;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(14, 318);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(103, 71);
            this.pictureBox9.TabIndex = 4;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(14, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(103, 71);
            this.pictureBox8.TabIndex = 3;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(14, 89);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(103, 71);
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(14, 166);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(103, 71);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // angry
            // 
            this.angry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("angry.BackgroundImage")));
            this.angry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.angry.Location = new System.Drawing.Point(14, 243);
            this.angry.Name = "angry";
            this.angry.Size = new System.Drawing.Size(103, 71);
            this.angry.TabIndex = 0;
            this.angry.TabStop = false;
            // 
            // messagesList
            // 
            this.messagesList.BackColor = System.Drawing.Color.White;
            this.messagesList.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagesList.FormattingEnabled = true;
            this.messagesList.ItemHeight = 19;
            this.messagesList.Location = new System.Drawing.Point(374, 27);
            this.messagesList.Name = "messagesList";
            this.messagesList.Size = new System.Drawing.Size(269, 555);
            this.messagesList.TabIndex = 4;
            this.messagesList.SelectedIndexChanged += new System.EventHandler(this.messagesList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 761);
            this.Controls.Add(this.stickerPanel);
            this.Controls.Add(this.stickerToggle);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.friendsPortLabel);
            this.Controls.Add(this.myPort81);
            this.Controls.Add(this.myPort80);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.friendsIp);
            this.Controls.Add(this.myIp);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.userBox1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.connected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.messagesList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Chat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.connected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stickerToggle)).EndInit();
            this.stickerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox connected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox connect;
        private System.Windows.Forms.PictureBox userBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label myIp;
        private System.Windows.Forms.RichTextBox friendsIp;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RadioButton myPort80;
        private System.Windows.Forms.RadioButton myPort81;
        private System.Windows.Forms.Label friendsPortLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox stickerToggle;
        private System.Windows.Forms.Panel stickerPanel;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox angry;
        private System.Windows.Forms.ListBox messagesList;
    }
}

