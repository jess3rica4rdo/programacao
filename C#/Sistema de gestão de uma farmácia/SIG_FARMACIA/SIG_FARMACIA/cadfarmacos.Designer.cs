namespace SIG_FARMACIA
{
    partial class cadfarmacos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadfarmacos));
            this.label7 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btvoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txteliminar = new System.Windows.Forms.TextBox();
            this.bteliminar = new System.Windows.Forms.Button();
            this.txtstockminmo = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.datadridpp = new System.Windows.Forms.DataGridView();
            this.btactualizar = new System.Windows.Forms.Button();
            this.btadicionar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combofornecedor = new System.Windows.Forms.ComboBox();
            this.combocategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadridpp)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 141;
            this.label7.Text = "Descrição";
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.White;
            this.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_desc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_desc.Location = new System.Drawing.Point(173, 441);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(265, 23);
            this.txt_desc.TabIndex = 140;
            // 
            // btvoltar
            // 
            this.btvoltar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btvoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.ForeColor = System.Drawing.Color.White;
            this.btvoltar.Location = new System.Drawing.Point(-1, 2);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(116, 30);
            this.btvoltar.TabIndex = 139;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = false;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 23);
            this.label2.TabIndex = 138;
            this.label2.Text = "CADASTRAMENTO DE FÁRMACOS ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txteliminar);
            this.groupBox1.Controls.Add(this.bteliminar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(599, 531);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 56);
            this.groupBox1.TabIndex = 137;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Produtos";
            // 
            // txteliminar
            // 
            this.txteliminar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteliminar.Location = new System.Drawing.Point(247, 19);
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(389, 28);
            this.txteliminar.TabIndex = 88;
            // 
            // bteliminar
            // 
            this.bteliminar.BackColor = System.Drawing.Color.Gray;
            this.bteliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.ForeColor = System.Drawing.Color.White;
            this.bteliminar.Location = new System.Drawing.Point(6, 19);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(233, 31);
            this.bteliminar.TabIndex = 86;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = false;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // txtstockminmo
            // 
            this.txtstockminmo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockminmo.FormattingEnabled = true;
            this.txtstockminmo.Items.AddRange(new object[] {
            "20",
            "40",
            "50"});
            this.txtstockminmo.Location = new System.Drawing.Point(176, 334);
            this.txtstockminmo.Name = "txtstockminmo";
            this.txtstockminmo.Size = new System.Drawing.Size(265, 25);
            this.txtstockminmo.TabIndex = 136;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(846, 497);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(400, 28);
            this.txtPesquisa.TabIndex = 135;
            // 
            // btpesquisar
            // 
            this.btpesquisar.BackColor = System.Drawing.Color.Gray;
            this.btpesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.ForeColor = System.Drawing.Color.White;
            this.btpesquisar.Location = new System.Drawing.Point(599, 497);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(239, 34);
            this.btpesquisar.TabIndex = 134;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = false;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Red;
            this.btcancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.White;
            this.btcancelar.Location = new System.Drawing.Point(43, 497);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(188, 36);
            this.btcancelar.TabIndex = 133;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // datadridpp
            // 
            this.datadridpp.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.datadridpp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datadridpp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadridpp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datadridpp.Location = new System.Drawing.Point(447, 2);
            this.datadridpp.Name = "datadridpp";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.datadridpp.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datadridpp.Size = new System.Drawing.Size(823, 462);
            this.datadridpp.TabIndex = 132;
            // 
            // btactualizar
            // 
            this.btactualizar.BackColor = System.Drawing.Color.Gray;
            this.btactualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btactualizar.ForeColor = System.Drawing.Color.White;
            this.btactualizar.Location = new System.Drawing.Point(43, 534);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(384, 47);
            this.btactualizar.TabIndex = 131;
            this.btactualizar.Text = "Actualizar";
            this.btactualizar.UseVisualStyleBackColor = false;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
            // 
            // btadicionar
            // 
            this.btadicionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btadicionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadicionar.ForeColor = System.Drawing.Color.White;
            this.btadicionar.Location = new System.Drawing.Point(239, 497);
            this.btadicionar.Name = "btadicionar";
            this.btadicionar.Size = new System.Drawing.Size(188, 36);
            this.btadicionar.TabIndex = 130;
            this.btadicionar.Text = "Adicionar ";
            this.btadicionar.UseVisualStyleBackColor = false;
            this.btadicionar.Click += new System.EventHandler(this.btadicionar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(60, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 21);
            this.label9.TabIndex = 129;
            this.label9.Text = "Fornecedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(53, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 21);
            this.label8.TabIndex = 128;
            this.label8.Text = "Stock Minimo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 127;
            this.label3.Text = "Quantidade";
            // 
            // combofornecedor
            // 
            this.combofornecedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combofornecedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combofornecedor.FormattingEnabled = true;
            this.combofornecedor.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.combofornecedor.Items.AddRange(new object[] {
            "Shalina ",
            "Mozel ",
            "Única ",
            "Mia Farma ",
            "Deposito MD",
            "Farmácia Central Kilamba"});
            this.combofornecedor.Location = new System.Drawing.Point(176, 367);
            this.combofornecedor.Name = "combofornecedor";
            this.combofornecedor.Size = new System.Drawing.Size(265, 25);
            this.combofornecedor.TabIndex = 125;
            // 
            // combocategoria
            // 
            this.combocategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combocategoria.FormattingEnabled = true;
            this.combocategoria.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.combocategoria.Items.AddRange(new object[] {
            "Anti-Infeccioso",
            "Anti-Inflamátorio ",
            "Anti-Maláricos",
            "Anti-Fúngicos",
            "Nutrição ",
            "Aparelho Digestivo ",
            " "});
            this.combocategoria.Location = new System.Drawing.Point(176, 220);
            this.combocategoria.Name = "combocategoria";
            this.combocategoria.Size = new System.Drawing.Size(265, 25);
            this.combocategoria.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 124;
            this.label6.Text = "Categoria";
            // 
            // txtquantidade
            // 
            this.txtquantidade.BackColor = System.Drawing.Color.White;
            this.txtquantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquantidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtquantidade.Location = new System.Drawing.Point(176, 295);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(265, 23);
            this.txtquantidade.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(109, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 122;
            this.label5.Text = "Preço";
            // 
            // txtpreco
            // 
            this.txtpreco.BackColor = System.Drawing.Color.White;
            this.txtpreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpreco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtpreco.Location = new System.Drawing.Point(176, 258);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(265, 23);
            this.txtpreco.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 120;
            this.label4.Text = "Data do Registro";
            // 
            // txtdata
            // 
            this.txtdata.BackColor = System.Drawing.Color.White;
            this.txtdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdata.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtdata.Location = new System.Drawing.Point(176, 404);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(265, 23);
            this.txtdata.TabIndex = 118;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(176, 185);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 23);
            this.txtNome.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 117;
            this.label1.Text = "Nome do Farmáco";
            // 
            // cadfarmacos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1270, 592);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtstockminmo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.datadridpp);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.btadicionar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combofornecedor);
            this.Controls.Add(this.combocategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "cadfarmacos";
            this.Text = "cadfarmacos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadridpp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txteliminar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.ComboBox txtstockminmo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.DataGridView datadridpp;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.Button btadicionar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combofornecedor;
        private System.Windows.Forms.ComboBox combocategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
    }
}