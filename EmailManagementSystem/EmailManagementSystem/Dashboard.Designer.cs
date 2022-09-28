namespace EmailManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sentMailBtn = new System.Windows.Forms.Button();
            this.trashedBtn = new System.Windows.Forms.Button();
            this.inboxBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.allMailsBtn = new System.Windows.Forms.Button();
            this.spamMailsBtn = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.sendEmail1 = new EmailManagementSystem.SendEmail();
            this.inboxes1 = new EmailManagementSystem.Inboxes();
            this.draft = new EmailManagementSystem.Inboxes();
            this.sentMails = new EmailManagementSystem.Inboxes();
            this.allMails = new EmailManagementSystem.Inboxes();
            this.spamMails = new EmailManagementSystem.Inboxes();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(118)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.spamMailsBtn);
            this.panel1.Controls.Add(this.allMailsBtn);
            this.panel1.Controls.Add(this.sentMailBtn);
            this.panel1.Controls.Add(this.trashedBtn);
            this.panel1.Controls.Add(this.inboxBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 801);
            this.panel1.TabIndex = 0;
            // 
            // sentMailBtn
            // 
            this.sentMailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sentMailBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sentMailBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sentMailBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.sentMailBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sentMailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sentMailBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold);
            this.sentMailBtn.ForeColor = System.Drawing.Color.Lavender;
            this.sentMailBtn.Image = ((System.Drawing.Image)(resources.GetObject("sentMailBtn.Image")));
            this.sentMailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sentMailBtn.Location = new System.Drawing.Point(0, 458);
            this.sentMailBtn.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.sentMailBtn.Name = "sentMailBtn";
            this.sentMailBtn.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.sentMailBtn.Size = new System.Drawing.Size(314, 82);
            this.sentMailBtn.TabIndex = 4;
            this.sentMailBtn.Text = "Sent Mail";
            this.sentMailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sentMailBtn.UseVisualStyleBackColor = true;
            this.sentMailBtn.Click += new System.EventHandler(this.SentMailBtn_Click);
            // 
            // trashedBtn
            // 
            this.trashedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trashedBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.trashedBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.trashedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.trashedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.trashedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trashedBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold);
            this.trashedBtn.ForeColor = System.Drawing.Color.Lavender;
            this.trashedBtn.Image = ((System.Drawing.Image)(resources.GetObject("trashedBtn.Image")));
            this.trashedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trashedBtn.Location = new System.Drawing.Point(0, 376);
            this.trashedBtn.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.trashedBtn.Name = "trashedBtn";
            this.trashedBtn.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.trashedBtn.Size = new System.Drawing.Size(314, 82);
            this.trashedBtn.TabIndex = 3;
            this.trashedBtn.Text = "Trashed";
            this.trashedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trashedBtn.UseVisualStyleBackColor = true;
            this.trashedBtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // inboxBtn
            // 
            this.inboxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inboxBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inboxBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.inboxBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.inboxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.inboxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inboxBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold);
            this.inboxBtn.ForeColor = System.Drawing.Color.Lavender;
            this.inboxBtn.Image = ((System.Drawing.Image)(resources.GetObject("inboxBtn.Image")));
            this.inboxBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inboxBtn.Location = new System.Drawing.Point(0, 294);
            this.inboxBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inboxBtn.Name = "inboxBtn";
            this.inboxBtn.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.inboxBtn.Size = new System.Drawing.Size(314, 82);
            this.inboxBtn.TabIndex = 2;
            this.inboxBtn.Text = "Inbox";
            this.inboxBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inboxBtn.UseVisualStyleBackColor = true;
            this.inboxBtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(314, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Mail";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sendEmail1);
            this.panel2.Controls.Add(this.inboxes1);
            this.panel2.Controls.Add(this.draft);
            this.panel2.Controls.Add(this.sentMails);
            this.panel2.Controls.Add(this.allMails);
            this.panel2.Controls.Add(this.spamMails);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(314, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 801);
            this.panel2.TabIndex = 1;
            // 
            // allMailsBtn
            // 
            this.allMailsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allMailsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.allMailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.allMailsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.allMailsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.allMailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allMailsBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold);
            this.allMailsBtn.ForeColor = System.Drawing.Color.Lavender;
            this.allMailsBtn.Image = ((System.Drawing.Image)(resources.GetObject("allMailsBtn.Image")));
            this.allMailsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.allMailsBtn.Location = new System.Drawing.Point(0, 540);
            this.allMailsBtn.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.allMailsBtn.Name = "allMailsBtn";
            this.allMailsBtn.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.allMailsBtn.Size = new System.Drawing.Size(314, 82);
            this.allMailsBtn.TabIndex = 5;
            this.allMailsBtn.Text = "All Mails";
            this.allMailsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allMailsBtn.UseVisualStyleBackColor = true;
            this.allMailsBtn.Click += new System.EventHandler(this.AllMailsBtn_Click);
            // 
            // spamMailsBtn
            // 
            this.spamMailsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spamMailsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.spamMailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.spamMailsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.spamMailsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.spamMailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spamMailsBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold);
            this.spamMailsBtn.ForeColor = System.Drawing.Color.Lavender;
            this.spamMailsBtn.Image = ((System.Drawing.Image)(resources.GetObject("spamMailsBtn.Image")));
            this.spamMailsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spamMailsBtn.Location = new System.Drawing.Point(0, 622);
            this.spamMailsBtn.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.spamMailsBtn.Name = "spamMailsBtn";
            this.spamMailsBtn.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.spamMailsBtn.Size = new System.Drawing.Size(314, 82);
            this.spamMailsBtn.TabIndex = 6;
            this.spamMailsBtn.Text = "Spam Mails";
            this.spamMailsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spamMailsBtn.UseVisualStyleBackColor = true;
            this.spamMailsBtn.Click += new System.EventHandler(this.SpamMailsBtn_Click);
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.Color.Lavender;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout.Location = new System.Drawing.Point(0, 719);
            this.logout.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.logout.Size = new System.Drawing.Size(314, 82);
            this.logout.TabIndex = 7;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // sendEmail1
            // 
            this.sendEmail1.BackColor = System.Drawing.Color.White;
            this.sendEmail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendEmail1.Location = new System.Drawing.Point(0, 0);
            this.sendEmail1.Margin = new System.Windows.Forms.Padding(0);
            this.sendEmail1.Name = "sendEmail1";
            this.sendEmail1.Size = new System.Drawing.Size(1333, 801);
            this.sendEmail1.TabIndex = 1;
            // 
            // inboxes1
            // 
            this.inboxes1.AutoScroll = true;
            this.inboxes1.AutoSize = true;
            this.inboxes1.BackColor = System.Drawing.Color.White;
            this.inboxes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inboxes1.Location = new System.Drawing.Point(0, 0);
            this.inboxes1.Margin = new System.Windows.Forms.Padding(10);
            this.inboxes1.Name = "inboxes1";
            this.inboxes1.Padding = new System.Windows.Forms.Padding(3);
            this.inboxes1.Size = new System.Drawing.Size(1333, 801);
            this.inboxes1.TabIndex = 0;
            // 
            // draft
            // 
            this.draft.AutoScroll = true;
            this.draft.AutoSize = true;
            this.draft.BackColor = System.Drawing.Color.White;
            this.draft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.draft.Location = new System.Drawing.Point(0, 0);
            this.draft.Margin = new System.Windows.Forms.Padding(10);
            this.draft.Name = "draft";
            this.draft.Padding = new System.Windows.Forms.Padding(3);
            this.draft.Size = new System.Drawing.Size(1333, 801);
            this.draft.TabIndex = 2;
            // 
            // sentMails
            // 
            this.sentMails.AutoScroll = true;
            this.sentMails.AutoSize = true;
            this.sentMails.BackColor = System.Drawing.Color.White;
            this.sentMails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sentMails.Location = new System.Drawing.Point(0, 0);
            this.sentMails.Margin = new System.Windows.Forms.Padding(10);
            this.sentMails.Name = "sentMails";
            this.sentMails.Padding = new System.Windows.Forms.Padding(3);
            this.sentMails.Size = new System.Drawing.Size(1333, 801);
            this.sentMails.TabIndex = 3;
            // 
            // allMails
            // 
            this.allMails.AutoScroll = true;
            this.allMails.AutoSize = true;
            this.allMails.BackColor = System.Drawing.Color.White;
            this.allMails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allMails.Location = new System.Drawing.Point(0, 0);
            this.allMails.Margin = new System.Windows.Forms.Padding(10);
            this.allMails.Name = "allMails";
            this.allMails.Padding = new System.Windows.Forms.Padding(3);
            this.allMails.Size = new System.Drawing.Size(1333, 801);
            this.allMails.TabIndex = 4;
            // 
            // spamMails
            // 
            this.spamMails.AutoScroll = true;
            this.spamMails.AutoSize = true;
            this.spamMails.BackColor = System.Drawing.Color.White;
            this.spamMails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spamMails.Location = new System.Drawing.Point(0, 0);
            this.spamMails.Margin = new System.Windows.Forms.Padding(10);
            this.spamMails.Name = "spamMails";
            this.spamMails.Padding = new System.Windows.Forms.Padding(3);
            this.spamMails.Size = new System.Drawing.Size(1333, 801);
            this.spamMails.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1647, 801);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1665, 848);
            this.MinimumSize = new System.Drawing.Size(1665, 848);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button inboxBtn;
        private System.Windows.Forms.Button trashedBtn;
        private System.Windows.Forms.Button sentMailBtn;
        private System.Windows.Forms.Panel panel2;
        private SendEmail sendEmail1;
        private Inboxes inboxes1;
        private Inboxes draft;
        private Inboxes sentMails;
        private System.Windows.Forms.Button allMailsBtn;
        private Inboxes allMails;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button spamMailsBtn;
        private Inboxes spamMails;
    }
}