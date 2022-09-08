using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veiculo
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCarro carro = new FrmCarro();
            carro.Show();
        }

        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCaminhao caminhao = new FrmCaminhao();
            caminhao.Show();
        }

        private void brnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
