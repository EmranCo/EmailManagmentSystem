namespace EmailManagementSystem
{
    partial class Inboxes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inboxes));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inboxesList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.emailBody = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.inboxesList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.500703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.4993F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 659);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // inboxesList
            // 
            this.inboxesList.AutoScroll = true;
            this.inboxesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inboxesList.Location = new System.Drawing.Point(3, 33);
            this.inboxesList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inboxesList.Name = "inboxesList";
            this.inboxesList.Size = new System.Drawing.Size(299, 622);
            this.inboxesList.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 21);
            this.panel1.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Location = new System.Drawing.Point(219, 0);
            this.refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(80, 21);
            this.refresh.TabIndex = 1;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // searchBox
            // 
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchBox.Location = new System.Drawing.Point(0, 0);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(219, 24);
            this.searchBox.TabIndex = 0;
            // 
            // emailBody
            // 
            this.emailBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailBody.Location = new System.Drawing.Point(308, 3);
            this.emailBody.Margin = new System.Windows.Forms.Padding(15);
            this.emailBody.Name = "emailBody";
            this.emailBody.ReadOnly = true;
            this.emailBody.Size = new System.Drawing.Size(864, 659);
            this.emailBody.TabIndex = 2;
            this.emailBody.Text = "ddddddd";
            // 
            // Inboxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.emailBody);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Inboxes";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(1175, 665);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.FlowLayoutPanel inboxesList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox searchBox;
        public System.Windows.Forms.RichTextBox emailBody;
    }
}
