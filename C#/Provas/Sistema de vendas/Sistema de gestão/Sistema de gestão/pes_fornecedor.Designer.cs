namespace Sistema_de_gestão
{
    partial class pes_fornecedor
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
            txt_pes = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txt_buscar = new TextBox();
            dgvfornecedor = new DataGridView();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvfornecedor).BeginInit();
            SuspendLayout();
            // 
            // txt_pes
            // 
            txt_pes.BackColor = Color.DarkCyan;
            txt_pes.Cursor = Cursors.Hand;
            txt_pes.FlatAppearance.BorderColor = Color.Black;
            txt_pes.FlatStyle = FlatStyle.Flat;
            txt_pes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_pes.ForeColor = Color.Black;
            txt_pes.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            txt_pes.IconColor = Color.White;
            txt_pes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            txt_pes.IconSize = 16;
            txt_pes.Location = new Point(254, 16);
            txt_pes.Name = "txt_pes";
            txt_pes.Size = new Size(34, 25);
            txt_pes.TabIndex = 66;
            txt_pes.TextImageRelation = TextImageRelation.ImageAboveText;
            txt_pes.UseVisualStyleBackColor = false;
            txt_pes.Click += txt_pes_Click;
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
            iconButton1.Location = new Point(294, 16);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(39, 25);
            iconButton1.TabIndex = 65;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // txt_buscar
            // 
            txt_buscar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_buscar.Location = new Point(120, 17);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(128, 22);
            txt_buscar.TabIndex = 61;
            // 
            // dgvfornecedor
            // 
            dgvfornecedor.AllowUserToAddRows = false;
            dgvfornecedor.AllowUserToOrderColumns = true;
            dgvfornecedor.BackgroundColor = Color.White;
            dgvfornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfornecedor.Location = new Point(14, 52);
            dgvfornecedor.MultiSelect = false;
            dgvfornecedor.Name = "dgvfornecedor";
            dgvfornecedor.ReadOnly = true;
            dgvfornecedor.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ActiveCaption;
            dgvfornecedor.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvfornecedor.RowTemplate.Height = 25;
            dgvfornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvfornecedor.Size = new Size(409, 170);
            dgvfornecedor.TabIndex = 64;
            dgvfornecedor.CellDoubleClick += dgvfornecedor_CellDoubleClick;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.IndianRed;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderColor = Color.Black;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(405, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(22, 21);
            iconButton2.TabIndex = 74;
            iconButton2.Text = "X";
            iconButton2.TextAlign = ContentAlignment.TopRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(45, 66, 91);
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 16);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 75;
            label8.Text = "Pesquisar por:";
            // 
            // pes_fornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(439, 241);
            Controls.Add(label8);
            Controls.Add(iconButton2);
            Controls.Add(txt_pes);
            Controls.Add(iconButton1);
            Controls.Add(txt_buscar);
            Controls.Add(dgvfornecedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pes_fornecedor";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FORNECEDORES";
            Load += ca_fornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvfornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton txt_pes;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txt_buscar;
        private DataGridView dgvfornecedor;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label8;
    }
}