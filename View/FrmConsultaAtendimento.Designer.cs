namespace SistemaAtendimento.View
{
    partial class FrmConsultaAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaAtendimento));
            groupBox1 = new GroupBox();
            cbxConsultaAtendimento = new ComboBox();
            txtConsultaAtendimento = new TextBox();
            btnBuscarConsultaAtendimento = new Button();
            imageList1 = new ImageList(components);
            dgvConsultaAtendimento = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvConsultaAtendimento);
            groupBox1.Controls.Add(btnBuscarConsultaAtendimento);
            groupBox1.Controls.Add(txtConsultaAtendimento);
            groupBox1.Controls.Add(cbxConsultaAtendimento);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 432);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Por";
            // 
            // cbxConsultaAtendimento
            // 
            cbxConsultaAtendimento.FormattingEnabled = true;
            cbxConsultaAtendimento.Items.AddRange(new object[] { "Código do Atendimento", "Nome do Cliente", "CPF", "CNPJ" });
            cbxConsultaAtendimento.Location = new Point(16, 32);
            cbxConsultaAtendimento.Name = "cbxConsultaAtendimento";
            cbxConsultaAtendimento.Size = new Size(176, 23);
            cbxConsultaAtendimento.TabIndex = 0;
            // 
            // txtConsultaAtendimento
            // 
            txtConsultaAtendimento.Location = new Point(208, 32);
            txtConsultaAtendimento.Name = "txtConsultaAtendimento";
            txtConsultaAtendimento.Size = new Size(312, 23);
            txtConsultaAtendimento.TabIndex = 1;
            // 
            // btnBuscarConsultaAtendimento
            // 
            btnBuscarConsultaAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarConsultaAtendimento.ImageKey = "icone-pesquisar.png";
            btnBuscarConsultaAtendimento.ImageList = imageList1;
            btnBuscarConsultaAtendimento.Location = new Point(536, 32);
            btnBuscarConsultaAtendimento.Name = "btnBuscarConsultaAtendimento";
            btnBuscarConsultaAtendimento.Size = new Size(128, 23);
            btnBuscarConsultaAtendimento.TabIndex = 2;
            btnBuscarConsultaAtendimento.Text = "Pesquisar";
            btnBuscarConsultaAtendimento.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-cancelar.png");
            imageList1.Images.SetKeyName(1, "icone-delete.png");
            imageList1.Images.SetKeyName(2, "icone-editar.png");
            imageList1.Images.SetKeyName(3, "icone-finalizar.png");
            imageList1.Images.SetKeyName(4, "icone-novo.png");
            imageList1.Images.SetKeyName(5, "icone-pesquisar.png");
            imageList1.Images.SetKeyName(6, "icone-salvar.png");
            // 
            // dgvConsultaAtendimento
            // 
            dgvConsultaAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaAtendimento.Location = new Point(16, 80);
            dgvConsultaAtendimento.Name = "dgvConsultaAtendimento";
            dgvConsultaAtendimento.Size = new Size(664, 344);
            dgvConsultaAtendimento.TabIndex = 3;
            // 
            // FrmConsultaAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(groupBox1);
            Name = "FrmConsultaAtendimento";
            Text = "Consulta de Atendimento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBuscarConsultaAtendimento;
        private ImageList imageList1;
        private TextBox txtConsultaAtendimento;
        private ComboBox cbxConsultaAtendimento;
        private DataGridView dgvConsultaAtendimento;
    }
}