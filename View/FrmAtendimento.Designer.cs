namespace SistemaAtendimento.View
{
    partial class FrmAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtendimento));
            groupBox1 = new GroupBox();
            lblCodigoCliente = new Label();
            txtCodigoCliente = new TextBox();
            lblNomeCliente = new Label();
            cbxNomeCliente = new ComboBox();
            lblDataAbertura = new Label();
            dtpAberturaAtendimento = new DateTimePicker();
            lblSituacaoAtendimento = new Label();
            cbxSituacaoAtendimento = new ComboBox();
            lblObservacaoCliente = new Label();
            txtOservacaoAtendimento = new TextBox();
            btnEditar = new Button();
            btnFinalizar = new Button();
            imageList1 = new ImageList(components);
            label6 = new Label();
            txtCodigoAtendimento = new TextBox();
            groupBox2 = new GroupBox();
            lblEtapadoAtendimento = new Label();
            cbxEtapaAtendimento = new ComboBox();
            lblObservacaoEtapas = new Label();
            txtEtapaObservacao = new TextBox();
            dgvEtapasAtendimento = new DataGridView();
            btnAdicionarEtapa = new Button();
            btnExcluirEtapa = new Button();
            btnPesquisarAtendimento = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnFinalizar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(txtOservacaoAtendimento);
            groupBox1.Controls.Add(lblObservacaoCliente);
            groupBox1.Controls.Add(cbxSituacaoAtendimento);
            groupBox1.Controls.Add(lblSituacaoAtendimento);
            groupBox1.Controls.Add(dtpAberturaAtendimento);
            groupBox1.Controls.Add(lblDataAbertura);
            groupBox1.Controls.Add(cbxNomeCliente);
            groupBox1.Controls.Add(lblNomeCliente);
            groupBox1.Controls.Add(txtCodigoCliente);
            groupBox1.Controls.Add(lblCodigoCliente);
            groupBox1.Location = new Point(8, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do cliente";
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(16, 32);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(72, 15);
            lblCodigoCliente.TabIndex = 0;
            lblCodigoCliente.Text = "Cód. Cliente";
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(16, 48);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(80, 23);
            txtCodigoCliente.TabIndex = 1;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(112, 32);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(40, 15);
            lblNomeCliente.TabIndex = 2;
            lblNomeCliente.Text = "Nome";
            // 
            // cbxNomeCliente
            // 
            cbxNomeCliente.FormattingEnabled = true;
            cbxNomeCliente.Location = new Point(112, 48);
            cbxNomeCliente.Name = "cbxNomeCliente";
            cbxNomeCliente.Size = new Size(344, 23);
            cbxNomeCliente.TabIndex = 3;
            // 
            // lblDataAbertura
            // 
            lblDataAbertura.AutoSize = true;
            lblDataAbertura.Location = new Point(472, 32);
            lblDataAbertura.Name = "lblDataAbertura";
            lblDataAbertura.Size = new Size(80, 15);
            lblDataAbertura.TabIndex = 4;
            lblDataAbertura.Text = "Data Abertura";
            // 
            // dtpAberturaAtendimento
            // 
            dtpAberturaAtendimento.Location = new Point(472, 48);
            dtpAberturaAtendimento.Name = "dtpAberturaAtendimento";
            dtpAberturaAtendimento.Size = new Size(200, 23);
            dtpAberturaAtendimento.TabIndex = 5;
            // 
            // lblSituacaoAtendimento
            // 
            lblSituacaoAtendimento.AutoSize = true;
            lblSituacaoAtendimento.Location = new Point(16, 104);
            lblSituacaoAtendimento.Name = "lblSituacaoAtendimento";
            lblSituacaoAtendimento.Size = new Size(142, 15);
            lblSituacaoAtendimento.TabIndex = 6;
            lblSituacaoAtendimento.Text = "Situação do Atendimento";
            // 
            // cbxSituacaoAtendimento
            // 
            cbxSituacaoAtendimento.FormattingEnabled = true;
            cbxSituacaoAtendimento.Location = new Point(16, 120);
            cbxSituacaoAtendimento.Name = "cbxSituacaoAtendimento";
            cbxSituacaoAtendimento.Size = new Size(240, 23);
            cbxSituacaoAtendimento.TabIndex = 7;
            // 
            // lblObservacaoCliente
            // 
            lblObservacaoCliente.AutoSize = true;
            lblObservacaoCliente.Location = new Point(296, 104);
            lblObservacaoCliente.Name = "lblObservacaoCliente";
            lblObservacaoCliente.Size = new Size(74, 15);
            lblObservacaoCliente.TabIndex = 8;
            lblObservacaoCliente.Text = "Observações";
            // 
            // txtOservacaoAtendimento
            // 
            txtOservacaoAtendimento.Location = new Point(296, 120);
            txtOservacaoAtendimento.Multiline = true;
            txtOservacaoAtendimento.Name = "txtOservacaoAtendimento";
            txtOservacaoAtendimento.Size = new Size(384, 104);
            txtOservacaoAtendimento.TabIndex = 9;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageKey = "icone-editar.png";
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(96, 232);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(72, 32);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Segoe UI", 10F);
            btnFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizar.ImageKey = "icone-finalizar.png";
            btnFinalizar.ImageList = imageList1;
            btnFinalizar.Location = new Point(504, 232);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(176, 32);
            btnFinalizar.TabIndex = 11;
            btnFinalizar.Text = "Finalizar Atendimento";
            btnFinalizar.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-cancelar.png");
            imageList1.Images.SetKeyName(1, "icone-delete.png");
            imageList1.Images.SetKeyName(2, "icone-editar.png");
            imageList1.Images.SetKeyName(3, "icone-novo.png");
            imageList1.Images.SetKeyName(4, "icone-pesquisar.png");
            imageList1.Images.SetKeyName(5, "icone-salvar.png");
            imageList1.Images.SetKeyName(6, "icone-finalizar.png");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(416, 16);
            label6.Name = "label6";
            label6.Size = new Size(171, 32);
            label6.TabIndex = 1;
            label6.Text = "Atendimento:";
            // 
            // txtCodigoAtendimento
            // 
            txtCodigoAtendimento.Font = new Font("Segoe UI", 16F);
            txtCodigoAtendimento.Location = new Point(600, 16);
            txtCodigoAtendimento.Name = "txtCodigoAtendimento";
            txtCodigoAtendimento.Size = new Size(80, 36);
            txtCodigoAtendimento.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExcluirEtapa);
            groupBox2.Controls.Add(btnAdicionarEtapa);
            groupBox2.Controls.Add(dgvEtapasAtendimento);
            groupBox2.Controls.Add(txtEtapaObservacao);
            groupBox2.Controls.Add(lblObservacaoEtapas);
            groupBox2.Controls.Add(cbxEtapaAtendimento);
            groupBox2.Controls.Add(lblEtapadoAtendimento);
            groupBox2.Location = new Point(8, 344);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(688, 264);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Etapas do Atendimento";
            // 
            // lblEtapadoAtendimento
            // 
            lblEtapadoAtendimento.AutoSize = true;
            lblEtapadoAtendimento.Location = new Point(16, 32);
            lblEtapadoAtendimento.Name = "lblEtapadoAtendimento";
            lblEtapadoAtendimento.Size = new Size(126, 15);
            lblEtapadoAtendimento.TabIndex = 0;
            lblEtapadoAtendimento.Text = "Etapa do Atendimento";
            // 
            // cbxEtapaAtendimento
            // 
            cbxEtapaAtendimento.FormattingEnabled = true;
            cbxEtapaAtendimento.Location = new Point(16, 48);
            cbxEtapaAtendimento.Name = "cbxEtapaAtendimento";
            cbxEtapaAtendimento.Size = new Size(296, 23);
            cbxEtapaAtendimento.TabIndex = 1;
            // 
            // lblObservacaoEtapas
            // 
            lblObservacaoEtapas.AutoSize = true;
            lblObservacaoEtapas.Location = new Point(16, 80);
            lblObservacaoEtapas.Name = "lblObservacaoEtapas";
            lblObservacaoEtapas.Size = new Size(74, 15);
            lblObservacaoEtapas.TabIndex = 2;
            lblObservacaoEtapas.Text = "Observações";
            // 
            // txtEtapaObservacao
            // 
            txtEtapaObservacao.Location = new Point(16, 96);
            txtEtapaObservacao.Multiline = true;
            txtEtapaObservacao.Name = "txtEtapaObservacao";
            txtEtapaObservacao.Size = new Size(296, 112);
            txtEtapaObservacao.TabIndex = 3;
            // 
            // dgvEtapasAtendimento
            // 
            dgvEtapasAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtapasAtendimento.Location = new Point(328, 40);
            dgvEtapasAtendimento.Name = "dgvEtapasAtendimento";
            dgvEtapasAtendimento.Size = new Size(352, 208);
            dgvEtapasAtendimento.TabIndex = 4;
            // 
            // btnAdicionarEtapa
            // 
            btnAdicionarEtapa.Font = new Font("Segoe UI", 10F);
            btnAdicionarEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarEtapa.ImageKey = "icone-novo.png";
            btnAdicionarEtapa.ImageList = imageList1;
            btnAdicionarEtapa.Location = new Point(16, 216);
            btnAdicionarEtapa.Name = "btnAdicionarEtapa";
            btnAdicionarEtapa.Size = new Size(136, 32);
            btnAdicionarEtapa.TabIndex = 5;
            btnAdicionarEtapa.Text = "Adicionar Etapa";
            btnAdicionarEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionarEtapa.UseVisualStyleBackColor = true;
            // 
            // btnExcluirEtapa
            // 
            btnExcluirEtapa.Font = new Font("Segoe UI", 10F);
            btnExcluirEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirEtapa.ImageKey = "icone-cancelar.png";
            btnExcluirEtapa.ImageList = imageList1;
            btnExcluirEtapa.Location = new Point(176, 216);
            btnExcluirEtapa.Name = "btnExcluirEtapa";
            btnExcluirEtapa.Size = new Size(120, 32);
            btnExcluirEtapa.TabIndex = 6;
            btnExcluirEtapa.Text = "Excluir Etapa";
            btnExcluirEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirEtapa.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarAtendimento
            // 
            btnPesquisarAtendimento.Font = new Font("Segoe UI", 10F);
            btnPesquisarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisarAtendimento.ImageKey = "icone-pesquisar.png";
            btnPesquisarAtendimento.ImageList = imageList1;
            btnPesquisarAtendimento.Location = new Point(16, 16);
            btnPesquisarAtendimento.Name = "btnPesquisarAtendimento";
            btnPesquisarAtendimento.Size = new Size(176, 32);
            btnPesquisarAtendimento.TabIndex = 12;
            btnPesquisarAtendimento.Text = "Localizar Atendimento";
            btnPesquisarAtendimento.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisarAtendimento.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 10F);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageKey = "icone-salvar.png";
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(176, 232);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(72, 32);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 10F);
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageKey = "icone-delete.png";
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(256, 232);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(72, 32);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 10F);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageKey = "icone-novo.png";
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(16, 232);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(72, 32);
            btnNovo.TabIndex = 14;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageKey = "icone-cancelar.png";
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(336, 232);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 32);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 614);
            Controls.Add(btnPesquisarAtendimento);
            Controls.Add(groupBox2);
            Controls.Add(txtCodigoAtendimento);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "FrmAtendimento";
            Text = "Atendimento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEditar;
        private TextBox txtOservacaoAtendimento;
        private Label lblObservacaoCliente;
        private ComboBox cbxSituacaoAtendimento;
        private Label lblSituacaoAtendimento;
        private DateTimePicker dtpAberturaAtendimento;
        private Label lblDataAbertura;
        private ComboBox cbxNomeCliente;
        private Label lblNomeCliente;
        private TextBox txtCodigoCliente;
        private Label lblCodigoCliente;
        private Button btnFinalizar;
        private ImageList imageList1;
        private Label label6;
        private TextBox txtCodigoAtendimento;
        private GroupBox groupBox2;
        private ComboBox cbxEtapaAtendimento;
        private Label lblEtapadoAtendimento;
        private Button btnExcluirEtapa;
        private Button btnAdicionarEtapa;
        private DataGridView dgvEtapasAtendimento;
        private TextBox txtEtapaObservacao;
        private Label lblObservacaoEtapas;
        private Button btnPesquisarAtendimento;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}