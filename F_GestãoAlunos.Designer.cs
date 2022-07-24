namespace Projeto_Academia
{
    partial class F_GestãoAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.btn_excluiralunos = new System.Windows.Forms.Button();
            this.btn_salvaredicoes = new System.Windows.Forms.Button();
            this.lb_novaturma = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.cb_turmas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_gestaoalunos = new System.Windows.Forms.DataGridView();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestaoalunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_financeiro);
            this.panel1.Controls.Add(this.btn_excluiralunos);
            this.panel1.Controls.Add(this.btn_salvaredicoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 31);
            this.panel1.TabIndex = 1;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(471, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(150, 23);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_financeiro.Location = new System.Drawing.Point(315, 3);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(150, 23);
            this.btn_financeiro.TabIndex = 1;
            this.btn_financeiro.Text = "Financeiro";
            this.btn_financeiro.UseVisualStyleBackColor = true;
            // 
            // btn_excluiralunos
            // 
            this.btn_excluiralunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluiralunos.Location = new System.Drawing.Point(159, 3);
            this.btn_excluiralunos.Name = "btn_excluiralunos";
            this.btn_excluiralunos.Size = new System.Drawing.Size(150, 23);
            this.btn_excluiralunos.TabIndex = 1;
            this.btn_excluiralunos.Text = "Excluir Aluno";
            this.btn_excluiralunos.UseVisualStyleBackColor = true;
            this.btn_excluiralunos.Click += new System.EventHandler(this.btn_excluiralunos_Click);
            // 
            // btn_salvaredicoes
            // 
            this.btn_salvaredicoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvaredicoes.Location = new System.Drawing.Point(3, 3);
            this.btn_salvaredicoes.Name = "btn_salvaredicoes";
            this.btn_salvaredicoes.Size = new System.Drawing.Size(150, 23);
            this.btn_salvaredicoes.TabIndex = 0;
            this.btn_salvaredicoes.Text = "Salvar Edições";
            this.btn_salvaredicoes.UseVisualStyleBackColor = true;
            this.btn_salvaredicoes.Click += new System.EventHandler(this.btn_salvaredicoes_Click);
            // 
            // lb_novaturma
            // 
            this.lb_novaturma.AutoSize = true;
            this.lb_novaturma.Location = new System.Drawing.Point(340, 12);
            this.lb_novaturma.Name = "lb_novaturma";
            this.lb_novaturma.Size = new System.Drawing.Size(38, 13);
            this.lb_novaturma.TabIndex = 4;
            this.lb_novaturma.Text = "Nome ";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(447, 84);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(167, 21);
            this.cb_status.TabIndex = 7;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(447, 68);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(37, 13);
            this.lb_status.TabIndex = 8;
            this.lb_status.Text = "Status";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(343, 84);
            this.mtb_telefone.Mask = "(99)99999-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(98, 20);
            this.mtb_telefone.TabIndex = 9;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(340, 68);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(49, 13);
            this.lb_telefone.TabIndex = 10;
            this.lb_telefone.Text = "Telefone";
            // 
            // cb_turmas
            // 
            this.cb_turmas.FormattingEnabled = true;
            this.cb_turmas.Location = new System.Drawing.Point(343, 141);
            this.cb_turmas.Name = "cb_turmas";
            this.cb_turmas.Size = new System.Drawing.Size(271, 21);
            this.cb_turmas.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Turmas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Imprimir Carteirinha";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(343, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 122);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Click duplo para alterar a foto";
            // 
            // dgv_gestaoalunos
            // 
            this.dgv_gestaoalunos.AllowUserToAddRows = false;
            this.dgv_gestaoalunos.AllowUserToDeleteRows = false;
            this.dgv_gestaoalunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_gestaoalunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_gestaoalunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gestaoalunos.EnableHeadersVisualStyles = false;
            this.dgv_gestaoalunos.Location = new System.Drawing.Point(3, 12);
            this.dgv_gestaoalunos.MultiSelect = false;
            this.dgv_gestaoalunos.Name = "dgv_gestaoalunos";
            this.dgv_gestaoalunos.ReadOnly = true;
            this.dgv_gestaoalunos.RowHeadersVisible = false;
            this.dgv_gestaoalunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gestaoalunos.Size = new System.Drawing.Size(322, 418);
            this.dgv_gestaoalunos.TabIndex = 16;
            this.dgv_gestaoalunos.SelectionChanged += new System.EventHandler(this.dgv_gestaoalunos_SelectionChanged);
            this.dgv_gestaoalunos.Click += new System.EventHandler(this.dgv_gestaoalunos_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(343, 28);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(271, 20);
            this.tb_nome.TabIndex = 17;
            // 
            // F_GestãoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 464);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.dgv_gestaoalunos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_turmas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_novaturma);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestãoAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Alunos";
            this.Load += new System.EventHandler(this.F_GestãoAlunos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestaoalunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Button btn_excluiralunos;
        private System.Windows.Forms.Button btn_salvaredicoes;
        private System.Windows.Forms.Label lb_novaturma;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.ComboBox cb_turmas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_gestaoalunos;
        private System.Windows.Forms.TextBox tb_nome;
    }
}