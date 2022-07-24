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
    public partial class F_GestãoAlunos : Form
    {
        string vqueryDGV = "";
        string turmaAtual = "";
        string idSelecionado = "";
        string turma = "";
        int linha = 0;

        public F_GestãoAlunos()
        {
            InitializeComponent();
        }

        private void F_GestãoAlunos_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"
              SELECT 
                    N_IDALUNO as 'ID',
                    T_NOMEALUNO as 'Aluno'
              FROM
                    tb_alunos";

            dgv_gestaoalunos.DataSource = Banco.dql(vqueryDGV);
            dgv_gestaoalunos.Columns[0].Width = 40;
            dgv_gestaoalunos.Columns[1].Width = 120;

            tb_nome.Text = dgv_gestaoalunos.Rows[dgv_gestaoalunos.SelectedRows[0].Index].Cells[1].Value.ToString();

            //popular ComboBox Turmas

            string vqueryTurmas = @"
                    SELECT
                        N_IDTURMA,
                            ('Vagas: '|| (
                                            (N_MAXALUNOS)-( 
                                                            SELECT
                                                                    count(tba.N_IDALUNO)
                                                            FROM
                                                                    tb_alunos as tba
                                                            WHERE 
                                                                    tba.T_STATUS='A' and tba.N_IDTURMA=N_IDTURMA
                                                           )
                                           ) || ' / Turma: ' || T_DSCTURMA 
                             )as 'Turma'
                     FROM 
                        tb_turmas
                     ORDER BY
                        N_IDTURMA
                  ";

            cb_turmas.Items.Clear();
            cb_turmas.DataSource = Banco.dql(vqueryTurmas);
            cb_turmas.DisplayMember = "Turma";
            cb_turmas.ValueMember = "N_IDTURMA";

            //Popular ComboBox Status (Ativo=A, Bloqueado=B, Cancelado=C)

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A","Ativo");
            st.Add("B", "Bloqueado");
            st.Add("C", "Cancelado");
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";


            turma = cb_turmas.Text;
            turmaAtual = cb_turmas.Text;
            idSelecionado = dgv_gestaoalunos.Rows[0].Cells[0].Value.ToString();
            
        }

        private void dgv_gestaoalunos_Click(object sender, EventArgs e)
        {
            tb_nome.Text = dgv_gestaoalunos.Rows[dgv_gestaoalunos.SelectedRows[0].Index].Cells[1].Value.ToString();
        }

        private void btn_salvaredicoes_Click(object sender, EventArgs e)
        {
            turma = cb_turmas.Text;
            if(turmaAtual != turma)
            {
                string[] t = turma.Split(' ');
                int vagas = int.Parse(t[1]);
                if (vagas < 1)
                {
                    MessageBox.Show("Não há vagas na turma selecionada, selecione outra turma");
                    cb_turmas.Focus();
                    return;
                }
                linha = dgv_gestaoalunos.SelectedRows[0].Index;
                string queryAtulizarAluno = string.Format(@"
                         UPDATE 
                            tb_alunos
                         SET
                            T_NOMEALUNO='{0}',
                            T_TELEFONE='{1}',
                            T_STATUS='{2}',
                            N_IDTURMA='{3}'
                        WHERE
                            N_IDALUNO={4}",
                                  tb_nome.Text, mtb_telefone.Text,cb_status.SelectedValue,cb_turmas.SelectedValue,idSelecionado);
                Banco.dml(queryAtulizarAluno);
                dgv_gestaoalunos[1, linha].Value = tb_nome.Text;
            }
        }

        private void btn_excluiralunos_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirma exclusão?","Excluir",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string vqueryExcluirAluno = string.Format(@"
                        DELETE FORM
                            tb_alunos
                        WHERE 
                            N_IDALUNO={0}", idSelecionado);
                Banco.dml(vqueryExcluirAluno);
                dgv_gestaoalunos.Rows.Remove(dgv_gestaoalunos.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_gestaoalunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if(dgv.SelectedRows.Count > 0)
            {
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = String.Format(@"
                        SELECT
                            N_IDALUNO,
                            T_NOMEALUNO,
                            T_TELEFONE,
                            T_STATUS,
                            N_IDTURMA
                        FROM
                            tb_alunos
                        WHERE
                            N_IDALUNO={0}",idSelecionado);
                DataTable dt = Banco.dql(vqueryCampos);
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEALUNO");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                cb_status.SelectedValue = dt.Rows[0].Field<String>("T_STATUS");
                cb_turmas.SelectedValue = dt.Rows[0].Field<Int64>("N_IDTURMA");
                turmaAtual = cb_turmas.Text;
            }
        }
    }
}
