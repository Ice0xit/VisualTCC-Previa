using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTCC_Prévia
{
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
            guna2CircleButton1.Visible = false;
            guna2Transition1.ShowSync(guna2Panel1);
            guna2Panel1.Width = 78;

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            guna2CircleButton1.Visible = false;
            guna2Transition1.ShowSync(guna2Panel1);
            guna2Panel1.Width = 551;
        }
    }
}
