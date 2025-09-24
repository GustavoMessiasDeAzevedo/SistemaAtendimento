using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmCadastroSituacaoAtendimento : Form
    {
        private SituacaoClienteController _situacaoClienteController;
        public FrmCadastroSituacaoAtendimento()
        {
            InitializeComponent();
            _situacaoClienteController = new SituacaoClienteController(this);
        }

        private void FrmCadastroSituacaoAtendimento_Load(object sender, EventArgs e)
        {
            _situacaoClienteController.ListarSitucao();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirSituacoes(List<SituacaoAtendimento> SituacaoAtendimento)
        {
            dgvSituacaoAtendimento.DataSource = SituacaoAtendimento;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SituacaoAtendimento situacaoAtendimento = new SituacaoAtendimento
            {
                nome = txtNome.Text,
                cor = txtCor.Text,
                Ativo = rdbAtivo.Checked
            };

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                _situacaoClienteController.Salvar(situacaoAtendimento);
            }
            else
            {
                situacaoAtendimento.Id = Convert.ToInt32(txtCodigo.Text);
                _situacaoClienteController.Atualizar(situacaoAtendimento);
            }
            DesabilitarCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtCor.ReadOnly = false;
            pnlSituacao.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCor.Clear();
            rdbAtivo.Checked = true;
        }

        public void DesabilitarCampos()
        {
            LimparCampos();

            txtNome.ReadOnly = true;
            txtCor.ReadOnly = true;
            pnlSituacao.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnNovo.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void dgvSituacaoAtendimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvSituacaoAtendimento.Rows[e.RowIndex];
                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["nome"].Value.ToString();
                txtCor.Text = linhaSelecionada.Cells["cor"].Value.ToString();
                bool ativo = Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);
                if (ativo)
                {
                    rdbAtivo.Checked = true;
                }
                else
                {
                    rdbInativo.Checked = true;
                }

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }
    }
}
