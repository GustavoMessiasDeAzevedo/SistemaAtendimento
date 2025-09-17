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

namespace SistemaAtendimento
{
    public partial class FrmCadastroCliente : Form
    {
        private ClienteController _clienteController;

        public FrmCadastroCliente()
        {
            InitializeComponent();
            _clienteController = new ClienteController(this);
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            _clienteController.ListarClientes();
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
        public void ExibirClientes(List<Clientes> clientes)
        {
            dgvCliente.DataSource = clientes;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes
            {
                nome = txtNome.Text,
                email = txtEmail.Text,
                cpf_cnpj = txtCpfCnpj.Text,
                tipo_pessoa = (rdbFisica.Checked) ? "F" : "J",
                telefone = txtTelefone.Text,
                celular = txtCelular.Text,
                cep = txtCep.Text,
                endereco = txtEndereco.Text,
                numero = txtNumero.Text,
                complemento = txtComplemento.Text,
                bairro = txtBairro.Text,
                cidade = txtCidade.Text,
                estado = cbxEstado.Text,
                ativo = rdbAtivo.Checked
            };

            if (!ValidarDados(cliente))
                return;

            _clienteController.Salvar(cliente);
            DesabilitarCampos();
        }

        public bool ValidarDados(Clientes cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.nome))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.email))
            {
                ExibirMensagem("O campo Email é obrigatório.");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.cpf_cnpj))
            {

                if (rdbFisica.Checked)
                    ExibirMensagem("O campo CPF é obrigatório.");

                else
                    ExibirMensagem("O campo CNPJ é obrigatório.");

                txtCpfCnpj.Focus();
                return false;
            }
            else
            {
                if (rdbFisica.Checked)
                {
                    if (ValidarCPF() == false)
                    {
                        ExibirMensagem("CPF inválido");
                        return false;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(cliente.cep))
            {
                ExibirMensagem("O campo CEP é obrigatório.");
                txtCep.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cliente.endereco))
            {
                ExibirMensagem("O campo Endereço é obrigatório.");
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cliente.numero))
            {
                ExibirMensagem("O campo Número é obrigatório.");
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.bairro))
            {
                ExibirMensagem("O campo Bairro é obrigatório.");
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cliente.cidade))
            {
                ExibirMensagem("O campo Cidade é obrigatório.");
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cliente.estado))
            {
                ExibirMensagem("O campo Estado é obrigatório.");
                cbxEstado.Focus();
                return false;
            }
            return true;
        }

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpj.Text = "CNPJ";
        }

        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpj.Text = "CPF";
        }



        public bool ValidarCPF()
        {
            int[] numeroCPF = new int[11];

            for (int i = 0; i < 11; i++)
            {
                numeroCPF[i] = int.Parse(txtCpfCnpj.Text[i].ToString());
            }

            //1° Digito
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += numeroCPF[i] * (10 - i);
            }
            int resultado = soma % 11;
            if (resultado < 2)
            {
                numeroCPF[9] = 0;
            }
            else
            {
                numeroCPF[9] = 11 - resultado;
            }

            //2° Digito

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += numeroCPF[i] * (11 - i);
            }
            resultado = soma % 11;
            if (resultado < 2)
            {
                numeroCPF[10] = 0;
            }
            else
            {
                numeroCPF[10] = 11 - resultado;
            }
            if (numeroCPF[9] == int.Parse(txtCpfCnpj.Text[9].ToString()) && numeroCPF[10] == int.Parse(txtCpfCnpj.Text[10].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }


        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtCpfCnpj.ReadOnly = false;
            pnlTipoPessoa.Enabled = true;
            txtTelefone.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtCep.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtComplemento.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtCidade.ReadOnly = false;
            cbxEstado.Enabled = true;
            pnlSituacao.Enabled = true;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCpfCnpj.Clear();
            rdbFisica.Checked = true;
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbxEstado.SelectedIndex = -1;
            rdbAtivo.Checked = true;
        }

        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCpfCnpj.ReadOnly = true;
            pnlTipoPessoa.Enabled = false;
            txtTelefone.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtCep.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtCidade.ReadOnly = true;
            cbxEstado.Enabled = true;
            pnlSituacao.Enabled = true;

            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnExcluir.Enabled = false; 
            btnNovo.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            DesabilitarCampos();
        }
    }

}
