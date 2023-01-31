namespace sistema_Aula
{
    partial class cadprodutos
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
            this.btvoltar = new System.Windows.Forms.Button();
            this.btvisualizar = new System.Windows.Forms.Button();
            this.Qtd_Estoque = new System.Windows.Forms.ComboBox();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Preco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tipo_produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome_produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btvoltar
            // 
            this.btvoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.Location = new System.Drawing.Point(106, 210);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(136, 35);
            this.btvoltar.TabIndex = 38;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            // 
            // btvisualizar
            // 
            this.btvisualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvisualizar.Location = new System.Drawing.Point(106, 253);
            this.btvisualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btvisualizar.Name = "btvisualizar";
            this.btvisualizar.Size = new System.Drawing.Size(421, 37);
            this.btvisualizar.TabIndex = 37;
            this.btvisualizar.Text = "Visualizar";
            this.btvisualizar.UseVisualStyleBackColor = true;
            // 
            // Qtd_Estoque
            // 
            this.Qtd_Estoque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qtd_Estoque.FormattingEnabled = true;
            this.Qtd_Estoque.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.Qtd_Estoque.Location = new System.Drawing.Point(163, 154);
            this.Qtd_Estoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Qtd_Estoque.Name = "Qtd_Estoque";
            this.Qtd_Estoque.Size = new System.Drawing.Size(364, 25);
            this.Qtd_Estoque.TabIndex = 36;
            // 
            // btcancelar
            // 
            this.btcancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Location = new System.Drawing.Point(249, 210);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(141, 37);
            this.btcancelar.TabIndex = 35;
            this.btcancelar.Text = "Cancelar ";
            this.btcancelar.UseVisualStyleBackColor = true;
            // 
            // btcadastrar
            // 
            this.btcadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.Location = new System.Drawing.Point(398, 210);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(129, 37);
            this.btcadastrar.TabIndex = 34;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Quantidade Est";
            // 
            // Preco
            // 
            this.Preco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preco.Location = new System.Drawing.Point(163, 116);
            this.Preco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(364, 23);
            this.Preco.TabIndex = 32;
            this.Preco.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Preço";
            // 
            // Tipo_produto
            // 
            this.Tipo_produto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo_produto.Location = new System.Drawing.Point(163, 78);
            this.Tipo_produto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tipo_produto.Name = "Tipo_produto";
            this.Tipo_produto.Size = new System.Drawing.Size(364, 23);
            this.Tipo_produto.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tipo de Produto ";
            // 
            // Nome_produto
            // 
            this.Nome_produto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_produto.Location = new System.Drawing.Point(163, 42);
            this.Nome_produto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nome_produto.Name = "Nome_produto";
            this.Nome_produto.Size = new System.Drawing.Size(364, 23);
            this.Nome_produto.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome do Produto ";
            // 
            // cadprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 332);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btvisualizar);
            this.Controls.Add(this.Qtd_Estoque);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Preco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tipo_produto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome_produto);
            this.Controls.Add(this.label1);
            this.Name = "cadprodutos";
            this.Text = "cadprodutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btvisualizar;
        private System.Windows.Forms.ComboBox Qtd_Estoque;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Preco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tipo_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nome_produto;
        private System.Windows.Forms.Label label1;
    }
}