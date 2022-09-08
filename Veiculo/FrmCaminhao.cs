using ProjetoVeiculo;
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
    public partial class FrmCaminhao : Form
    {
        Caminhao caminhao;

        public FrmCaminhao()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao(txtCombustivel.Text, txtMarca.Text, txtModelo.Text, txtCategoria.Text, (Convert.ToInt32(txtAno.Text)), txtChassi.Text, txtCarga.Text, txtEixo.Text, txtPlataforma.Text);
            txtCombustivel.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCategoria.Clear();
            txtAno.Clear();
            txtChassi.Clear();
            txtCarga.Clear();
            txtEixo.Clear();
            txtPlataforma.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.ImprimeDados());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}
