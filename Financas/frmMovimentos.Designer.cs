namespace Financas
{
    partial class frmMovimentos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdMovimentos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gbxMovimentos = new System.Windows.Forms.GroupBox();
            this.btnIncluirMovimento = new System.Windows.Forms.Button();
            this.btnAlterarMovimento = new System.Windows.Forms.Button();
            this.btnExcluirMovimento = new System.Windows.Forms.Button();
            this.lblObs = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovimentos)).BeginInit();
            this.gbxMovimentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMovimentos,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miMovimentos
            // 
            this.miMovimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.saídasToolStripMenuItem,
            this.saídasToolStripMenuItem1});
            this.miMovimentos.Name = "miMovimentos";
            this.miMovimentos.Size = new System.Drawing.Size(86, 20);
            this.miMovimentos.Text = "Movimentos";
            this.miMovimentos.Click += new System.EventHandler(this.miMovimentos_Click);
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entradaToolStripMenuItem.Text = "Novo";
            // 
            // saídasToolStripMenuItem
            // 
            this.saídasToolStripMenuItem.Name = "saídasToolStripMenuItem";
            this.saídasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saídasToolStripMenuItem.Text = "Entradas";
            // 
            // saídasToolStripMenuItem1
            // 
            this.saídasToolStripMenuItem1.Name = "saídasToolStripMenuItem1";
            this.saídasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saídasToolStripMenuItem1.Text = "Saídas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // grdMovimentos
            // 
            this.grdMovimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovimentos.Location = new System.Drawing.Point(38, 143);
            this.grdMovimentos.Name = "grdMovimentos";
            this.grdMovimentos.Size = new System.Drawing.Size(414, 150);
            this.grdMovimentos.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(35, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(185, 44);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(312, 44);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(79, 41);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(224, 41);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(69, 20);
            this.mskData.TabIndex = 6;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(352, 41);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 7;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(373, 114);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // gbxMovimentos
            // 
            this.gbxMovimentos.Controls.Add(this.richTextBox1);
            this.gbxMovimentos.Controls.Add(this.lblData);
            this.gbxMovimentos.Controls.Add(this.mskData);
            this.gbxMovimentos.Controls.Add(this.txtValor);
            this.gbxMovimentos.Controls.Add(this.txtTitulo);
            this.gbxMovimentos.Controls.Add(this.lblTitulo);
            this.gbxMovimentos.Controls.Add(this.lblObs);
            this.gbxMovimentos.Controls.Add(this.lblValor);
            this.gbxMovimentos.Controls.Add(this.btnExcluirMovimento);
            this.gbxMovimentos.Controls.Add(this.btnPesquisar);
            this.gbxMovimentos.Controls.Add(this.btnAlterarMovimento);
            this.gbxMovimentos.Controls.Add(this.btnIncluirMovimento);
            this.gbxMovimentos.Controls.Add(this.grdMovimentos);
            this.gbxMovimentos.Location = new System.Drawing.Point(12, 27);
            this.gbxMovimentos.Name = "gbxMovimentos";
            this.gbxMovimentos.Size = new System.Drawing.Size(493, 320);
            this.gbxMovimentos.TabIndex = 9;
            this.gbxMovimentos.TabStop = false;
            // 
            // btnIncluirMovimento
            // 
            this.btnIncluirMovimento.Location = new System.Drawing.Point(38, 114);
            this.btnIncluirMovimento.Name = "btnIncluirMovimento";
            this.btnIncluirMovimento.Size = new System.Drawing.Size(105, 23);
            this.btnIncluirMovimento.TabIndex = 10;
            this.btnIncluirMovimento.Text = "Incluir Movimento";
            this.btnIncluirMovimento.UseVisualStyleBackColor = true;
            // 
            // btnAlterarMovimento
            // 
            this.btnAlterarMovimento.Location = new System.Drawing.Point(149, 114);
            this.btnAlterarMovimento.Name = "btnAlterarMovimento";
            this.btnAlterarMovimento.Size = new System.Drawing.Size(106, 23);
            this.btnAlterarMovimento.TabIndex = 11;
            this.btnAlterarMovimento.Text = "Alterar Movimento";
            this.btnAlterarMovimento.UseVisualStyleBackColor = true;
            // 
            // btnExcluirMovimento
            // 
            this.btnExcluirMovimento.Location = new System.Drawing.Point(261, 114);
            this.btnExcluirMovimento.Name = "btnExcluirMovimento";
            this.btnExcluirMovimento.Size = new System.Drawing.Size(106, 23);
            this.btnExcluirMovimento.TabIndex = 12;
            this.btnExcluirMovimento.Text = "Excluir Movimento";
            this.btnExcluirMovimento.UseVisualStyleBackColor = true;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(35, 72);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(73, 13);
            this.lblObs.TabIndex = 10;
            this.lblObs.Text = "Observações:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(114, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(239, 40);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // frmMovimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 359);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbxMovimentos);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMovimentos";
            this.Text = "Movimentos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovimentos)).EndInit();
            this.gbxMovimentos.ResumeLayout(false);
            this.gbxMovimentos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miMovimentos;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdMovimentos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gbxMovimentos;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Button btnExcluirMovimento;
        private System.Windows.Forms.Button btnAlterarMovimento;
        private System.Windows.Forms.Button btnIncluirMovimento;
    }
}

