namespace Sistema_de_gestão
{
    partial class cad_produtos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btn_editar = new FontAwesome.Sharp.IconButton();
            btn_eliminar = new FontAwesome.Sharp.IconButton();
            btn_cadastrar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label11 = new Label();
            txt_precocompra = new TextBox();
            label5 = new Label();
            txt_precovenda = new TextBox();
            label12 = new Label();
            comb_categoria = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txt_estado = new ComboBox();
            txt_estoque = new TextBox();
            txt_descricao = new TextBox();
            txt_codusuario = new TextBox();
            label2 = new Label();
            txt_nomeproduto = new TextBox();
            label10 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label13 = new Label();
            txt_pesquisar = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            txt_limpar = new FontAwesome.Sharp.IconButton();
            txt_apagar = new FontAwesome.Sharp.IconButton();
            txt_addpor = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txt_pes = new FontAwesome.Sharp.IconButton();
            dgvusuario = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvusuario).BeginInit();
            SuspendLayout();
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.RoyalBlue;
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.FlatAppearance.BorderColor = Color.Black;
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.ForeColor = Color.White;
            btn_editar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btn_editar.IconColor = Color.White;
            btn_editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_editar.IconSize = 16;
            btn_editar.Location = new Point(5, 525);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(194, 25);
            btn_editar.TabIndex = 30;
            btn_editar.Text = "Editar";
            btn_editar.TextAlign = ContentAlignment.MiddleRight;
            btn_editar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.Firebrick;
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.FlatAppearance.BorderColor = Color.Black;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btn_eliminar.IconColor = Color.White;
            btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_eliminar.IconSize = 16;
            btn_eliminar.Location = new Point(5, 556);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(194, 26);
            btn_eliminar.TabIndex = 29;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.TextAlign = ContentAlignment.MiddleRight;
            btn_eliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.ForestGreen;
            btn_cadastrar.Cursor = Cursors.Hand;
            btn_cadastrar.FlatAppearance.BorderColor = Color.Black;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cadastrar.ForeColor = Color.White;
            btn_cadastrar.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            btn_cadastrar.IconColor = Color.White;
            btn_cadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cadastrar.IconSize = 16;
            btn_cadastrar.Location = new Point(5, 492);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(194, 27);
            btn_cadastrar.TabIndex = 28;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.TextAlign = ContentAlignment.MiddleRight;
            btn_cadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(comb_categoria);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_estado);
            groupBox1.Controls.Add(txt_estoque);
            groupBox1.Controls.Add(txt_descricao);
            groupBox1.Controls.Add(txt_codusuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_nomeproduto);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(5, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 396);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "PRODUTOS";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txt_precocompra);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_precovenda);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(6, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(182, 91);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(4, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 47;
            label6.Text = "PREÇO";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(11, 27);
            label11.Name = "label11";
            label11.Size = new Size(63, 17);
            label11.TabIndex = 25;
            label11.Text = "Compra";
            // 
            // txt_precocompra
            // 
            txt_precocompra.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_precocompra.Location = new Point(82, 22);
            txt_precocompra.Name = "txt_precocompra";
            txt_precocompra.Size = new Size(91, 22);
            txt_precocompra.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 53);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 23;
            label5.Text = " Venda";
            // 
            // txt_precovenda
            // 
            txt_precovenda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_precovenda.Location = new Point(82, 50);
            txt_precovenda.Name = "txt_precovenda";
            txt_precovenda.Size = new Size(91, 22);
            txt_precovenda.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(10, 144);
            label12.Name = "label12";
            label12.Size = new Size(72, 17);
            label12.TabIndex = 45;
            label12.Text = "Descrição";
            // 
            // comb_categoria
            // 
            comb_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comb_categoria.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comb_categoria.FormattingEnabled = true;
            comb_categoria.Items.AddRange(new object[] { "SMARTPHONE", "COMPUTADOR" });
            comb_categoria.Location = new Point(10, 107);
            comb_categoria.Name = "comb_categoria";
            comb_categoria.Size = new Size(169, 25);
            comb_categoria.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 87);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 44;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 203);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 42;
            label3.Text = "Estado";
            // 
            // txt_estado
            // 
            txt_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_estado.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_estado.FormattingEnabled = true;
            txt_estado.Items.AddRange(new object[] { "NOVO", "RECONDICIONADO" });
            txt_estado.Location = new Point(10, 223);
            txt_estado.Name = "txt_estado";
            txt_estado.Size = new Size(169, 25);
            txt_estado.TabIndex = 41;
            // 
            // txt_estoque
            // 
            txt_estoque.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_estoque.Location = new Point(75, 263);
            txt_estoque.Name = "txt_estoque";
            txt_estoque.Size = new Size(104, 22);
            txt_estoque.TabIndex = 27;
            // 
            // txt_descricao
            // 
            txt_descricao.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_descricao.Location = new Point(10, 154);
            txt_descricao.Multiline = true;
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Size = new Size(170, 43);
            txt_descricao.TabIndex = 22;
            txt_descricao.Text = "\r\n\r\n\r\n\r\n";
            // 
            // txt_codusuario
            // 
            txt_codusuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codusuario.Location = new Point(140, 14);
            txt_codusuario.Name = "txt_codusuario";
            txt_codusuario.Size = new Size(39, 22);
            txt_codusuario.TabIndex = 20;
            txt_codusuario.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 32);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 14;
            label2.Text = "Marca do Produto";
            // 
            // txt_nomeproduto
            // 
            txt_nomeproduto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeproduto.Location = new Point(9, 52);
            txt_nomeproduto.Name = "txt_nomeproduto";
            txt_nomeproduto.Size = new Size(170, 22);
            txt_nomeproduto.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(10, 263);
            label10.Name = "label10";
            label10.Size = new Size(59, 17);
            label10.TabIndex = 9;
            label10.Text = "Estoque";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Computer;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 100;
            iconPictureBox1.Location = new Point(50, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(101, 100);
            iconPictureBox1.TabIndex = 26;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 658);
            label1.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(45, 66, 91);
            label13.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(356, 28);
            label13.Name = "label13";
            label13.Size = new Size(264, 25);
            label13.TabIndex = 34;
            label13.Text = "GESTÃO DE PRODUTOS:";
            // 
            // txt_pesquisar
            // 
            txt_pesquisar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pesquisar.Location = new Point(990, 65);
            txt_pesquisar.Name = "txt_pesquisar";
            txt_pesquisar.Size = new Size(128, 22);
            txt_pesquisar.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(45, 66, 91);
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(877, 66);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 33;
            label8.Text = "Pesquisar por:";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(45, 66, 91);
            label7.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(346, 19);
            label7.Name = "label7";
            label7.Size = new Size(911, 80);
            label7.TabIndex = 31;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(201, 617);
            label9.Name = "label9";
            label9.Size = new Size(1240, 24);
            label9.TabIndex = 38;
            // 
            // txt_limpar
            // 
            txt_limpar.BackColor = Color.Silver;
            txt_limpar.Cursor = Cursors.Hand;
            txt_limpar.FlatAppearance.BorderColor = Color.Black;
            txt_limpar.FlatStyle = FlatStyle.Flat;
            txt_limpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_limpar.ForeColor = Color.Black;
            txt_limpar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            txt_limpar.IconColor = Color.Black;
            txt_limpar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            txt_limpar.IconSize = 16;
            txt_limpar.Location = new Point(5, 588);
            txt_limpar.Name = "txt_limpar";
            txt_limpar.Size = new Size(194, 26);
            txt_limpar.TabIndex = 39;
            txt_limpar.Text = "Limpar";
            txt_limpar.TextAlign = ContentAlignment.MiddleRight;
            txt_limpar.TextImageRelation = TextImageRelation.ImageBeforeText;
            txt_limpar.UseVisualStyleBackColor = false;
            txt_limpar.Click += txt_limpar_Click;
            // 
            // txt_apagar
            // 
            txt_apagar.BackColor = Color.White;
            txt_apagar.Cursor = Cursors.Hand;
            txt_apagar.FlatAppearance.BorderColor = Color.Black;
            txt_apagar.FlatStyle = FlatStyle.Flat;
            txt_apagar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_apagar.ForeColor = Color.White;
            txt_apagar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            txt_apagar.IconColor = Color.Black;
            txt_apagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            txt_apagar.IconSize = 20;
            txt_apagar.Location = new Point(1205, 63);
            txt_apagar.Name = "txt_apagar";
            txt_apagar.Size = new Size(39, 25);
            txt_apagar.TabIndex = 40;
            txt_apagar.TextAlign = ContentAlignment.MiddleRight;
            txt_apagar.TextImageRelation = TextImageRelation.ImageBeforeText;
            txt_apagar.UseVisualStyleBackColor = false;
            txt_apagar.Click += txt_apagar_Click;
            // 
            // txt_addpor
            // 
            txt_addpor.BackColor = Color.White;
            txt_addpor.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_addpor.ForeColor = Color.White;
            txt_addpor.Location = new Point(11, 35);
            txt_addpor.Name = "txt_addpor";
            txt_addpor.Size = new Size(28, 21);
            txt_addpor.TabIndex = 29;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.MediumSeaGreen;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 16;
            iconButton1.Location = new Point(356, 60);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(137, 27);
            iconButton1.TabIndex = 41;
            iconButton1.Text = "Descarregar Excel";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // txt_pes
            // 
            txt_pes.BackColor = Color.FromArgb(224, 224, 224);
            txt_pes.Cursor = Cursors.Hand;
            txt_pes.FlatAppearance.BorderColor = Color.Black;
            txt_pes.FlatStyle = FlatStyle.Flat;
            txt_pes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_pes.ForeColor = Color.Black;
            txt_pes.IconChar = FontAwesome.Sharp.IconChar.None;
            txt_pes.IconColor = Color.Green;
            txt_pes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            txt_pes.IconSize = 16;
            txt_pes.Location = new Point(1124, 63);
            txt_pes.Name = "txt_pes";
            txt_pes.Size = new Size(75, 25);
            txt_pes.TabIndex = 42;
            txt_pes.Text = "Pesquisar";
            txt_pes.TextImageRelation = TextImageRelation.ImageAboveText;
            txt_pes.UseVisualStyleBackColor = false;
            txt_pes.Click += txt_pes_Click;
            // 
            // dgvusuario
            // 
            dgvusuario.AllowUserToAddRows = false;
            dgvusuario.AllowUserToOrderColumns = true;
            dgvusuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvusuario.BackgroundColor = Color.SteelBlue;
            dgvusuario.BorderStyle = BorderStyle.None;
            dgvusuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvusuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvusuario.ColumnHeadersHeight = 27;
            dgvusuario.EnableHeadersVisualStyles = false;
            dgvusuario.GridColor = Color.SteelBlue;
            dgvusuario.Location = new Point(346, 115);
            dgvusuario.MultiSelect = false;
            dgvusuario.Name = "dgvusuario";
            dgvusuario.ReadOnly = true;
            dgvusuario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvusuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvusuario.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dgvusuario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvusuario.RowTemplate.Height = 25;
            dgvusuario.Size = new Size(911, 481);
            dgvusuario.TabIndex = 43;
            dgvusuario.RowHeaderMouseClick += dgvusuario_RowHeaderMouseClick_1;
            // 
            // cad_produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1386, 658);
            Controls.Add(dgvusuario);
            Controls.Add(txt_pes);
            Controls.Add(iconButton1);
            Controls.Add(txt_addpor);
            Controls.Add(txt_apagar);
            Controls.Add(txt_limpar);
            Controls.Add(label9);
            Controls.Add(label13);
            Controls.Add(txt_pesquisar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btn_editar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_cadastrar);
            Controls.Add(groupBox1);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cad_produtos";
            Text = "cad_produtos";
            Load += cad_produtos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvusuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_editar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_cadastrar;
        private GroupBox groupBox1;
        private TextBox txt_codusuario;
        private Label label2;
        private Label label10;

        private TextBox txt_nomeproduto;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label13;
        private TextBox txt_pesquisar;
        private Label label8;
        private Label label7;
        private TextBox txt_descricao;
        private Label label9;
        private TextBox textBox3;
        private Label label11;
        private TextBox txt_precocompra;
        private Label label5;
        private TextBox txt_estoque;
        private FontAwesome.Sharp.IconButton txt_limpar;
        private FontAwesome.Sharp.IconButton txt_apagar;
        private TextBox txt_precovenda;
        private Label txt_addpor;
        private Label label3;
        private ComboBox txt_estado;
        private GroupBox groupBox2;
        private Label label12;
        private ComboBox comb_categoria;
        private Label label4;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton txt_pes;
        private DataGridView dgvusuario;
    }
}