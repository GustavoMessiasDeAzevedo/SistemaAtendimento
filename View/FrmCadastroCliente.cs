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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes()
            {
                nome = txtNome.Text,
                email = txtEmail.Text,
                cpf_cnpj = txtCpfCnpj.Text,
                tipo_pessoa = rdbFisica.Text,
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

            _clienteController.AdiconarClientes(cliente);

            _clienteController.ListarClientes();
        }
    }
}
