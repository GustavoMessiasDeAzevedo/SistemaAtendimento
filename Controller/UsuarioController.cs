using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class UsuarioController
    {
        private FrmCadastroUsuario _frmCadastroUsuario;
        private UsuarioRepository _usuarioRepository;

        public UsuarioController(FrmCadastroUsuario view) 
        {
            _frmCadastroUsuario = view;
            _usuarioRepository = new UsuarioRepository();
        }

        public void ListarUsuarios()
        {
            var listaUsuarios = _usuarioRepository.Listar();
            _frmCadastroUsuario.ExibirUsuarios(listaUsuarios);
        }

        public void Salvar(Usuarios usuario)
        {
            try
            {
                _usuarioRepository.Inserir(usuario);
                _frmCadastroUsuario.ExibirMensagem("Usuário cadastrado com sucesso!");
                ListarUsuarios();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao salvar o usuário: {ex.Message}");
            }
        }
    }
}
