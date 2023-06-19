namespace Sistema_de_gestão
{
    partial class vendas
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
            txt_nomeusuario = new Label();
            btn_registrar = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            dgvcompra = new DataGridView();
            produto = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            preco_venda = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            tipo_documento = new DataGridViewTextBoxColumn();
            registrado_por = new DataGridViewTextBoxColumn();
            txt_adicionar = new FontAwesome.Sharp.IconButton();
            groupBox3 = new GroupBox();
            txt_descricao = new Label();
            txt_precovenda = new TextBox();
            label12 = new Label();
            label4 = new Label();
            txt_estoque = new TextBox();
            numeric_quantiidade = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            txt_idproduto = new TextBox();
            txt_produto = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_codproduto = new TextBox();
            btn_pesquisarproduto = new FontAwesome.Sharp.IconButton();
            groupBox2 = new GroupBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            txt_codcliente = new TextBox();
            btn_pesquisarfornecedor = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txt_nomecliente = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            comb_tipodocumento = new ComboBox();
            txt_data = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label13 = new Label();
            txt_valorcompra = new TextBox();
            txt_valortotal = new TextBox();
            label14 = new Label();
            groupBox4 = new GroupBox();
            txt_troco = new TextBox();
            txt_valorpago = new TextBox();
            label16 = new Label();
            label15 = new Label();
            txt_iva = new TextBox();
            txt_calculo = new Label();
            txt_usu = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvcompra).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_quantiidade).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // txt_nomeusuario
            // 
            txt_nomeusuario.AutoSize = true;
            txt_nomeusuario.BackColor = Color.White;
            txt_nomeusuario.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeusuario.ForeColor = Color.Black;
            txt_nomeusuario.Location = new Point(895, 84);
            txt_nomeusuario.Name = "txt_nomeusuario";
            txt_nomeusuario.Size = new Size(127, 17);
            txt_nomeusuario.TabIndex = 57;
            txt_nomeusuario.Text = "codigo do usuario";
            txt_nomeusuario.Visible = false;
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = Color.FromArgb(0, 192, 0);
            btn_registrar.Cursor = Cursors.Hand;
            btn_registrar.FlatAppearance.BorderColor = Color.Black;
            btn_registrar.FlatStyle = FlatStyle.Flat;
            btn_registrar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_registrar.ForeColor = Color.White;
            btn_registrar.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btn_registrar.IconColor = Color.White;
            btn_registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_registrar.IconSize = 20;
            btn_registrar.Location = new Point(8, 260);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(122, 34);
            btn_registrar.TabIndex = 63;
            btn_registrar.Text = "VENDER";
            btn_registrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(6, 26);
            label11.Name = "label11";
            label11.Size = new Size(124, 17);
            label11.TabIndex = 61;
            label11.Text = "Valor da compra:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 57;
            iconPictureBox1.Location = new Point(267, 44);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(62, 57);
            iconPictureBox1.TabIndex = 65;
            iconPictureBox1.TabStop = false;
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
            dgvcompra.Columns.AddRange(new DataGridViewColumn[] { produto, cliente, preco_venda, quantidade, subtotal, data, tipo_documento, registrado_por });
            dgvcompra.GridColor = Color.SteelBlue;
            dgvcompra.Location = new Point(274, 371);
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
            dgvcompra.TabIndex = 64;
            // 
            // produto
            // 
            produto.HeaderText = "Produto";
            produto.Name = "produto";
            produto.ReadOnly = true;
            // 
            // cliente
            // 
            cliente.HeaderText = "Cliente";
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            cliente.Visible = false;
            // 
            // preco_venda
            // 
            preco_venda.HeaderText = "Preço venda";
            preco_venda.Name = "preco_venda";
            preco_venda.ReadOnly = true;
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
            tipo_documento.HeaderText = "Tipo de documento";
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
            txt_adicionar.Location = new Point(889, 264);
            txt_adicionar.Name = "txt_adicionar";
            txt_adicionar.Size = new Size(104, 81);
            txt_adicionar.TabIndex = 62;
            txt_adicionar.Text = "ADICIONAR";
            txt_adicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            txt_adicionar.UseVisualStyleBackColor = false;
            txt_adicionar.Click += txt_adicionar_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txt_descricao);
            groupBox3.Controls.Add(txt_precovenda);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txt_estoque);
            groupBox3.Controls.Add(numeric_quantiidade);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txt_idproduto);
            groupBox3.Controls.Add(txt_produto);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txt_codproduto);
            groupBox3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(274, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(611, 133);
            groupBox3.TabIndex = 59;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dados do Produto";
            // 
            // txt_descricao
            // 
            txt_descricao.AutoSize = true;
            txt_descricao.BackColor = Color.White;
            txt_descricao.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txt_descricao.ForeColor = Color.Black;
            txt_descricao.Location = new Point(181, 46);
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Size = new Size(0, 16);
            txt_descricao.TabIndex = 75;
            // 
            // txt_precovenda
            // 
            txt_precovenda.BackColor = Color.WhiteSmoke;
            txt_precovenda.BorderStyle = BorderStyle.FixedSingle;
            txt_precovenda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_precovenda.Location = new Point(333, 95);
            txt_precovenda.Name = "txt_precovenda";
            txt_precovenda.Size = new Size(109, 22);
            txt_precovenda.TabIndex = 74;
            txt_precovenda.Text = "0,00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(333, 23);
            label12.Name = "label12";
            label12.Size = new Size(63, 17);
            label12.TabIndex = 56;
            label12.Text = "Estoque:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(181, 22);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 55;
            label4.Text = "Descrição:";
            // 
            // txt_estoque
            // 
            txt_estoque.BackColor = Color.WhiteSmoke;
            txt_estoque.BorderStyle = BorderStyle.FixedSingle;
            txt_estoque.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_estoque.Location = new Point(333, 41);
            txt_estoque.Name = "txt_estoque";
            txt_estoque.Size = new Size(109, 22);
            txt_estoque.TabIndex = 53;
            txt_estoque.Text = "0";
            // 
            // numeric_quantiidade
            // 
            numeric_quantiidade.Location = new Point(473, 70);
            numeric_quantiidade.Name = "numeric_quantiidade";
            numeric_quantiidade.Size = new Size(87, 23);
            numeric_quantiidade.TabIndex = 52;
            numeric_quantiidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numeric_quantiidade.ValueChanged += numeric_quantiidade_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(473, 45);
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
            label9.Location = new Point(333, 75);
            label9.Name = "label9";
            label9.Size = new Size(95, 17);
            label9.TabIndex = 48;
            label9.Text = "Preço venda:";
            // 
            // txt_idproduto
            // 
            txt_idproduto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idproduto.Location = new Point(125, 15);
            txt_idproduto.Name = "txt_idproduto";
            txt_idproduto.Size = new Size(31, 22);
            txt_idproduto.TabIndex = 46;
            txt_idproduto.Text = "0";
            txt_idproduto.Visible = false;
            // 
            // txt_produto
            // 
            txt_produto.BackColor = Color.WhiteSmoke;
            txt_produto.BorderStyle = BorderStyle.FixedSingle;
            txt_produto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_produto.Location = new Point(6, 95);
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
            label5.Location = new Point(4, 23);
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
            label6.Location = new Point(6, 75);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 29;
            label6.Text = "Produto:";
            // 
            // txt_codproduto
            // 
            txt_codproduto.BackColor = Color.WhiteSmoke;
            txt_codproduto.BorderStyle = BorderStyle.FixedSingle;
            txt_codproduto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codproduto.Location = new Point(6, 41);
            txt_codproduto.Name = "txt_codproduto";
            txt_codproduto.Size = new Size(150, 22);
            txt_codproduto.TabIndex = 27;
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
            btn_pesquisarproduto.Location = new Point(891, 220);
            btn_pesquisarproduto.Name = "btn_pesquisarproduto";
            btn_pesquisarproduto.Size = new Size(104, 22);
            btn_pesquisarproduto.TabIndex = 47;
            btn_pesquisarproduto.Text = "Pesquisar";
            btn_pesquisarproduto.UseVisualStyleBackColor = false;
            btn_pesquisarproduto.Click += btn_pesquisarproduto_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(iconPictureBox2);
            groupBox2.Controls.Add(txt_codcliente);
            groupBox2.Controls.Add(btn_pesquisarfornecedor);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_nomecliente);
            groupBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(696, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 91);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do cliente";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.SteelBlue;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            iconPictureBox2.IconColor = Color.SteelBlue;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 63;
            iconPictureBox2.Location = new Point(6, 22);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(68, 63);
            iconPictureBox2.TabIndex = 76;
            iconPictureBox2.TabStop = false;
            // 
            // txt_codcliente
            // 
            txt_codcliente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codcliente.Location = new Point(283, 23);
            txt_codcliente.Name = "txt_codcliente";
            txt_codcliente.Size = new Size(31, 22);
            txt_codcliente.TabIndex = 75;
            txt_codcliente.Text = "1";
            txt_codcliente.Visible = false;
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
            btn_pesquisarfornecedor.Location = new Point(335, 51);
            btn_pesquisarfornecedor.Name = "btn_pesquisarfornecedor";
            btn_pesquisarfornecedor.Size = new Size(98, 22);
            btn_pesquisarfornecedor.TabIndex = 51;
            btn_pesquisarfornecedor.Text = "Pesquisar";
            btn_pesquisarfornecedor.UseVisualStyleBackColor = false;
            btn_pesquisarfornecedor.Click += btn_pesquisarfornecedor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 31);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 30;
            label3.Text = "Nome:";
            // 
            // txt_nomecliente
            // 
            txt_nomecliente.BackColor = Color.WhiteSmoke;
            txt_nomecliente.BorderStyle = BorderStyle.FixedSingle;
            txt_nomecliente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomecliente.Location = new Point(80, 51);
            txt_nomecliente.Name = "txt_nomecliente";
            txt_nomecliente.Size = new Size(234, 22);
            txt_nomecliente.TabIndex = 27;
            txt_nomecliente.Text = "@Cliente";
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
            groupBox1.Location = new Point(274, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 91);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da venda";
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
            label2.Size = new Size(156, 17);
            label2.TabIndex = 29;
            label2.Text = "Forma de Pagamento:";
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
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(234, 34);
            label7.Name = "label7";
            label7.Size = new Size(942, 574);
            label7.TabIndex = 54;
            label7.Text = " ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(317, 65);
            label8.Name = "label8";
            label8.Size = new Size(206, 24);
            label8.TabIndex = 66;
            label8.Text = "EFECTUAR VENDA";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(6, 85);
            label13.Name = "label13";
            label13.Size = new Size(88, 17);
            label13.TabIndex = 67;
            label13.Text = "IVA incluído:";
            // 
            // txt_valorcompra
            // 
            txt_valorcompra.BackColor = Color.WhiteSmoke;
            txt_valorcompra.BorderStyle = BorderStyle.FixedSingle;
            txt_valorcompra.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_valorcompra.Location = new Point(8, 46);
            txt_valorcompra.Name = "txt_valorcompra";
            txt_valorcompra.Size = new Size(122, 22);
            txt_valorcompra.TabIndex = 31;
            // 
            // txt_valortotal
            // 
            txt_valortotal.BackColor = Color.WhiteSmoke;
            txt_valortotal.BorderStyle = BorderStyle.FixedSingle;
            txt_valortotal.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_valortotal.Location = new Point(8, 161);
            txt_valortotal.Name = "txt_valortotal";
            txt_valortotal.Size = new Size(122, 22);
            txt_valortotal.TabIndex = 68;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(6, 141);
            label14.Name = "label14";
            label14.Size = new Size(81, 17);
            label14.TabIndex = 69;
            label14.Text = "Valor total:";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(txt_troco);
            groupBox4.Controls.Add(txt_valorpago);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txt_valortotal);
            groupBox4.Controls.Add(txt_valorcompra);
            groupBox4.Controls.Add(btn_registrar);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(1012, 212);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(141, 363);
            groupBox4.TabIndex = 57;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pagamento";
            // 
            // txt_troco
            // 
            txt_troco.BackColor = Color.WhiteSmoke;
            txt_troco.BorderStyle = BorderStyle.FixedSingle;
            txt_troco.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_troco.Location = new Point(8, 324);
            txt_troco.Name = "txt_troco";
            txt_troco.Size = new Size(122, 22);
            txt_troco.TabIndex = 74;
            // 
            // txt_valorpago
            // 
            txt_valorpago.BackColor = Color.White;
            txt_valorpago.BorderStyle = BorderStyle.FixedSingle;
            txt_valorpago.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_valorpago.Location = new Point(8, 225);
            txt_valorpago.Name = "txt_valorpago";
            txt_valorpago.Size = new Size(122, 22);
            txt_valorpago.TabIndex = 72;
            txt_valorpago.TextChanged += txt_valorpago_TextChanged;
            txt_valorpago.KeyPress += txt_valorpago_KeyPress;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(6, 205);
            label16.Name = "label16";
            label16.Size = new Size(86, 17);
            label16.TabIndex = 73;
            label16.Text = "Valor pago:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(8, 304);
            label15.Name = "label15";
            label15.Size = new Size(47, 17);
            label15.TabIndex = 71;
            label15.Text = "Troco:";
            // 
            // txt_iva
            // 
            txt_iva.BackColor = Color.WhiteSmoke;
            txt_iva.BorderStyle = BorderStyle.FixedSingle;
            txt_iva.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_iva.Location = new Point(1020, 315);
            txt_iva.Name = "txt_iva";
            txt_iva.Size = new Size(122, 22);
            txt_iva.TabIndex = 75;
            // 
            // txt_calculo
            // 
            txt_calculo.AutoSize = true;
            txt_calculo.BackColor = Color.White;
            txt_calculo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_calculo.ForeColor = Color.Black;
            txt_calculo.Location = new Point(1043, 84);
            txt_calculo.Name = "txt_calculo";
            txt_calculo.Size = new Size(15, 17);
            txt_calculo.TabIndex = 76;
            txt_calculo.Text = "1";
            txt_calculo.Visible = false;
            // 
            // txt_usu
            // 
            txt_usu.AutoSize = true;
            txt_usu.BackColor = Color.White;
            txt_usu.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usu.ForeColor = Color.Black;
            txt_usu.Location = new Point(895, 65);
            txt_usu.Name = "txt_usu";
            txt_usu.Size = new Size(54, 17);
            txt_usu.TabIndex = 77;
            txt_usu.Text = "usuario";
            txt_usu.Visible = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Firebrick;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(956, 550);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(39, 25);
            iconButton1.TabIndex = 78;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1370, 650);
            Controls.Add(iconButton1);
            Controls.Add(txt_usu);
            Controls.Add(txt_calculo);
            Controls.Add(txt_iva);
            Controls.Add(groupBox4);
            Controls.Add(label8);
            Controls.Add(txt_nomeusuario);
            Controls.Add(btn_pesquisarproduto);
            Controls.Add(iconPictureBox1);
            Controls.Add(dgvcompra);
            Controls.Add(txt_adicionar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "vendas";
            Text = "vendas";
            Load += vendas_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvcompra).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_quantiidade).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_nomeusuario;
        private FontAwesome.Sharp.IconButton btn_registrar;
        private Label label11;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DataGridView dgvcompra;
        private FontAwesome.Sharp.IconButton txt_adicionar;
        private GroupBox groupBox3;
        private NumericUpDown numeric_quantiidade;
        private FontAwesome.Sharp.IconButton btn_pesquisarproduto;
        private Label label10;
        private Label label9;
        private TextBox txt_precocompra;
        private TextBox txt_idproduto;
        private TextBox txt_produto;
        private Label label5;
        private Label label6;
        private TextBox txt_codproduto;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_pesquisarfornecedor;
        private TextBox txt_idfornecedor;
        private TextBox txt_razaosocial;
        private Label label3;
        private TextBox txt_nomecliente;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private ComboBox comb_tipodocumento;
        private TextBox txt_data;
        private Label label7;
        private Label label8;
        private Label label12;
        private Label label4;
        private TextBox txt_estoque;
        private Label label13;
        private TextBox txt_valorcompra;
        private TextBox txt_valortotal;
        private Label label14;
        private GroupBox groupBox4;
        private TextBox txt_valorpago;
        private Label label16;
        private Label label15;
        private TextBox txt_precovenda;
        private TextBox txt_codcliente;
        private TextBox txt_troco;
        private Label txt_descricao;
        private TextBox txt_iva;
        private DataGridViewTextBoxColumn produto;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn preco_venda;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn tipo_documento;
        private DataGridViewTextBoxColumn registrado_por;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label txt_calculo;
        private Label txt_usu;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}