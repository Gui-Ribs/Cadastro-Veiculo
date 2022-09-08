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
    public partial class FrmCarro : Form
    {
        Carro carro;

        public FrmCarro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            carro = new Carro(txtCombustivel.Text, txtMarca.Text, txtModelo.Text, txtCategoria.Text, (Convert.ToInt32(txtAno.Text)), txtChassi.Text, txtMotor.Text, txtTransmissao.Text, txtCarroceria.Text);
            txtCombustivel.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCategoria.Clear();
            txtAno.Clear();
            txtChassi.Clear();
            txtMotor.Clear();
            txtTransmissao.Clear();
            txtCarroceria.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.ImprimeDados());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}
