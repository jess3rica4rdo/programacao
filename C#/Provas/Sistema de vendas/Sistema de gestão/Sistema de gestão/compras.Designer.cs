namespace Sistema_de_gestão
{
    partial class compras
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label13 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            comb_tipodocumento = new ComboBox();
            txt_data = new TextBox();
            groupBox2 = new GroupBox();
            btn_pesquisarfornecedor = new FontAwesome.Sharp.IconButton();
            txt_idfornecedor = new TextBox();
            txt_razaosocial = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_nif = new TextBox();
            groupBox3 = new GroupBox();
            numeric_quantiidade = new NumericUpDown();
            btn_pesquisarproduto = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            label9 = new Label();
            txt_precocompra = new TextBox();
            txt_idproduto = new TextBox();
            txt_produto = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_codproduto = new TextBox();
            txt_adicionar = new FontAwesome.Sharp.IconButton();
            dgvcompra = new DataGridView();
            nome_produto = new DataGridViewTextBoxColumn();
            fornecedor = new DataGridViewTextBoxColumn();
            preco_compra = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            tipo_documento = new DataGridViewTextBoxColumn();
            registrado_por = new DataGridViewTextBoxColumn();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label11 = new Label();
            btn_registrar = new FontAwesome.Sharp.IconButton();
            txt_valortotal = new TextBox();
            txt_nomeusuario = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_quantiidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvcompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.SteelBlue;
            label13.Location = new Point(304, 74);
            label13.Name = "label13";
            label13.Size = new Size(248, 24);
            label13.TabIndex = 24;
            label13.Text = "REGISTRAR COMPRAS";
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(205, 45);
            label7.Name = "label7";
            label7.Size = new Size(926, 539);
            label7.TabIndex = 23;
            label7.Text = " ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comb_tipodocumento);
            groupBox1.Controls.Add(txt_data);
            groupBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(245, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 91);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da compra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 30;
            label1.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(153, 30);
            label2.Name = "label2";
            label2.Size = new Size(140, 17);
            label2.TabIndex = 29;
            label2.Text = "Tipo de documento:";
            // 
            // comb_tipodocumento
            // 
            comb_tipodocumento.BackColor = Color.White;
            comb_tipodocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            comb_tipodocumento.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comb_tipodocumento.FormattingEnabled = true;
            comb_tipodocumento.Location = new Point(153, 48);
            comb_tipodocumento.Name = "comb_tipodocumento";
            comb_tipodocumento.Size = new Size(222, 25);
            comb_tipodocumento.TabIndex = 28;
            // 
            // txt_data
            // 
            txt_data.BackColor = Color.WhiteSmoke;
            txt_data.BorderStyle = BorderStyle.FixedSingle;
            txt_data.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_data.Location = new Point(6, 50);
            txt_data.Name = "txt_data";
            txt_data.Size = new Size(132, 22);
            txt_data.TabIndex = 27;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btn_pesquisarfornecedor);
            groupBox2.Controls.Add(txt_idfornecedor);
            groupBox2.Controls.Add(txt_razaosocial);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_nif);
            groupBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(667, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 91);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do fornecedor";
            // 
            // btn_pesquisarfornecedor
            // 
            btn_pesquisarfornecedor.BackColor = Color.SteelBlue;
            btn_pesquisarfornecedor.Cursor = Cursors.Hand;
            btn_pesquisarfornecedor.FlatAppearance.BorderColor = Color.Black;
            btn_pesquisarfornecedor.FlatStyle = FlatStyle.Flat;
            btn_pesquisarfornecedor.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pesquisarfornecedor.ForeColor = Color.White;
            btn_pesquisarfornecedor.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_pesquisarfornecedor.IconColor = Color.Green;
            btn_pesquisarfornecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_pesquisarfornecedor.IconSize = 16;
            btn_pesquisarfornecedor.Location = new Point(316, 48);
            btn_pesquisarfornecedor.Name = "btn_pesquisarfornecedor";
            btn_pesquisarfornecedor.Size = new Size(98, 22);
            btn_pesquisarfornecedor.TabIndex = 51;
            btn_pesquisarfornecedor.Text = "Pesquisar";
            btn_pesquisarfornecedor.UseVisualStyleBackColor = false;
            btn_pesquisarfornecedor.Click += btn_pesquisarfornecedor_Click;
            // 
            // txt_idfornecedor
            // 
            txt_idfornecedor.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idfornecedor.Location = new Point(383, 20);
            txt_idfornecedor.Name = "txt_idfornecedor";
            txt_idfornecedor.Size = new Size(31, 22);
            txt_idfornecedor.TabIndex = 46;
            txt_idfornecedor.Visible = false;
            // 
            // txt_razaosocial
            // 
            txt_razaosocial.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_razaosocial.Location = new Point(151, 48);
            txt_razaosocial.Name = "txt_razaosocial";
            txt_razaosocial.Size = new Size(159, 22);
            txt_razaosocial.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 30);
            label3.Name = "label3";
            label3.Size = new Size(31, 17);
            label3.TabIndex = 30;
            label3.Text = "NIF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(150, 30);
            label4.Name = "label4";
            label4.Size = new Size(95, 17);
            label4.TabIndex = 29;
            label4.Text = "Razão Social:";
            // 
            // txt_nif
            // 
            txt_nif.BackColor = Color.WhiteSmoke;
            txt_nif.BorderStyle = BorderStyle.FixedSingle;
            txt_nif.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nif.Location = new Point(10, 48);
            txt_nif.Name = "txt_nif";
            txt_nif.Size = new Size(132, 22);
            txt_nif.TabIndex = 27;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(numeric_quantiidade);
            groupBox3.Controls.Add(btn_pesquisarproduto);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txt_precocompra);
            groupBox3.Controls.Add(txt_idproduto);
            groupBox3.Controls.Add(txt_produto);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txt_codproduto);
            groupBox3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(245, 228);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(722, 93);
            groupBox3.TabIndex = 47;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dados do Produto";
            // 
            // numeric_quantiidade
            // 
            numeric_quantiidade.Location = new Point(596, 51);
            numeric_quantiidade.Name = "numeric_quantiidade";
            numeric_quantiidade.Size = new Size(95, 23);
            numeric_quantiidade.TabIndex = 52;
            numeric_quantiidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_pesquisarproduto
            // 
            btn_pesquisarproduto.BackColor = Color.SteelBlue;
            btn_pesquisarproduto.Cursor = Cursors.Hand;
            btn_pesquisarproduto.FlatAppearance.BorderColor = Color.Black;
            btn_pesquisarproduto.FlatStyle = FlatStyle.Flat;
            btn_pesquisarproduto.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pesquisarproduto.ForeColor = Color.White;
            btn_pesquisarproduto.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_pesquisarproduto.IconColor = Color.Green;
            btn_pesquisarproduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_pesquisarproduto.IconSize = 16;
            btn_pesquisarproduto.Location = new Point(320, 52);
            btn_pesquisarproduto.Name = "btn_pesquisarproduto";
            btn_pesquisarproduto.Size = new Size(109, 22);
            btn_pesquisarproduto.TabIndex = 47;
            btn_pesquisarproduto.Text = "Pesquisar";
            btn_pesquisarproduto.UseVisualStyleBackColor = false;
            btn_pesquisarproduto.Click += btn_pesquisarproduto_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(596, 33);
            label10.Name = "label10";
            label10.Size = new Size(87, 17);
            label10.TabIndex = 50;
            label10.Text = "Quantidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(459, 33);
            label9.Name = "label9";
            label9.Size = new Size(105, 17);
            label9.TabIndex = 48;
            label9.Text = "Preço compra:";
            // 
            // txt_precocompra
            // 
            txt_precocompra.BorderStyle = BorderStyle.FixedSingle;
            txt_precocompra.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_precocompra.Location = new Point(459, 52);
            txt_precocompra.Name = "txt_precocompra";
            txt_precocompra.Size = new Size(125, 22);
            txt_precocompra.TabIndex = 48;
            // 
            // txt_idproduto
            // 
            txt_idproduto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idproduto.Location = new Point(398, 22);
            txt_idproduto.Name = "txt_idproduto";
            txt_idproduto.Size = new Size(31, 22);
            txt_idproduto.TabIndex = 46;
            txt_idproduto.Visible = false;
            // 
            // txt_produto
            // 
            txt_produto.BackColor = Color.WhiteSmoke;
            txt_produto.BorderStyle = BorderStyle.FixedSingle;
            txt_produto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_produto.Location = new Point(162, 51);
            txt_produto.Name = "txt_produto";
            txt_produto.Size = new Size(152, 22);
            txt_produto.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(4, 33);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 30;
            label5.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(162, 33);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 29;
            label6.Text = "Produto:";
            // 
            // txt_codproduto
            // 
            txt_codproduto.BorderStyle = BorderStyle.FixedSingle;
            txt_codproduto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codproduto.Location = new Point(6, 51);
            txt_codproduto.Name = "txt_codproduto";
            txt_codproduto.Size = new Size(150, 22);
            txt_codproduto.TabIndex = 27;
            // 
            // txt_adicionar
            // 
            txt_adicionar.BackColor = Color.LimeGreen;
            txt_adicionar.Cursor = Cursors.Hand;
            txt_adicionar.FlatAppearance.BorderColor = Color.Black;
            txt_adicionar.FlatStyle = FlatStyle.Flat;
            txt_adicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_adicionar.ForeColor = Color.White;
            txt_adicionar.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            txt_adicionar.IconColor = Color.White;
            txt_adicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            txt_adicionar.IconSize = 40;
            txt_adicionar.Location = new Point(991, 237);
            txt_adicionar.Name = "txt_adicionar";
            txt_adicionar.Size = new Size(104, 84);
            txt_adicionar.TabIndex = 51;
            txt_adicionar.Text = "ADICIONAR";
            txt_adicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            txt_adicionar.UseVisualStyleBackColor = false;
            txt_adicionar.Click += txt_adicionar_Click;
            // 
            // dgvcompra
            // 
            dgvcompra.AllowUserToAddRows = false;
            dgvcompra.AllowUserToOrderColumns = true;
            dgvcompra.BackgroundColor = Color.Silver;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvcompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvcompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcompra.Columns.AddRange(new DataGridViewColumn[] { nome_produto, fornecedor, preco_compra, quantidade, subtotal, data, tipo_documento, registrado_por });
            dgvcompra.GridColor = Color.SteelBlue;
            dgvcompra.Location = new Point(245, 340);
            dgvcompra.MultiSelect = false;
            dgvcompra.Name = "dgvcompra";
            dgvcompra.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvcompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvcompra.RowTemplate.Height = 25;
            dgvcompra.Size = new Size(722, 204);
            dgvcompra.TabIndex = 52;
            // 
            // nome_produto
            // 
            nome_produto.HeaderText = "Produto";
            nome_produto.Name = "nome_produto";
            nome_produto.ReadOnly = true;
            // 
            // fornecedor
            // 
            fornecedor.HeaderText = "Fornecedor";
            fornecedor.Name = "fornecedor";
            fornecedor.ReadOnly = true;
            fornecedor.Visible = false;
            // 
            // preco_compra
            // 
            preco_compra.HeaderText = "Preço de compra";
            preco_compra.Name = "preco_compra";
            preco_compra.ReadOnly = true;
            // 
            // quantidade
            // 
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Subtotal";
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
            // 
            // data
            // 
            data.HeaderText = "Data";
            data.Name = "data";
            data.ReadOnly = true;
            data.Visible = false;
            // 
            // tipo_documento
            // 
            tipo_documento.HeaderText = "Tipo de Documento";
            tipo_documento.Name = "tipo_documento";
            tipo_documento.ReadOnly = true;
            tipo_documento.Visible = false;
            // 
            // registrado_por
            // 
            registrado_por.HeaderText = "Registrado por";
            registrado_por.Name = "registrado_por";
            registrado_por.ReadOnly = true;
            registrado_por.Visible = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 57;
            iconPictureBox1.Location = new Point(238, 60);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(62, 57);
            iconPictureBox1.TabIndex = 53;
            iconPictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(973, 463);
            label11.Name = "label11";
            label11.Size = new Size(100, 17);
            label11.TabIndex = 51;
            label11.Text = "Total a pagar:";
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = Color.FromArgb(0, 192, 0);
            btn_registrar.Cursor = Cursors.Hand;
            btn_registrar.FlatAppearance.BorderColor = Color.Black;
            btn_registrar.FlatStyle = FlatStyle.Flat;
            btn_registrar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_registrar.ForeColor = Color.White;
            btn_registrar.IconChar = FontAwesome.Sharp.IconChar.Coins;
            btn_registrar.IconColor = Color.White;
            btn_registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_registrar.IconSize = 20;
            btn_registrar.Location = new Point(973, 510);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(122, 34);
            btn_registrar.TabIndex = 52;
            btn_registrar.Text = "REGISTRAR";
            btn_registrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // txt_valortotal
            // 
            txt_valortotal.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_valortotal.Location = new Point(973, 483);
            txt_valortotal.Name = "txt_valortotal";
            txt_valortotal.Size = new Size(122, 22);
            txt_valortotal.TabIndex = 51;
            // 
            // txt_nomeusuario
            // 
            txt_nomeusuario.AutoSize = true;
            txt_nomeusuario.BackColor = Color.White;
            txt_nomeusuario.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeusuario.ForeColor = Color.White;
            txt_nomeusuario.Location = new Point(860, 60);
            txt_nomeusuario.Name = "txt_nomeusuario";
            txt_nomeusuario.Size = new Size(98, 17);
            txt_nomeusuario.TabIndex = 31;
            txt_nomeusuario.Text = "Nome usuario";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Firebrick;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderColor = Color.Black;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(923, 520);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(44, 24);
            iconButton2.TabIndex = 52;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1386, 633);
            Controls.Add(iconButton2);
            Controls.Add(txt_nomeusuario);
            Controls.Add(txt_valortotal);
            Controls.Add(btn_registrar);
            Controls.Add(label11);
            Controls.Add(iconPictureBox1);
            Controls.Add(dgvcompra);
            Controls.Add(txt_adicionar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label13);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "compras";
            Text = "compras";
            Load += compras_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_quantiidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvcompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Label label7;
        private GroupBox groupBox1;
        private ComboBox comb_tipodocumento;
        private TextBox txt_data;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private TextBox txt_nif;
        private FontAwesome.Sharp.IconButton btn_pesquisarfornecedor;
        private TextBox txt_idfornecedor;
        private TextBox txt_razaosocial;
        private GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btn_pesquisarproduto;
        private Label label10;
        private Label label9;
        private TextBox txt_precocompra;
        private TextBox txt_idproduto;
        private TextBox txt_produto;
        private Label label5;
        private Label label6;
        private TextBox txt_codproduto;
        private FontAwesome.Sharp.IconButton txt_adicionar;
        private DataGridView dgvcompra;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label11;
        private FontAwesome.Sharp.IconButton btn_registrar;
        private TextBox txt_valortotal;
        private DataGridViewTextBoxColumn cod_produto;
        private NumericUpDown numeric_quantiidade;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label txt_nomeusuario;
        private DataGridViewTextBoxColumn nome_produto;
        private DataGridViewTextBoxColumn fornecedor;
        private DataGridViewTextBoxColumn preco_compra;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn tipo_documento;
        private DataGridViewTextBoxColumn registrado_por;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}