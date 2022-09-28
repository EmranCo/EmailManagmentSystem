using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailManagementSystem
{
    public partial class EmailMessage : UserControl
    {

        public EmailMessage(bool seen = false)
        {
            InitializeComponent();
            if(seen)
            {
                panel1.BackColor = Color.Green;
                panel2.BackColor = Color.Green;
            }
        }

        private void SenderName_Click(object sender, EventArgs e)
        {

        }

        public void makeSeen()
        {
                panel1.BackColor = Color.Green;
                panel2.BackColor = Color.Green;
        }
    }
}
