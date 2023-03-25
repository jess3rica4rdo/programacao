namespace SIG_FARMACIA
{
    partial class Estoque
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
            this.btvoltar = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btexportar = new System.Windows.Forms.Button();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpesqu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btvoltar
            // 
            this.btvoltar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btvoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.ForeColor = System.Drawing.Color.White;
            this.btvoltar.Location = new System.Drawing.Point(0, 0);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(116, 30);
            this.btvoltar.TabIndex = 101;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = false;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.Gray;
            this.btsair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.ForeColor = System.Drawing.Color.White;
            this.btsair.Location = new System.Drawing.Point(770, 79);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(100, 32);
            this.btsair.TabIndex = 100;
            this.btsair.Text = "Sair ";
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(30, 127);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(840, 456);
            this.dataGridView1.TabIndex = 98;
            // 
            // btexportar
            // 
            this.btexportar.BackColor = System.Drawing.Color.Gray;
            this.btexportar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexportar.ForeColor = System.Drawing.Color.White;
            this.btexportar.Location = new System.Drawing.Point(602, 79);
            this.btexportar.Name = "btexportar";
            this.btexportar.Size = new System.Drawing.Size(160, 32);
            this.btexportar.TabIndex = 99;
            this.btexportar.Text = "Exportar p/ Excel";
            this.btexportar.UseVisualStyleBackColor = false;
            this.btexportar.Click += new System.EventHandler(this.btexportar_Click);
            // 
            // btpesquisar
            // 
            this.btpesquisar.BackColor = System.Drawing.Color.Gray;
            this.btpesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.ForeColor = System.Drawing.Color.White;
            this.btpesquisar.Location = new System.Drawing.Point(394, 79);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(182, 32);
            this.btpesquisar.TabIndex = 96;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = false;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(510, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 50);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "...";
            // 
            // txtpesqu
            // 
            this.txtpesqu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesqu.Location = new System.Drawing.Point(30, 82);
            this.txtpesqu.Name = "txtpesqu";
            this.txtpesqu.Size = new System.Drawing.Size(358, 27);
            this.txtpesqu.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 23);
            this.label1.TabIndex = 95;
            this.label1.Text = "Pesquisar por Nome do Fármaco";
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(908, 605);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btexportar);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtpesqu);
            this.Controls.Add(this.label1);
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btexportar;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpesqu;
        private System.Windows.Forms.Label label1;
    }
}