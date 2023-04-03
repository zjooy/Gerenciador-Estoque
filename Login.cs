using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atacadao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.Width / 2, this.Height / 2 - pnlLogin.Height / 2);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Hide();
        }
    }
}
