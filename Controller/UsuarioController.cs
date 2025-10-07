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

        public void ListarUsuarios(string termo = "")
        {
            var listaUsuarios = _usuarioRepository.Listar(termo);
            _frmCadastroUsuario.ExibirUsuarios(_usuarioRepository.Listar(termo));
            _frmCadastroUsuario.ExibirUsuarios(listaUsuarios);
        }

        public void Salvar(Usuarios usuario)
        {
            try
            {
                _usuarioRepository.Inserir(usuario);
                _frmCadastroUsuario.ExibirMensagem("Usuário cadastrado com sucesso!");
                ListarUsuarios();
                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao salvar o usuário: {ex.Message}");
            }
        }

        public void Atualizar(Usuarios usuario)
        {
            try
            {
                _usuarioRepository.Atualizar(usuario);
                _frmCadastroUsuario.ExibirMensagem("Usuário Atualizado com sucesso!");
                ListarUsuarios();
                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao Atualizar o usuário: {ex.Message}");
            }
        }

        public void Deletar(Usuarios usuario)
        {
            try
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja deletar este usuário?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmacao == DialogResult.Yes)
                {
                    _usuarioRepository.Deletar(usuario);
                    _frmCadastroUsuario.ExibirMensagem("Usuário deletado com sucesso!");
                    ListarUsuarios();
                    _frmCadastroUsuario.DesabilitarCampos();
                }
            }catch(Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao deletar o usuário: {ex.Message}");
            }
    }
}
