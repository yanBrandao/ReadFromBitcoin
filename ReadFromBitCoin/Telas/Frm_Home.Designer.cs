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
            this.btnTicker = new System.Windows.Forms.Button();
            this.btnTrades = new System.Windows.Forms.Button();
            this.richTicker = new System.Windows.Forms.RichTextBox();
            this.richTrade = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnTicker
            // 
            this.btnTicker.Location = new System.Drawing.Point(135, 354);
            this.btnTicker.Name = "btnTicker";
            this.btnTicker.Size = new System.Drawing.Size(86, 46);
            this.btnTicker.TabIndex = 0;
            this.btnTicker.Text = "Ticker";
            this.btnTicker.UseVisualStyleBackColor = true;
            this.btnTicker.Click += new System.EventHandler(this.btnMercadoBitCoin_Click);
            // 
            // btnTrades
            // 
            this.btnTrades.Location = new System.Drawing.Point(570, 354);
            this.btnTrades.Name = "btnTrades";
            this.btnTrades.Size = new System.Drawing.Size(86, 46);
            this.btnTrades.TabIndex = 1;
            this.btnTrades.Text = "Trades";
            this.btnTrades.UseVisualStyleBackColor = true;
            this.btnTrades.Click += new System.EventHandler(this.btnTrades_Click);
            // 
            // richTicker
            // 
            this.richTicker.Location = new System.Drawing.Point(12, 27);
            this.richTicker.Name = "richTicker";
            this.richTicker.Size = new System.Drawing.Size(354, 321);
            this.richTicker.TabIndex = 2;
            this.richTicker.Text = "";
            // 
            // richTrade
            // 
            this.richTrade.Location = new System.Drawing.Point(434, 27);
            this.richTrade.Name = "richTrade";
            this.richTrade.Size = new System.Drawing.Size(354, 321);
            this.richTrade.TabIndex = 3;
            this.richTrade.Text = "";
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTrade);
            this.Controls.Add(this.richTicker);
            this.Controls.Add(this.btnTrades);
            this.Controls.Add(this.btnTicker);
            this.Name = "Frm_Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTicker;
        private System.Windows.Forms.Button btnTrades;
        private System.Windows.Forms.RichTextBox richTicker;
        private System.Windows.Forms.RichTextBox richTrade;
    }
}

