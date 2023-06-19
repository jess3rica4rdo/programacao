namespace Sistema_de_gestão
{
    partial class pes_produto1
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
            dgvproduto = new DataGridView();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            txt_pes = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvproduto).BeginInit();
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
            iconButton1.Location = new Point(306, 14);
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
            txt_buscar.Location = new Point(132, 13);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(128, 22);
            txt_buscar.TabIndex = 68;
            // 
            // dgvproduto
            // 
            dgvproduto.AllowUserToAddRows = false;
            dgvproduto.AllowUserToOrderColumns = true;
            dgvproduto.BackgroundColor = Color.White;
            dgvproduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproduto.Location = new Point(16, 50);
            dgvproduto.MultiSelect = false;
            dgvproduto.Name = "dgvproduto";
            dgvproduto.ReadOnly = true;
            dgvproduto.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ActiveCaption;
            dgvproduto.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvproduto.RowTemplate.Height = 25;
            dgvproduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvproduto.Size = new Size(438, 203);
            dgvproduto.TabIndex = 70;
            dgvproduto.CellDoubleClick += dgvproduto_CellDoubleClick;
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
            iconButton2.Location = new Point(432, 7);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(22, 21);
            iconButton2.TabIndex = 76;
            iconButton2.Text = "X";
            iconButton2.TextAlign = ContentAlignment.TopRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
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
            txt_pes.Location = new Point(266, 13);
            txt_pes.Name = "txt_pes";
            txt_pes.Size = new Size(34, 25);
            txt_pes.TabIndex = 75;
            txt_pes.TextImageRelation = TextImageRelation.ImageAboveText;
            txt_pes.UseVisualStyleBackColor = false;
            txt_pes.Click += txt_pes_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(45, 66, 91);
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(16, 13);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 77;
            label8.Text = "Pesquisar por:";
            // 
            // pes_produto1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(469, 274);
            Controls.Add(label8);
            Controls.Add(iconButton2);
            Controls.Add(txt_pes);
            Controls.Add(iconButton1);
            Controls.Add(txt_buscar);
            Controls.Add(dgvproduto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pes_produto1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ca_produto";
            Load += ca_produto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvproduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txt_buscar;
        private DataGridView dgvproduto;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton txt_pes;
        private Label label8;
    }
}