namespace aula
{
    partial class prncipal
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
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuusuario = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semanalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.produtosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.cadastrosToolStripMenuItem.Text = "Cadastros ";
            // 
            // menuusuario
            // 
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(166, 22);
            this.menuusuario.Text = "Usuarios ";
            this.menuusuario.Click += new System.EventHandler(this.menuusuario_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.produtosToolStripMenuItem.Text = "Produtos ";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores ";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.vendasToolStripMenuItem.Text = "Vendas ";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diárioToolStripMenuItem,
            this.semanalToolStripMenuItem,
            this.mensalToolStripMenuItem,
            this.anualToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.relatóriosToolStripMenuItem.Text = "Relatórios ";
            // 
            // diárioToolStripMenuItem
            // 
            this.diárioToolStripMenuItem.Name = "diárioToolStripMenuItem";
            this.diárioToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.diárioToolStripMenuItem.Text = "Diário";
            // 
            // semanalToolStripMenuItem
            // 
            this.semanalToolStripMenuItem.Name = "semanalToolStripMenuItem";
            this.semanalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.semanalToolStripMenuItem.Text = "Semanal ";
            // 
            // mensalToolStripMenuItem
            // 
            this.mensalToolStripMenuItem.Name = "mensalToolStripMenuItem";
            this.mensalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.mensalToolStripMenuItem.Text = "Mensal ";
            // 
            // anualToolStripMenuItem
            // 
            this.anualToolStripMenuItem.Name = "anualToolStripMenuItem";
            this.anualToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.anualToolStripMenuItem.Text = "Anual ";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.ajudaToolStripMenuItem.Text = "Ajuda ";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.logoutToolStripMenuItem.Text = "logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // prncipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "prncipal";
            this.Text = "prncipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuusuario;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semanalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}