namespace Sistema_de_gestão
{
    partial class cad_clientes
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
            txt_pes = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            txt_addpor = new Label();
            label13 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txt_buscar = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btn_editar = new FontAwesome.Sharp.IconButton();
            btn_eliminar = new FontAwesome.Sharp.IconButton();
            btn_cadastrar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txt_email = new TextBox();
            txt_codusuario = new TextBox();
            label2 = new Label();
            label6 = new Label();
            txt_telefone = new TextBox();
            txt_nomecompleto = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            dgvcliente = new DataGridView();
            txt_funcao = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvcliente).BeginInit();
            SuspendLayout();
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
            txt_pes.Location = new Point(1033, 43);
            txt_pes.Name = "txt_pes";
            txt_pes.Size = new Size(75, 25);
            txt_pes.TabIndex = 59;
            txt_pes.Text = "Pesquisar";
            txt_pes.TextImageRelation = TextImageRelation.ImageAboveText;
            txt_pes.UseVisualStyleBackColor = false;
            txt_pes.Click += txt_pes_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(204, 613);
            label9.Name = "label9";
            label9.Size = new Size(1240, 24);
            label9.TabIndex = 58;
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
            iconButton3.Location = new Point(6, 402);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(194, 26);
            iconButton3.TabIndex = 57;
            iconButton3.Text = "Limpar";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // txt_addpor
            // 
            txt_addpor.BackColor = Color.White;
            txt_addpor.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_addpor.ForeColor = Color.White;
            txt_addpor.Location = new Point(0, 42);
            txt_addpor.Name = "txt_addpor";
            txt_addpor.Size = new Size(40, 24);
            txt_addpor.TabIndex = 47;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(45, 66, 91);
            label13.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(462, 42);
            label13.Name = "label13";
            label13.Size = new Size(248, 25);
            label13.TabIndex = 51;
            label13.Text = "GESTÃO DE CLIENTES:";
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
            iconButton1.Location = new Point(1114, 43);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(39, 25);
            iconButton1.TabIndex = 56;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_buscar.Location = new Point(897, 44);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(128, 22);
            txt_buscar.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(45, 66, 91);
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(781, 44);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 49;
            label8.Text = "Pesquisar por:";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(45, 66, 91);
            label7.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(450, 30);
            label7.Name = "label7";
            label7.Size = new Size(715, 48);
            label7.TabIndex = 45;
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
            btn_editar.Location = new Point(6, 339);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(194, 25);
            btn_editar.TabIndex = 54;
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
            btn_eliminar.Location = new Point(6, 370);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(194, 26);
            btn_eliminar.TabIndex = 53;
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
            btn_cadastrar.Location = new Point(6, 306);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(194, 27);
            btn_cadastrar.TabIndex = 52;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.TextAlign = ContentAlignment.MiddleRight;
            btn_cadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_codusuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_telefone);
            groupBox1.Controls.Add(txt_nomecompleto);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 200);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "CLIENTES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 83);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 22;
            label3.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(15, 105);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(163, 22);
            txt_email.TabIndex = 21;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 34);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 14;
            label2.Text = "Nome Completo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 137);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 5;
            label6.Text = "Telefone";
            // 
            // txt_telefone
            // 
            txt_telefone.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefone.Location = new Point(15, 158);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(163, 22);
            txt_telefone.TabIndex = 17;
            txt_telefone.Text = "+244 ";
            // 
            // txt_nomecompleto
            // 
            txt_nomecompleto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomecompleto.Location = new Point(15, 54);
            txt_nomecompleto.Name = "txt_nomecompleto";
            txt_nomecompleto.Size = new Size(163, 22);
            txt_nomecompleto.TabIndex = 12;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 100;
            iconPictureBox1.Location = new Point(51, -3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(101, 100);
            iconPictureBox1.TabIndex = 46;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 633);
            label1.TabIndex = 44;
            // 
            // dgvcliente
            // 
            dgvcliente.AllowUserToAddRows = false;
            dgvcliente.AllowUserToOrderColumns = true;
            dgvcliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvcliente.BackgroundColor = Color.SteelBlue;
            dgvcliente.BorderStyle = BorderStyle.None;
            dgvcliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvcliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvcliente.ColumnHeadersHeight = 27;
            dgvcliente.EnableHeadersVisualStyles = false;
            dgvcliente.GridColor = Color.SteelBlue;
            dgvcliente.Location = new Point(450, 96);
            dgvcliente.MultiSelect = false;
            dgvcliente.Name = "dgvcliente";
            dgvcliente.ReadOnly = true;
            dgvcliente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvcliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvcliente.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dgvcliente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvcliente.RowTemplate.Height = 25;
            dgvcliente.Size = new Size(715, 480);
            dgvcliente.TabIndex = 60;
            dgvcliente.RowHeaderMouseClick += dgvcliente_RowHeaderMouseClick_1;
            // 
            // txt_funcao
            // 
            txt_funcao.BackColor = Color.White;
            txt_funcao.Location = new Point(155, 52);
            txt_funcao.Name = "txt_funcao";
            txt_funcao.Size = new Size(51, 45);
            txt_funcao.TabIndex = 61;
            txt_funcao.Visible = false;
            // 
            // cad_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1386, 633);
            Controls.Add(txt_funcao);
            Controls.Add(dgvcliente);
            Controls.Add(txt_pes);
            Controls.Add(label9);
            Controls.Add(iconButton3);
            Controls.Add(txt_addpor);
            Controls.Add(label13);
            Controls.Add(iconButton1);
            Controls.Add(txt_buscar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btn_editar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_cadastrar);
            Controls.Add(groupBox1);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cad_clientes";
            Text = "clientes";
            Load += cad_clientes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvcliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton txt_pes;
        private Label label9;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label txt_addpor;
        private Label label13;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txt_buscar;
        private Label label8;
        private Label label7;
        private FontAwesome.Sharp.IconButton btn_editar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_cadastrar;
        private GroupBox groupBox1;
        private TextBox txt_codusuario;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label3;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_telefone;
        private TextBox txt_nomecompleto;
        private DataGridView dgvcliente;
        private Label txt_funcao;
    }
}