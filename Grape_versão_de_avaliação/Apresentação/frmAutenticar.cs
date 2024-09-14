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
    public partial class frmAutenticar : Form
    {
        public frmAutenticar()
        {
            InitializeComponent();
        }
        private void TMhora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbNome.Text, txbSenha.Text);
            if (controle.menssagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dados não encontrados, verifique Nome e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.menssagem);
            }

            frmBemVindoInicializar fbvi = new frmBemVindoInicializar();
            fbvi.Show();

            this.Close();
        }

        private void frmAutenticar_Load(object sender, EventArgs e)
        {
            lblNome.Parent = ptbFundoAutenticar;
            lblNome.BackColor = Color.Transparent;
            lblSenha.Parent = ptbFundoAutenticar;
            lblSenha.BackColor = Color.Transparent;
            lblHora.Parent = ptbFundoAutenticar;
            lblHora.BackColor = Color.Transparent;
            lblData.Parent = ptbFundoAutenticar;
            lblData.BackColor = Color.Transparent;
        }
    }
}
