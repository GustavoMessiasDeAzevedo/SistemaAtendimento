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
                
                if(rdbFisica.Checked)
                    ExibirMensagem("O campo CPF é obrigatório.");
                    
                else
                    ExibirMensagem("O campo CNPJ é obrigatório.");
                    txtCpfCnpj.Focus();
                    return false;

                
                
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
    }
}
