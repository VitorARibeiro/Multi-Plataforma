namespace Teste1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCesar = new System.Windows.Forms.Button();
            this.LabelFim = new System.Windows.Forms.Label();
            this.ButtonFaria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCesar
            // 
            this.buttonCesar.Location = new System.Drawing.Point(30, 51);
            this.buttonCesar.Name = "buttonCesar";
            this.buttonCesar.Size = new System.Drawing.Size(228, 97);
            this.buttonCesar.TabIndex = 0;
            this.buttonCesar.Text = "Cesar";
            this.buttonCesar.UseVisualStyleBackColor = true;
            this.buttonCesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelFim
            // 
            this.LabelFim.AutoSize = true;
            this.LabelFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LabelFim.Location = new System.Drawing.Point(273, 287);
            this.LabelFim.Name = "LabelFim";
            this.LabelFim.Size = new System.Drawing.Size(212, 63);
            this.LabelFim.TabIndex = 1;
            this.LabelFim.Text = "Quelica";
            this.LabelFim.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonFaria
            // 
            this.ButtonFaria.Location = new System.Drawing.Point(503, 51);
            this.ButtonFaria.Name = "ButtonFaria";
            this.ButtonFaria.Size = new System.Drawing.Size(228, 97);
            this.ButtonFaria.TabIndex = 2;
            this.ButtonFaria.Text = "Faria";
            this.ButtonFaria.UseVisualStyleBackColor = true;
            this.ButtonFaria.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonFaria);
            this.Controls.Add(this.LabelFim);
            this.Controls.Add(this.buttonCesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCesar;
        private System.Windows.Forms.Label LabelFim;
        private System.Windows.Forms.Button ButtonFaria;
    }
}

