namespace aula
{
    partial class cadusuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomecompleto = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.combfun = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btvisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo ";
            // 
            // txtnomecompleto
            // 
            this.txtnomecompleto.Location = new System.Drawing.Point(230, 33);
            this.txtnomecompleto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnomecompleto.Name = "txtnomecompleto";
            this.txtnomecompleto.Size = new System.Drawing.Size(292, 23);
            this.txtnomecompleto.TabIndex = 1;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(230, 81);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(292, 23);
            this.txt_usuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario ";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(230, 126);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(292, 23);
            this.txt_senha.TabIndex = 5;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Função ";
            // 
            // btcadastrar
            // 
            this.btcadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.Location = new System.Drawing.Point(367, 238);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(155, 30);
            this.btcadastrar.TabIndex = 8;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Location = new System.Drawing.Point(162, 238);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(171, 30);
            this.btcancelar.TabIndex = 9;
            this.btcancelar.Text = "Cancelar ";
            this.btcancelar.UseVisualStyleBackColor = true;
            // 
            // combfun
            // 
            this.combfun.FormattingEnabled = true;
            this.combfun.Items.AddRange(new object[] {
            "Adm",
            "Operador de caixa"});
            this.combfun.Location = new System.Drawing.Point(230, 170);
            this.combfun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combfun.Name = "combfun";
            this.combfun.Size = new System.Drawing.Size(292, 25);
            this.combfun.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 321);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 134);
            this.dataGridView1.TabIndex = 11;
            // 
            // btvisualizar
            // 
            this.btvisualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvisualizar.Location = new System.Drawing.Point(162, 276);
            this.btvisualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btvisualizar.Name = "btvisualizar";
            this.btvisualizar.Size = new System.Drawing.Size(360, 30);
            this.btvisualizar.TabIndex = 12;
            this.btvisualizar.Text = "Visualizar";
            this.btvisualizar.UseVisualStyleBackColor = true;
            this.btvisualizar.Click += new System.EventHandler(this.btvisualizar_Click);
            // 
            // cadusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 452);
            this.Controls.Add(this.btvisualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combfun);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnomecompleto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cadusuario";
            this.Text = "cadastros";
            this.Load += new System.EventHandler(this.cadusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomecompleto;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.ComboBox combfun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btvisualizar;

    }
}