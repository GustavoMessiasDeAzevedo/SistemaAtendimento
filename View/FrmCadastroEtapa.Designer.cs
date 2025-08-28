namespace SistemaAtendimento.View
{
    partial class FrmCadastroEtapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEtapa));
            grbCadastroDeEtapa = new GroupBox();
            lblCódigo = new Label();
            txtCodigo = new TextBox();
            lblNome = new Label();
            textBox1 = new TextBox();
            lblOrdem = new Label();
            textBox2 = new TextBox();
            pnlSituacao = new Panel();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            lblSituacao = new Label();
            btnEditar = new Button();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            grbListaDeEtapas = new GroupBox();
            dataGridView1 = new DataGridView();
            imlIcones = new ImageList(components);
            grbCadastroDeEtapa.SuspendLayout();
            pnlSituacao.SuspendLayout();
            grbListaDeEtapas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grbCadastroDeEtapa
            // 
            grbCadastroDeEtapa.Controls.Add(lblSituacao);
            grbCadastroDeEtapa.Controls.Add(pnlSituacao);
            grbCadastroDeEtapa.Controls.Add(textBox2);
            grbCadastroDeEtapa.Controls.Add(lblOrdem);
            grbCadastroDeEtapa.Controls.Add(textBox1);
            grbCadastroDeEtapa.Controls.Add(lblNome);
            grbCadastroDeEtapa.Controls.Add(txtCodigo);
            grbCadastroDeEtapa.Controls.Add(lblCódigo);
            grbCadastroDeEtapa.Location = new Point(8, 8);
            grbCadastroDeEtapa.Name = "grbCadastroDeEtapa";
            grbCadastroDeEtapa.Size = new Size(648, 160);
            grbCadastroDeEtapa.TabIndex = 0;
            grbCadastroDeEtapa.TabStop = false;
            grbCadastroDeEtapa.Text = "Dados da Etapa";
            // 
            // lblCódigo
            // 
            lblCódigo.AutoSize = true;
            lblCódigo.Location = new Point(8, 24);
            lblCódigo.Name = "lblCódigo";
            lblCódigo.Size = new Size(46, 15);
            lblCódigo.TabIndex = 0;
            lblCódigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(8, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(128, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 23);
            textBox1.TabIndex = 3;
            // 
            // lblOrdem
            // 
            lblOrdem.AutoSize = true;
            lblOrdem.Location = new Point(8, 80);
            lblOrdem.Name = "lblOrdem";
            lblOrdem.Size = new Size(44, 15);
            lblOrdem.TabIndex = 4;
            lblOrdem.Text = "Ordem";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(8, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 5;
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(280, 96);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(144, 32);
            pnlSituacao.TabIndex = 6;
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
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(280, 80);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 7;
            lblSituacao.Text = "Situação";
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 2;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(96, 200);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 31);
            btnEditar.TabIndex = 30;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(663, 198);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 31);
            btnPesquisar.TabIndex = 35;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(471, 206);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(184, 23);
            txtPesquisar.TabIndex = 34;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(471, 190);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 28;
            lblPesquisar.Text = "Pesquisar";
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(368, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 31);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 1;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(272, 200);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 31);
            btnExcluir.TabIndex = 32;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(184, 200);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 31);
            btnSalvar.TabIndex = 31;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(8, 200);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(80, 31);
            btnNovo.TabIndex = 29;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // grbListaDeEtapas
            // 
            grbListaDeEtapas.Controls.Add(dataGridView1);
            grbListaDeEtapas.Location = new Point(8, 248);
            grbListaDeEtapas.Name = "grbListaDeEtapas";
            grbListaDeEtapas.Size = new Size(680, 176);
            grbListaDeEtapas.TabIndex = 36;
            grbListaDeEtapas.TabStop = false;
            grbListaDeEtapas.Text = "Lista de Etapas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(664, 144);
            dataGridView1.TabIndex = 0;
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
            // FrmCadastroEtapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 426);
            Controls.Add(grbListaDeEtapas);
            Controls.Add(btnEditar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(grbCadastroDeEtapa);
            Name = "FrmCadastroEtapa";
            Text = "Cadastro de Etapa";
            grbCadastroDeEtapa.ResumeLayout(false);
            grbCadastroDeEtapa.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            grbListaDeEtapas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbCadastroDeEtapa;
        private Label lblOrdem;
        private TextBox textBox1;
        private Label lblNome;
        private TextBox txtCodigo;
        private Label lblCódigo;
        private Panel pnlSituacao;
        private TextBox textBox2;
        private Label lblSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Button btnEditar;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private GroupBox grbListaDeEtapas;
        private ImageList imlIcones;
        private DataGridView dataGridView1;
    }
}