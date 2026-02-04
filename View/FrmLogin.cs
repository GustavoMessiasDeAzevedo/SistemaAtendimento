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
    public partial class FrmLogin : Form
    {
        private UsuarioController _usuarioController;

        public FrmLogin()
        {
            InitializeComponent();

            _usuarioController = new UsuarioController(null);
            _frmTelaPrincipal = new FrmTelaPrincipal();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = _usuarioController.Autenticar(txtEmail.Text.Trim(), txtSenha.Text.Trim());

            if (usuario != null)
            {
                MessageBox.Show($"Bem-vindo, {usuario.Nome}!", "Login Bem-Sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
                frmTelaPrincipal.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Email ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
