using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmAtendimento : Form
    {


        public FrmAtendimento()
        {
            InitializeComponent();
        }


        private void btnPesquisarAtendimento_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsultaAtendimento = new FrmConsultaAtendimento();
            frmConsultaAtendimento.ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            cbxNomeCliente.Enabled = true;
            dtpAberturaAtendimento.Enabled = true;
            cbxSituacaoAtendimento.Enabled = true;
            txtObservacaoAtendimento.ReadOnly = false;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            cbxNomeCliente.Enabled = false;
            dtpAberturaAtendimento.Enabled = false;
            cbxSituacaoAtendimento.Enabled = false;
            txtObservacaoAtendimento.ReadOnly = true;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarCampos();
        }

        private void LimparCampos()
        {
            cbxEtapaAtendimento.SelectedIndex = -1;
            txtObservacaoAtendimento.Clear();
            dtpAberturaAtendimento.Value = DateTime.Now;
            cbxSituacaoAtendimento.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atendimentos atendimento = new Atendimentos
            {
                ClienteId = Convert.ToInt32(txtCodigoCliente.Text),
                UsuarioId = 1,
                SituacaoAtendimentoId = Convert.ToInt32(cbxSituacaoAtendimento.SelectedValue),
                DataAbertura = dtpAberturaAtendimento.Value,
                Observacao = txtObservacaoAtendimento.Text
            };
            if (!ValidarDados(atendimento))
                return;
        }

        private bool ValidarDados(Atendimentos atendimento)
        {
            //Criar Regras de validação de campos

            return true;
        }
    }
}
