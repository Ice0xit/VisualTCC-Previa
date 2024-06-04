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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://app.powerbi.com/view?r=eyJrIjoiZjY3YjBlODAtMGU5Ni00MGFmLWE0NDYtNDU2NjljNGRlMGUzIiwidCI6IjBlYzIyMzNjLThhZTAtNDgzZC1hNjhkLTBmZGRmYmNkMTdhOCJ9");
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Estoque Estoque = new Estoque();
            Estoque.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Caixa Caixa = new Caixa();
            Caixa.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = false;
            guna2CircleButton2.Visible = true;
            guna2CircleButton1.Visible = false;
            guna2Transition1.ShowSync(guna2Panel1);
            guna2Transition1.ShowSync(guna2Panel2);
            guna2Panel1.Width = 57;
            guna2Panel2.Width = 1159;


        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = true;
            guna2CircleButton2.Visible = false;
            guna2CircleButton1.Visible = true;
            guna2Transition1.ShowSync(guna2Panel1);
            guna2Transition1.ShowSync(guna2Panel2);
            guna2Panel1.Width = 155;
            guna2Panel2.Width = 1068;
        }
    }
}
