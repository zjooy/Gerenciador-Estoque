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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            pnlMenu.Location = new Point(this.Width / 2 - pnlMenu.Width / 2, this.Height / 2 - pnlMenu.Height / 2);

        }
    }
}
