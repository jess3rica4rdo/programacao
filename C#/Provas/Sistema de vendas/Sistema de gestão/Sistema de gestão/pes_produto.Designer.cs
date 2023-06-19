namespace Sistema_de_gestão
{
    partial class pes_produto
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
            label7 = new Label();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txt_pes = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txt_buscar = new TextBox();
            label12 = new Label();
            dgvusuario = new DataGridView();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvusuario).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(267, 93);
            label7.Name = "label7";
            label7.Size = new Size(849, 417);
            label7.TabIndex = 55;
            label7.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(45, 66, 91);
            label1.Location = new Point(372, 128);
            label1.Name = "label1";
            label1.Size = new Size(277, 24);
            label1.TabIndex = 79;
            label1.Text = "PRODUTOS DISPONÍVEIS";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(45, 66, 91);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Computer;
            iconPictureBox1.IconColor = Color.FromArgb(45, 66, 91);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 95;
            iconPictureBox1.Location = new Point(290, 93);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(171, 95);
            iconPictureBox1.TabIndex = 78;
            iconPictureBox1.TabStop = false;
            // 
            // txt_pes
            // 
            txt_pes.BackColor = Color.SteelBlue;
            txt_pes.Cursor = Cursors.Hand;
            txt_pes.FlatAppearance.BorderColor = Color.Black;
            txt_pes.FlatStyle = FlatStyle.Flat;
            txt_pes.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_pes.ForeColor = Color.White;
            txt_pes.IconChar = FontAwesome.Sharp.IconChar.None;
            txt_pes.IconColor = Color.Green;
            txt_pes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            txt_pes.IconSize = 40;
            txt_pes.Location = new Point(964, 130);
            txt_pes.Name = "txt_pes";
            txt_pes.Size = new Size(75, 22);
            txt_pes.TabIndex = 77;
            txt_pes.Text = "Pesquisar";
            txt_pes.TextImageRelation = TextImageRelation.ImageAboveText;
            txt_pes.UseVisualStyleBackColor = false;
            txt_pes.Click += txt_pes_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Gainsboro;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(1045, 129);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(39, 22);
            iconButton1.TabIndex = 76;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_buscar.Location = new Point(830, 129);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(128, 22);
            txt_buscar.TabIndex = 74;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(728, 132);
            label12.Name = "label12";
            label12.Size = new Size(97, 17);
            label12.TabIndex = 75;
            label12.Text = "Pesquisar por:";
            // 
            // dgvusuario
            // 
            dgvusuario.AllowUserToAddRows = false;
            dgvusuario.AllowUserToOrderColumns = true;
            dgvusuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvusuario.BackgroundColor = Color.White;
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
            dgvusuario.Location = new Point(300, 159);
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
            dgvusuario.Size = new Size(784, 298);
            dgvusuario.TabIndex = 80;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.MediumSeaGreen;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderColor = Color.Black;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 16;
            iconButton2.Location = new Point(947, 465);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(137, 27);
            iconButton2.TabIndex = 81;
            iconButton2.Text = "Descarregar Excel";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // pes_produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1370, 636);
            Controls.Add(iconButton2);
            Controls.Add(dgvusuario);
            Controls.Add(label1);
            Controls.Add(iconPictureBox1);
            Controls.Add(txt_pes);
            Controls.Add(iconButton1);
            Controls.Add(txt_buscar);
            Controls.Add(label12);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(150, 91);
            Name = "pes_produto";
            Text = "pes_produto";
            Load += pes_produto_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvusuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton txt_pes;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txt_buscar;
        private Label label12;
        private DataGridView dgvusuario;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}