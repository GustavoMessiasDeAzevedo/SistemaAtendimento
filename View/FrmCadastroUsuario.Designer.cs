namespace SistemaAtendimento.View
{
    partial class FrmCadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            grbDadosDoUsuário = new GroupBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lblPerfil = new Label();
            grbListaDeUsuario = new GroupBox();
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            imlIcones = new ImageList(components);
            cbxPerfil = new ComboBox();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            grbDadosDoUsuário.SuspendLayout();
            grbListaDeUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grbDadosDoUsuário
            // 
            grbDadosDoUsuário.Controls.Add(txtCodigo);
            grbDadosDoUsuário.Controls.Add(lblCodigo);
            grbDadosDoUsuário.Controls.Add(cbxPerfil);
            grbDadosDoUsuário.Controls.Add(lblPerfil);
            grbDadosDoUsuário.Controls.Add(txtSenha);
            grbDadosDoUsuário.Controls.Add(lblSenha);
            grbDadosDoUsuário.Controls.Add(txtEmail);
            grbDadosDoUsuário.Controls.Add(lblEmail);
            grbDadosDoUsuário.Controls.Add(txtNome);
            grbDadosDoUsuário.Controls.Add(lblNome);
            grbDadosDoUsuário.Location = new Point(8, 16);
            grbDadosDoUsuário.Name = "grbDadosDoUsuário";
            grbDadosDoUsuário.Size = new Size(688, 160);
            grbDadosDoUsuário.TabIndex = 0;
            grbDadosDoUsuário.TabStop = false;
            grbDadosDoUsuário.Text = "Dados do Usuário";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(128, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(128, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 23);
            txtNome.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(392, 32);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(392, 48);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(16, 104);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(312, 23);
            txtSenha.TabIndex = 5;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(16, 88);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(344, 88);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 6;
            lblPerfil.Text = "Perfil";
            // 
            // grbListaDeUsuario
            // 
            grbListaDeUsuario.Controls.Add(dataGridView1);
            grbListaDeUsuario.Location = new Point(8, 248);
            grbListaDeUsuario.Name = "grbListaDeUsuario";
            grbListaDeUsuario.Size = new Size(688, 192);
            grbListaDeUsuario.TabIndex = 1;
            grbListaDeUsuario.TabStop = false;
            grbListaDeUsuario.Text = "Lista de Usuário";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(672, 160);
            dataGridView1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 2;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(96, 208);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 31);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(663, 206);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 31);
            btnPesquisar.TabIndex = 27;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(471, 214);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(184, 23);
            txtPesquisar.TabIndex = 26;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(471, 198);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 20;
            lblPesquisar.Text = "Pesquisar";
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(368, 208);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 31);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 1;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(272, 208);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 31);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(184, 208);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 31);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(8, 208);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(80, 31);
            btnNovo.TabIndex = 21;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-cancelar.png");
            imlIcones.Images.SetKeyName(1, "icone-delete.png");
            imlIcones.Images.SetKeyName(2, "icone-editar.png");
            imlIcones.Images.SetKeyName(3, "icone-novo.png");
            imlIcones.Images.SetKeyName(4, "icone-pesquisar.png");
            imlIcones.Images.SetKeyName(5, "icone-salvar.png");
            // 
            // cbxPerfil
            // 
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Location = new Point(344, 104);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(160, 23);
            cbxPerfil.TabIndex = 8;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(16, 32);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 9;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(16, 48);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 10;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(grbListaDeUsuario);
            Controls.Add(grbDadosDoUsuário);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro de Usuario";
            grbDadosDoUsuário.ResumeLayout(false);
            grbDadosDoUsuário.PerformLayout();
            grbListaDeUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosDoUsuário;
        private Label lblPerfil;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtNome;
        private Label lblNome;
        private GroupBox grbListaDeUsuario;
        private DataGridView dataGridView1;
        private Button btnEditar;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private ImageList imlIcones;
        private ComboBox cbxPerfil;
        private TextBox txtCodigo;
        private Label lblCodigo;
    }
}