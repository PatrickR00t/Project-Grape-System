using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grape_versão_de_avaliação
{
    public partial class frmDadosDoUsuario : Form
    {
        public frmDadosDoUsuario()
        {
            InitializeComponent();
        }

        private void btnFinalizarConfigurações_Click(object sender, EventArgs e)
        {
            /*
            Controle controle = new Controle();
            String menssagem = controle.cadastrar(txbNome.Text, txbSenha.Text, txbConfSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show(menssagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.menssagem);
            }
            */

            frmCarregando fc = new frmCarregando();
            fc.Show();

            this.Close();
        }
    }
}
