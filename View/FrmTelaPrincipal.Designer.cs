namespace SistemaAtendimento
{
    partial class FrmTelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuTelaPrincipal = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            etapasToolStripMenuItem = new ToolStripMenuItem();
            statusAtendimentosToolStripMenuItem = new ToolStripMenuItem();
            atendimentoToolStripMenuItem = new ToolStripMenuItem();
            novoAtendimentoToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            sistemasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            mnuTelaPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuTelaPrincipal
            // 
            mnuTelaPrincipal.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, atendimentoToolStripMenuItem, sistemasToolStripMenuItem });
            mnuTelaPrincipal.Location = new Point(0, 0);
            mnuTelaPrincipal.Name = "mnuTelaPrincipal";
            mnuTelaPrincipal.Size = new Size(800, 24);
            mnuTelaPrincipal.TabIndex = 0;
            mnuTelaPrincipal.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, usuáriosToolStripMenuItem, etapasToolStripMenuItem, statusAtendimentosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(184, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(184, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // etapasToolStripMenuItem
            // 
            etapasToolStripMenuItem.Name = "etapasToolStripMenuItem";
            etapasToolStripMenuItem.Size = new Size(184, 22);
            etapasToolStripMenuItem.Text = "Etapas";
            // 
            // statusAtendimentosToolStripMenuItem
            // 
            statusAtendimentosToolStripMenuItem.Name = "statusAtendimentosToolStripMenuItem";
            statusAtendimentosToolStripMenuItem.Size = new Size(184, 22);
            statusAtendimentosToolStripMenuItem.Text = "Status Atendimentos";
            // 
            // atendimentoToolStripMenuItem
            // 
            atendimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoAtendimentoToolStripMenuItem, consultasToolStripMenuItem });
            atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            atendimentoToolStripMenuItem.Size = new Size(89, 20);
            atendimentoToolStripMenuItem.Text = "Atendimento";
            // 
            // novoAtendimentoToolStripMenuItem
            // 
            novoAtendimentoToolStripMenuItem.Name = "novoAtendimentoToolStripMenuItem";
            novoAtendimentoToolStripMenuItem.Size = new Size(176, 22);
            novoAtendimentoToolStripMenuItem.Text = "Novo Atendimento";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(176, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // sistemasToolStripMenuItem
            // 
            sistemasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            sistemasToolStripMenuItem.Size = new Size(65, 20);
            sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuTelaPrincipal);
            MainMenuStrip = mnuTelaPrincipal;
            Name = "FrmTelaPrincipal";
            Text = "Sistema de Atendimento";
            mnuTelaPrincipal.ResumeLayout(false);
            mnuTelaPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuTelaPrincipal;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem etapasToolStripMenuItem;
        private ToolStripMenuItem statusAtendimentosToolStripMenuItem;
        private ToolStripMenuItem atendimentoToolStripMenuItem;
        private ToolStripMenuItem sistemasToolStripMenuItem;
        private ToolStripMenuItem novoAtendimentoToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
