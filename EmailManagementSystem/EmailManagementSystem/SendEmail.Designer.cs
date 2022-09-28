namespace EmailManagementSystem
{
    partial class SendEmail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEmail));
            this.reciever = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.RichTextBox();
            this.sendMailBtn = new System.Windows.Forms.Button();
            this.loader = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fromEmail = new System.Windows.Forms.TextBox();
            this.discard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            this.SuspendLayout();
            // 
            // reciever
            // 
            this.reciever.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciever.Location = new System.Drawing.Point(499, 114);
            this.reciever.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reciever.Name = "reciever";
            this.reciever.Size = new System.Drawing.Size(605, 38);
            this.reciever.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject:";
            // 
            // subject
            // 
            this.subject.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.Location = new System.Drawing.Point(152, 167);
            this.subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(952, 38);
            this.subject.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message:";
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.White;
            this.body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.body.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body.Location = new System.Drawing.Point(53, 271);
            this.body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(1051, 351);
            this.body.TabIndex = 5;
            this.body.Text = "";
            // 
            // sendMailBtn
            // 
            this.sendMailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendMailBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sendMailBtn.FlatAppearance.BorderSize = 0;
            this.sendMailBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(118)))), ((int)(((byte)(192)))));
            this.sendMailBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(118)))), ((int)(((byte)(250)))));
            this.sendMailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMailBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMailBtn.Image = ((System.Drawing.Image)(resources.GetObject("sendMailBtn.Image")));
            this.sendMailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendMailBtn.Location = new System.Drawing.Point(999, 13);
            this.sendMailBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendMailBtn.Name = "sendMailBtn";
            this.sendMailBtn.Size = new System.Drawing.Size(105, 43);
            this.sendMailBtn.TabIndex = 6;
            this.sendMailBtn.Text = "Send";
            this.sendMailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendMailBtn.UseVisualStyleBackColor = true;
            this.sendMailBtn.Click += new System.EventHandler(this.sendMailBtn_Click);
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.White;
            this.loader.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.loader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loader.Image = ((System.Drawing.Image)(resources.GetObject("loader.Image")));
            this.loader.Location = new System.Drawing.Point(0, 0);
            this.loader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(1175, 665);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loader.TabIndex = 7;
            this.loader.TabStop = false;
            this.loader.UseWaitCursor = true;
            this.loader.Visible = false;
            this.loader.WaitOnLoad = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "From:";
            // 
            // fromEmail
            // 
            this.fromEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fromEmail.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromEmail.ForeColor = System.Drawing.Color.Black;
            this.fromEmail.Location = new System.Drawing.Point(54, 114);
            this.fromEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fromEmail.Name = "fromEmail";
            this.fromEmail.ReadOnly = true;
            this.fromEmail.Size = new System.Drawing.Size(406, 38);
            this.fromEmail.TabIndex = 8;
            // 
            // discard
            // 
            this.discard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.discard.FlatAppearance.BorderSize = 0;
            this.discard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(118)))), ((int)(((byte)(192)))));
            this.discard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(118)))), ((int)(((byte)(250)))));
            this.discard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discard.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discard.Image = ((System.Drawing.Image)(resources.GetObject("discard.Image")));
            this.discard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discard.Location = new System.Drawing.Point(866, 13);
            this.discard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(127, 43);
            this.discard.TabIndex = 10;
            this.discard.Text = "Discard";
            this.discard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.discard.UseVisualStyleBackColor = true;
            this.discard.Click += new System.EventHandler(this.Discard_Click);
            // 
            // SendEmail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.loader);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromEmail);
            this.Controls.Add(this.sendMailBtn);
            this.Controls.Add(this.body);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reciever);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SendEmail";
            this.Size = new System.Drawing.Size(1175, 665);
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reciever;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.Button sendMailBtn;
        private System.Windows.Forms.PictureBox loader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fromEmail;
        private System.Windows.Forms.Button discard;
    }
}
