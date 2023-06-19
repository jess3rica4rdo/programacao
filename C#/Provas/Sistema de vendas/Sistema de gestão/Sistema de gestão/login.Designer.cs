namespace Sistema_de_gestão
{
    partial class login
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
            label1 = new Label();
            btn_cancelar = new FontAwesome.Sharp.IconButton();
            btn_entrar = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txt_senha = new TextBox();
            label4 = new Label();
            txt_usuario = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 216);
            label1.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Red;
            btn_cancelar.FlatStyle = FlatStyle.Popup;
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            btn_cancelar.IconColor = Color.White;
            btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancelar.IconSize = 18;
            btn_cancelar.Location = new Point(238, 173);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 27);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.SteelBlue;
            btn_entrar.FlatStyle = FlatStyle.Popup;
            btn_entrar.ForeColor = Color.White;
            btn_entrar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btn_entrar.IconColor = Color.White;
            btn_entrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_entrar.IconSize = 18;
            btn_entrar.Location = new Point(359, 173);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(86, 27);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "Entrar";
            btn_entrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 124;
            iconPictureBox1.Location = new Point(40, 33);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(128, 124);
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SteelBlue;
            label5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(8, 149);
            label5.Name = "label5";
            label5.Size = new Size(198, 24);
            label5.TabIndex = 9;
            label5.Text = "Sistema de vendas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_senha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_usuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox1.Location = new Point(221, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 144);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOGIN";
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(17, 102);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(207, 23);
            txt_senha.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 79);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 12;
            label4.Text = "Senha";
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(17, 49);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(207, 23);
            txt_usuario.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 26);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 9;
            label2.Text = "Usuário";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(480, 216);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(iconPictureBox1);
            Controls.Add(btn_entrar);
            Controls.Add(btn_cancelar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private FontAwesome.Sharp.IconButton btn_entrar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private Label label4;
        private Label label2;
        private TextBox txt_senha;
        private TextBox txt_usuario;
    }
}