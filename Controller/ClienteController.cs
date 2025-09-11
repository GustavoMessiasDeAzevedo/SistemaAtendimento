using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;

namespace SistemaAtendimento.Controller
{
    public class ClienteController
    {
        
        private FrmCadastroCliente _frmCadastroCliente;
        private ClienteRepository _clienteRepository;
        public ClienteController(FrmCadastroCliente view) 
        { 
            _frmCadastroCliente = view;
            _clienteRepository = new ClienteRepository();
        }

        public void ListarClientes()
        {
            //try 
            //{
            //    _frmCadastroCliente.ExibirClientes(_clienteRepository.Listar());
            //}
            //catch(Exception ex)
            //{
            //    _frmCadastroCliente.ExibirMensagem($"Erro ao carregar os clientes: {ex.Message}");
            //}

            var listaClientes = _clienteRepository.Listar();

            _frmCadastroCliente.ExibirClientes(listaClientes);
        }

        public void Salvar(Clientes cliente)
        {

            try
            {
                _clienteRepository.Inserir(cliente);
                _frmCadastroCliente.ExibirMensagem("Cliente cadastrado com sucesso!");
                ListarClientes();
            }
            catch (Exception ex)
            {
                _frmCadastroCliente.ExibirMensagem($"Erro ao salvar o cliente: {ex.Message}");
            }
        }
    }
}
