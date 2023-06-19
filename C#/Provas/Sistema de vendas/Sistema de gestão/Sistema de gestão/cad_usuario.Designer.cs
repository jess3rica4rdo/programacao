namespace Sistema_de_gestão
{
    partial class cad_usuario
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txt_nomecompleto = new TextBox();
            comb_funcao = new ComboBox();
            label2 = new Label();
            comb_genero = new ComboBox();
            comb_idade = new ComboBox();
            txt_telefone = new TextBox();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            groupBox1 = new GroupBox();
            txt_codusuario = new TextBox();
            btn_cadastrar = new FontAwesome.Sharp.IconButton();
            btn_eliminar = new FontAwesome.Sharp.IconButton();
            btn_editar = new FontAwesome.Sharp.IconButton();
            dgvusuario = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            txt_buscar = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            txt_addpor = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            txt_pes = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvusuario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 633);
            label1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 82);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 2;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, -108);
            label4.Name = "label4";
            label4.Size = new Size(119, 17);
            label4.TabIndex = 3;
            label4.Text = "Nome Completo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 187);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 4;
            label5.Text = "Usuário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 135);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 5;
            label6.Text = "Telefone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(83, 82);
            label10.Name = "label10";
            label10.Size = new Size(56, 17);
            label10.TabIndex = 9;
            label10.Text = "Gênero";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(15, 237);
            label11.Name = "label11";
            label11.Size = new Size(47, 17);
            label11.TabIndex = 10;
            label11.Text = "Senha";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(15, 288);
            label12.Name = "label12";
            label12.Size = new Size(60, 17);
            label12.TabIndex = 11;
            label12.Text = "Função:";
            // 
            // txt_nomecompleto
            // 
            txt_nomecompleto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomecompleto.Location = new Point(15, 51);
            txt_nomecompleto.Name = "txt_nomecompleto";
            txt_nomecompleto.Size = new Size(163, 22);
            txt_nomecompleto.TabIndex = 12;
            // 
            // comb_funcao
            // 
            comb_funcao.DropDownStyle = ComboBoxStyle.DropDownList;
            comb_funcao.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comb_funcao.FormattingEnabled = true;
            comb_funcao.Items.AddRange(new object[] { "ADMINISTRADOR", "OPERADOR DE CAIXA" });
            comb_funcao.Location = new Point(15, 308);
            comb_funcao.Name = "comb_funcao";
            comb_funcao.Size = new Size(163, 25);
            comb_funcao.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 31);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 14;
            label2.Text = "Nome Completo";
            // 
            // comb_genero
            // 
            comb_genero.BackColor = Color.White;
            comb_genero.DropDownStyle = ComboBoxStyle.DropDownList;
            comb_genero.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comb_genero.FormattingEnabled = true;
            comb_genero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comb_genero.Location = new Point(83, 102);
            comb_genero.Name = "comb_genero";
            comb_genero.Size = new Size(95, 25);
            comb_genero.TabIndex = 15;
            // 
            // comb_idade
            // 
            comb_idade.DropDownStyle = ComboBoxStyle.DropDownList;
            comb_idade.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comb_idade.FormattingEnabled = true;
            comb_idade.Items.AddRange(new object[] { "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50" });
            comb_idade.Location = new Point(15, 102);
            comb_idade.Name = "comb_idade";
            comb_idade.Size = new Size(46, 25);
            comb_idade.TabIndex = 16;
            // 
            // txt_telefone
            // 
            txt_telefone.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefone.Location = new Point(15, 155);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(163, 22);
            txt_telefone.TabIndex = 17;
            txt_telefone.Text = "+244 ";
            txt_telefone.KeyPress += txt_telefone_KeyPress;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(15, 207);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(163, 22);
            txt_usuario.TabIndex = 18;
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(15, 257);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(163, 22);
            txt_senha.TabIndex = 19;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 100;
            iconPictureBox1.Location = new Point(50, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(101, 100);
            iconPictureBox1.TabIndex = 20;
            iconPictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txt_codusuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_senha);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_usuario);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_telefone);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comb_idade);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(comb_genero);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txt_nomecompleto);
            groupBox1.Controls.Add(comb_funcao);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(5, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 356);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "USUÁRIO";
            // 
            // txt_codusuario
            // 
            txt_codusuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codusuario.Location = new Point(139, 14);
            txt_codusuario.Name = "txt_codusuario";
            txt_codusuario.Size = new Size(39, 22);
            txt_codusuario.TabIndex = 20;
            txt_codusuario.Text = "0";
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
            btn_cadastrar.Location = new Point(5, 468);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(194, 27);
            btn_cadastrar.TabIndex = 22;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.TextAlign = ContentAlignment.MiddleRight;
            btn_cadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
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
            btn_eliminar.Location = new Point(5, 532);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(194, 26);
            btn_eliminar.TabIndex = 23;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.TextAlign = ContentAlignment.MiddleRight;
            btn_eliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
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
            btn_editar.Location = new Point(5, 501);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(194, 25);
            btn_editar.TabIndex = 24;
            btn_editar.Text = "Editar";
            btn_editar.TextAlign = ContentAlignment.MiddleRight;
            btn_editar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
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
            dgvusuario.Location = new Point(319, 95);
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
            dgvusuario.Size = new Size(936, 480);
            dgvusuario.TabIndex = 25;
            dgvusuario.RowHeaderMouseClick += dgvusuario_RowHeaderMouseClick;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(45, 66, 91);
            label7.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(319, 33);
            label7.Name = "label7";
            label7.Size = new Size(936, 48);
            label7.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(45, 66, 91);
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(872, 47);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 21;
            label8.Text = "Pesquisar por:";
            // 
            // txt_buscar
            // 
            txt_buscar.BackColor = Color.White;
            txt_buscar.BorderStyle = BorderStyle.FixedSingle;
            txt_buscar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_buscar.Location = new Point(988, 47);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(128, 22);
            txt_buscar.TabIndex = 21;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(1205, 46);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(39, 25);
            iconButton1.TabIndex = 27;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(45, 66, 91);
            label13.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(331, 45);
            label13.Name = "label13";
            label13.Size = new Size(248, 25);
            label13.TabIndex = 22;
            label13.Text = "GESTÃO DE USUÁRIOS";
            // 
            // txt_addpor
            // 
            txt_addpor.BackColor = Color.White;
            txt_addpor.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_addpor.ForeColor = Color.White;
            txt_addpor.Location = new Point(12, 33);
            txt_addpor.Name = "txt_addpor";
            txt_addpor.Size = new Size(32, 36);
            txt_addpor.TabIndex = 21;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Silver;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.FlatAppearance.BorderColor = Color.Black;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.Black;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 16;
            iconButton3.Location = new Point(5, 564);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(194, 26);
            iconButton3.TabIndex = 29;
            iconButton3.Text = "Limpar";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(203, 614);
            label9.Name = "label9";
            label9.Size = new Size(1240, 24);
            label9.TabIndex = 30;
            // 
            // txt_pes
            // 
            txt_pes.BackColor = Color.SteelBlue;
            txt_pes.Cursor = Cursors.Hand;
            txt_pes.FlatAppearance.BorderColor = Color.Black;
            txt_pes.FlatStyle = FlatStyle.Flat;
            txt_pes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_pes.ForeColor = Color.White;
            txt_pes.IconChar = FontAwesome.Sharp.IconChar.None;
            txt_pes.IconColor = Color.Green;
            txt_pes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            txt_pes.IconSize = 16;
            txt_pes.Location = new Point(1124, 46);
            txt_pes.Name = "txt_pes";
            txt_pes.Size = new Size(75, 25);
            txt_pes.TabIndex = 43;
            txt_pes.Text = "Pesquisar";
            txt_pes.TextImageRelation = TextImageRelation.ImageAboveText;
            txt_pes.UseVisualStyleBackColor = false;
            txt_pes.Click += txt_pes_Click;
            // 
            // cad_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1386, 633);
            Controls.Add(txt_pes);
            Controls.Add(label9);
            Controls.Add(iconButton3);
            Controls.Add(txt_addpor);
            Controls.Add(label13);
            Controls.Add(iconButton1);
            Controls.Add(txt_buscar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvusuario);
            Controls.Add(btn_editar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_cadastrar);
            Controls.Add(groupBox1);
            Controls.Add(iconPictureBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cad_usuario";
            Text = "cad_usuario";
            Load += cad_usuario_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvusuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txt_nomecompleto;
        private ComboBox comb_funcao;
        private Label label2;
        private ComboBox comb_genero;
        private ComboBox comb_idade;
        private TextBox txt_telefone;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btn_cadastrar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_editar;
        private DataGridView dgvusuario;
        private Label label7;
        private TextBox txt_codusuario;
        private Label label8;
        private TextBox txt_buscar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label13;
        private Label txt_addpor;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label9;
        private FontAwesome.Sharp.IconButton txt_pes;
    }
}