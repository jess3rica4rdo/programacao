namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsoma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valor1 = new System.Windows.Forms.TextBox();
            this.txt_valor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btprincipal = new System.Windows.Forms.Button();
            this.btndivisao = new System.Windows.Forms.Button();
            this.btnmultiplicacao = new System.Windows.Forms.Button();
            this.btnsubtracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsoma
            // 
            this.btnsoma.AccessibleName = "";
            this.btnsoma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsoma.Location = new System.Drawing.Point(12, 129);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(93, 36);
            this.btnsoma.TabIndex = 0;
            this.btnsoma.Text = "Soma";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btexecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "valor1";
            // 
            // txt_valor1
            // 
            this.txt_valor1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valor1.Location = new System.Drawing.Point(76, 31);
            this.txt_valor1.Name = "txt_valor1";
            this.txt_valor1.Size = new System.Drawing.Size(100, 27);
            this.txt_valor1.TabIndex = 2;
            // 
            // txt_valor2
            // 
            this.txt_valor2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valor2.Location = new System.Drawing.Point(281, 31);
            this.txt_valor2.Name = "txt_valor2";
            this.txt_valor2.Size = new System.Drawing.Size(109, 27);
            this.txt_valor2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(214, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "valor2";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_resultado.Location = new System.Drawing.Point(214, 77);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(103, 27);
            this.txt_resultado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(125, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "resultado";
            // 
            // btprincipal
            // 
            this.btprincipal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btprincipal.Location = new System.Drawing.Point(12, 228);
            this.btprincipal.Name = "btprincipal";
            this.btprincipal.Size = new System.Drawing.Size(133, 32);
            this.btprincipal.TabIndex = 7;
            this.btprincipal.Text = "Menu";
            this.btprincipal.UseVisualStyleBackColor = true;
            this.btprincipal.Click += new System.EventHandler(this.btprincipal_Click);
            // 
            // btndivisao
            // 
            this.btndivisao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndivisao.Location = new System.Drawing.Point(175, 186);
            this.btndivisao.Name = "btndivisao";
            this.btndivisao.Size = new System.Drawing.Size(87, 36);
            this.btndivisao.TabIndex = 8;
            this.btndivisao.Text = "Divisão";
            this.btndivisao.UseVisualStyleBackColor = true;
            this.btndivisao.Click += new System.EventHandler(this.btndivisao_Click);
            // 
            // btnmultiplicacao
            // 
            this.btnmultiplicacao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmultiplicacao.Location = new System.Drawing.Point(158, 129);
            this.btnmultiplicacao.Name = "btnmultiplicacao";
            this.btnmultiplicacao.Size = new System.Drawing.Size(123, 36);
            this.btnmultiplicacao.TabIndex = 9;
            this.btnmultiplicacao.Text = "Multiplicação";
            this.btnmultiplicacao.UseVisualStyleBackColor = true;
            this.btnmultiplicacao.Click += new System.EventHandler(this.btnmultiplicacao_Click);
            // 
            // btnsubtracao
            // 
            this.btnsubtracao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsubtracao.Location = new System.Drawing.Point(12, 186);
            this.btnsubtracao.Name = "btnsubtracao";
            this.btnsubtracao.Size = new System.Drawing.Size(97, 36);
            this.btnsubtracao.TabIndex = 10;
            this.btnsubtracao.Text = "Subtração";
            this.btnsubtracao.UseVisualStyleBackColor = true;
            this.btnsubtracao.Click += new System.EventHandler(this.btnsubtracao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(422, 283);
            this.Controls.Add(this.btnsubtracao);
            this.Controls.Add(this.btnmultiplicacao);
            this.Controls.Add(this.btndivisao);
            this.Controls.Add(this.btprincipal);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_valor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_valor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btexecutar;
        private Button btnsoma;
        private Label label1;
        private TextBox txt_valor1;
        private TextBox txt_valor2;
        private Label label2;
        private TextBox txt_resultado;
        private Label label3;
        private Button btprincipal;
        private Button btndivisao;
        private Button btnmultiplicacao;
        private Button btnsubtracao;
    }
}