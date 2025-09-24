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
    public partial class FrmCadastroEtapa : Form
    {
        private EtapaController _etapaController;

        public FrmCadastroEtapa()
        {
            InitializeComponent();
            _etapaController = new EtapaController(this);
        }

        private void FrmCadastroEtapa_Load(object sender, EventArgs e)
        {
            _etapaController.ListarEtapas();
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirEtapas(List<Etapas> Etapas)
        {
            dgvEtapa.DataSource = Etapas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Etapas etapa = new Etapas
            {
                nome = txtNome.Text,
                ordem = txtOrdem.Text != "" ? Convert.ToInt32(txtOrdem.Text) : 0,
                Ativo = rdbAtivo.Checked
            };

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                _etapaController.Salvar(etapa);
            }
            else
            {
                etapa.Id = Convert.ToInt32(txtCodigo.Text);
                _etapaController.Atualizar(etapa);
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
            txtOrdem.ReadOnly = false;
            pnlSituacao.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtOrdem.Clear();
            rdbAtivo.Checked = true;
        }

        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtOrdem.ReadOnly = true;
            pnlSituacao.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void dgvEtapa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvEtapa.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["nome"].Value.ToString();
                txtOrdem.Text = linhaSelecionada.Cells["ordem"].Value.ToString();
                bool ativo = Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);
                if (ativo)
                    rdbAtivo.Checked = true;
                else
                    rdbInativo.Checked = true;

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
