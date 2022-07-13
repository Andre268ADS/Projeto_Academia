using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Academia
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.T_NOMEUSUARIO = tb_nome.Text;
            usuario.T_USERNAME = tb_username.Text;
            usuario.T_SENHAUSUARIO = tb_senha.Text;
            usuario.T_STATUSUSUARIO = cb_status.Text;
            usuario.N_NIVELUSUARIO =Convert.ToInt32( Math.Round(n_nivel.Value,0));

            Banco.NovoUsuario(usuario);


        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            cb_status.Text = "";
            n_nivel.Value = 0;
            tb_nome.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {

            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            cb_status.Text = "";
            n_nivel.Value = 0;
            tb_nome.Focus();
        }
    }
}
