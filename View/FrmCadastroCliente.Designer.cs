namespace SistemaAtendimento
{
    partial class FrmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCliente));
            grbDadosCliente = new GroupBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            cbxEstado = new ComboBox();
            lblEstado = new Label();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblSituacao = new Label();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            lblCidade = new Label();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            lblBairro = new Label();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtCep = new TextBox();
            lblCEP = new Label();
            txtCpfCnpj = new TextBox();
            lblCpfCnpj = new Label();
            pnlTipoPessoa = new Panel();
            rdbJuridica = new RadioButton();
            rdbFisica = new RadioButton();
            lblTipoPessoa = new Label();
            txtCelular = new TextBox();
            lblCelular = new Label();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnNovo = new Button();
            imlIcones = new ImageList(components);
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            grbListaClientes = new GroupBox();
            dgvCliente = new DataGridView();
            grbDadosCliente.SuspendLayout();
            pnlSituacao.SuspendLayout();
            pnlTipoPessoa.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(txtEmail);
            grbDadosCliente.Controls.Add(lblEmail);
            grbDadosCliente.Controls.Add(cbxEstado);
            grbDadosCliente.Controls.Add(lblEstado);
            grbDadosCliente.Controls.Add(pnlSituacao);
            grbDadosCliente.Controls.Add(lblSituacao);
            grbDadosCliente.Controls.Add(lblComplemento);
            grbDadosCliente.Controls.Add(txtComplemento);
            grbDadosCliente.Controls.Add(lblCidade);
            grbDadosCliente.Controls.Add(txtCidade);
            grbDadosCliente.Controls.Add(txtBairro);
            grbDadosCliente.Controls.Add(lblBairro);
            grbDadosCliente.Controls.Add(lblNumero);
            grbDadosCliente.Controls.Add(txtNumero);
            grbDadosCliente.Controls.Add(txtEndereco);
            grbDadosCliente.Controls.Add(lblEndereco);
            grbDadosCliente.Controls.Add(txtCep);
            grbDadosCliente.Controls.Add(lblCEP);
            grbDadosCliente.Controls.Add(txtCpfCnpj);
            grbDadosCliente.Controls.Add(lblCpfCnpj);
            grbDadosCliente.Controls.Add(pnlTipoPessoa);
            grbDadosCliente.Controls.Add(lblTipoPessoa);
            grbDadosCliente.Controls.Add(txtCelular);
            grbDadosCliente.Controls.Add(lblCelular);
            grbDadosCliente.Controls.Add(txtTelefone);
            grbDadosCliente.Controls.Add(lblTelefone);
            grbDadosCliente.Controls.Add(txtNome);
            grbDadosCliente.Controls.Add(lblNome);
            grbDadosCliente.Controls.Add(txtCodigo);
            grbDadosCliente.Controls.Add(lblCodigo);
            grbDadosCliente.Location = new Point(8, 8);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(784, 296);
            grbDadosCliente.TabIndex = 0;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados do Cliente";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(432, 40);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(432, 24);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 31;
            lblEmail.Text = "Email";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxEstado.Location = new Point(16, 264);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(168, 23);
            cbxEstado.TabIndex = 12;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(16, 248);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 29;
            lblEstado.Text = "Estado";
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(200, 256);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(136, 32);
            pnlSituacao.TabIndex = 28;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(72, 8);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(8, 8);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(200, 240);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 27;
            lblSituacao.Text = "Situação";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(272, 192);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 26;
            lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(272, 208);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(240, 23);
            txtComplemento.TabIndex = 10;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(520, 192);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 24;
            lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(528, 208);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(248, 23);
            txtCidade.TabIndex = 11;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(16, 208);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(240, 23);
            txtBairro.TabIndex = 9;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(16, 192);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 21;
            lblBairro.Text = "Bairro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(608, 136);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 20;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(608, 152);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(168, 23);
            txtNumero.TabIndex = 8;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(200, 152);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(392, 23);
            txtEndereco.TabIndex = 7;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(200, 136);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 17;
            lblEndereco.Text = "Endereço";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(16, 152);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(168, 23);
            txtCep.TabIndex = 6;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(16, 136);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(28, 15);
            lblCEP.TabIndex = 15;
            lblCEP.Text = "CEP";
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(552, 96);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(224, 23);
            txtCpfCnpj.TabIndex = 5;
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(552, 80);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(60, 15);
            lblCpfCnpj.TabIndex = 13;
            lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // pnlTipoPessoa
            // 
            pnlTipoPessoa.Controls.Add(rdbJuridica);
            pnlTipoPessoa.Controls.Add(rdbFisica);
            pnlTipoPessoa.Location = new Point(384, 96);
            pnlTipoPessoa.Name = "pnlTipoPessoa";
            pnlTipoPessoa.Size = new Size(152, 32);
            pnlTipoPessoa.TabIndex = 12;
            // 
            // rdbJuridica
            // 
            rdbJuridica.AutoSize = true;
            rdbJuridica.Location = new Point(80, 8);
            rdbJuridica.Name = "rdbJuridica";
            rdbJuridica.Size = new Size(65, 19);
            rdbJuridica.TabIndex = 1;
            rdbJuridica.TabStop = true;
            rdbJuridica.Text = "Jurídica";
            rdbJuridica.UseVisualStyleBackColor = true;
            // 
            // rdbFisica
            // 
            rdbFisica.AutoSize = true;
            rdbFisica.Location = new Point(8, 8);
            rdbFisica.Name = "rdbFisica";
            rdbFisica.Size = new Size(54, 19);
            rdbFisica.TabIndex = 0;
            rdbFisica.TabStop = true;
            rdbFisica.Text = "Física";
            rdbFisica.UseVisualStyleBackColor = true;
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(384, 80);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(69, 15);
            lblTipoPessoa.TabIndex = 11;
            lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(200, 96);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(168, 23);
            txtCelular.TabIndex = 4;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(200, 80);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 8;
            lblCelular.Text = "Celular";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(16, 96);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(168, 23);
            txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(16, 80);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(136, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(280, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(136, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(16, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(16, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(32, 320);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(80, 31);
            btnNovo.TabIndex = 13;
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
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 2;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(120, 320);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 31);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(208, 320);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 31);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 1;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(296, 320);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 31);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(392, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 31);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(512, 312);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 6;
            lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(512, 328);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(184, 23);
            txtPesquisar.TabIndex = 18;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(704, 320);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 31);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(dgvCliente);
            grbListaClientes.Location = new Point(24, 360);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(760, 224);
            grbListaClientes.TabIndex = 9;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Clientes";
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(8, 24);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.Size = new Size(744, 184);
            dgvCliente.TabIndex = 0;
            // 
            // FrmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(grbListaClientes);
            Controls.Add(btnEditar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosCliente);
            Name = "FrmCadastroCliente";
            Text = "Cadastro de Cliente";
            Load += FrmCadastroCliente_Load;
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            pnlTipoPessoa.ResumeLayout(false);
            pnlTipoPessoa.PerformLayout();
            grbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosCliente;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtCelular;
        private Label lblCelular;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtNome;
        private Label lblNome;
   
        private Panel pnlTipoPessoa;
        private RadioButton rdbJuridica;
        private RadioButton rdbFisica;
        private Label lblTipoPessoa;
        private TextBox txtCpfCnpj;
        private Label lblCpfCnpj;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private Label lblCidade;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private Label lblBairro;
        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtCep;
        private Label lblCEP;
        private Panel pnlSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblSituacao;
        private ComboBox cbxEstado;
        private Label lblEstado;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private GroupBox grbListaClientes;
        private DataGridView dgvCliente;
        private ImageList imlIcones;
    }
}