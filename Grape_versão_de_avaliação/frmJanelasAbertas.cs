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
    public partial class frmJanelasAbertas : Form
    {
        public frmJanelasAbertas()
        {
            InitializeComponent();
        }

        private void frmJanelasAbertas_Load(object sender, EventArgs e)
        {
            frmGerenciadorDeFicheiros fecharForm = new frmGerenciadorDeFicheiros();
            if (Application.OpenForms.OfType<frmGerenciadorDeFicheiros>().Count() > 0)
            {
                fecharForm = null;
                foreach (var item in Application.OpenForms)
                {
                    if (item.ToString().Contains("frmGerenciadorDeFicheiros"))
                    {
                        fecharForm = ((frmGerenciadorDeFicheiros)item);
                    }
                }
                if (fecharForm != null)
                {
                    label1.Visible = false;
                }
            }

            if (Application.OpenForms.OfType<frmGerenciadorDeFicheiros>().Count() > 0)
            {
                ptbJanela1.Visible = true;
                ptbBotãoFechar1.Visible = true;
            }
            else if (Application.OpenForms.OfType<frmGrapeReprodutorDeMusicas>().Count() > 0)
            {
                ptbJanela2.Visible = true;
                ptbBotaoFechar2.Visible = true;
            }   
        }

        private void ptbBotãoFechar_Click(object sender, EventArgs e)
        {
            frmGerenciadorDeFicheiros fecharForm = new frmGerenciadorDeFicheiros();
            if (Application.OpenForms.OfType<frmGerenciadorDeFicheiros>().Count() > 0)
            {
                fecharForm = null;
                foreach (var item in Application.OpenForms)
                {
                    if (item.ToString().Contains("frmGerenciadorDeFicheiros"))
                    {
                        fecharForm = ((frmGerenciadorDeFicheiros)item);
                    }
                }
                if (fecharForm != null)
                {
                    fecharForm.Close();
                }
            }
            ptbJanela1.Visible = false;
            ptbBotãoFechar1.Visible = false;
        }

        private void ptbJanela1_Click(object sender, EventArgs e)
        {
            this.Close();

            frmGerenciadorDeFicheiros fecharForm = new frmGerenciadorDeFicheiros();
            if (Application.OpenForms.OfType<frmGerenciadorDeFicheiros>().Count() > 0)
            {
                fecharForm = null;
                foreach (var item in Application.OpenForms)
                {
                    if (item.ToString().Contains("frmGerenciadorDeFicheiros"))
                    {
                        fecharForm = ((frmGerenciadorDeFicheiros)item);
                    }
                }
                if (fecharForm != null)
                {
                    fecharForm.Close();
                }
            }

            frmGerenciadorDeFicheiros fgf = new frmGerenciadorDeFicheiros();
            fgf.Show();
        }

        private void ptbBotãoFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
