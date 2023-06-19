namespace Sistema_de_gestão
{
    partial class pes_cliente
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txt_buscar = new TextBox();
            dgvfornecedor = new DataGridView();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvfornecedor).BeginInit();
            SuspendLayout();
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
            iconButton1.Location = new Point(295, 15);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(39, 25);
            iconButton1.TabIndex = 71;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // txt_buscar
            // 
            txt_buscar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_buscar.Location = new Point(122, 16);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(128, 22);
            txt_buscar.TabIndex = 68;
            // 
            // dgvfornecedor
            // 
            dgvfornecedor.AllowUserToAddRows = false;
            dgvfornecedor.AllowUserToOrderColumns = true;
            dgvfornecedor.BackgroundColor = Color.White;
            dgvfornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfornecedor.Location = new Point(12, 57);
            dgvfornecedor.MultiSelect = false;
            dgvfornecedor.Name = "dgvfornecedor";
            dgvfornecedor.ReadOnly = true;
            dgvfornecedor.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ActiveCaption;
            dgvfornecedor.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvfornecedor.RowTemplate.Height = 25;
            dgvfornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvfornecedor.Size = new Size(436, 171);
            dgvfornecedor.TabIndex = 70;
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
            iconButton2.Location = new Point(426, 7);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(22, 21);
            iconButton2.TabIndex = 73;
            iconButton2.Text = "X";
            iconButton2.TextAlign = ContentAlignment.TopRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.DarkCyan;
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.FlatAppearance.BorderColor = Color.Black;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.Black;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 16;
            iconButton4.Location = new Point(256, 15);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(34, 25);
            iconButton4.TabIndex = 75;
            iconButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
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
            label8.TabIndex = 76;
            label8.Text = "Pesquisar por:";
            // 
            // pes_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(462, 252);
            Controls.Add(label8);
            Controls.Add(iconButton4);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(txt_buscar);
            Controls.Add(dgvfornecedor);
            ForeColor = Color.FromArgb(45, 66, 91);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pes_cliente";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ca_cliente";
            Load += ca_cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvfornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txt_buscar;
        private DataGridView dgvfornecedor;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label8;
    }
}