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
    public partial class F_NovoAluno : Form
    {
        public F_NovoAluno()
        {
            InitializeComponent();
        }

        private void F_NovoAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string,string> status = new Dictionary<string,string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            mtb_telefone.Enabled = true;
            cb_status.Enabled = true;
            tb_nome.Clear();
            mtb_telefone.Clear();
            tb_turma.Clear();
            cb_status.SelectedIndex = 0;
            tb_nome.Focus();
            btn_gravar.Enabled = true;
            btn_Cancelar.Enabled = true;
            btn_novo.Enabled = false;
                
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;
            tb_nome.Clear();
            mtb_telefone.Clear();
            tb_turma.Clear();
            cb_status.SelectedIndex = 0;
            btn_gravar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_novo.Enabled = true;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            string queryInsertAluno = string.Format(@"
                INSERT INTO tb_alunos
                    (T_NOMEALUNO, T_TELEFONE, T_STATUS , N_IDTURMA)
                VALUES('{0}','{1}','{2}',{3})
                ",tb_nome.Text,mtb_telefone.Text,cb_status.SelectedValue, tb_turma.Tag.ToString());
            Banco.dml(queryInsertAluno);
            MessageBox.Show("Novo Aluno Inserido","Informação", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            
            
            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;
            cb_status.SelectedIndex = 0;
            tb_turma.Clear();
            btn_gravar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_novo.Enabled = true;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_SelecionarTurmas f_SelecionarTurmas = new F_SelecionarTurmas(this);
            f_SelecionarTurmas.ShowDialog();
        }
    }
}
