namespace aula
{
    partial class Relatório
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
            this.txt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ok
            // 
            this.txt_ok.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ok.Location = new System.Drawing.Point(254, 275);
            this.txt_ok.Name = "txt_ok";
            this.txt_ok.Size = new System.Drawing.Size(84, 28);
            this.txt_ok.TabIndex = 0;
            this.txt_ok.Text = "Ok";
            this.txt_ok.UseVisualStyleBackColor = true;
            this.txt_ok.Click += new System.EventHandler(this.txt_ok_Click);
            // 
            // Relatório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 334);
            this.Controls.Add(this.txt_ok);
            this.Name = "Relatório";
            this.Text = "Relatório";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txt_ok;
    }
}