namespace ReadFromBitCoin
{
    partial class Frm_Home
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
            this.btnMercadoBitCoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMercadoBitCoin
            // 
            this.btnMercadoBitCoin.Location = new System.Drawing.Point(26, 364);
            this.btnMercadoBitCoin.Name = "btnMercadoBitCoin";
            this.btnMercadoBitCoin.Size = new System.Drawing.Size(86, 46);
            this.btnMercadoBitCoin.TabIndex = 0;
            this.btnMercadoBitCoin.Text = "Mercado BitCoin";
            this.btnMercadoBitCoin.UseVisualStyleBackColor = true;
            this.btnMercadoBitCoin.Click += new System.EventHandler(this.btnMercadoBitCoin_Click);
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMercadoBitCoin);
            this.Name = "Frm_Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMercadoBitCoin;
    }
}

