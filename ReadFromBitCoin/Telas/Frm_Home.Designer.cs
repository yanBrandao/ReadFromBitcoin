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
            this.components = new System.ComponentModel.Container();
            this.btnTicker = new System.Windows.Forms.Button();
            this.btnTrades = new System.Windows.Forms.Button();
            this.richTicker = new System.Windows.Forms.RichTextBox();
            this.richTrade = new System.Windows.Forms.RichTextBox();
            this.gbModelo = new System.Windows.Forms.GroupBox();
            this.lbScroll = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.gbModelo.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.richTicker.Location = new System.Drawing.Point(12, 135);
            this.richTicker.Name = "richTicker";
            this.richTicker.Size = new System.Drawing.Size(354, 213);
            this.richTicker.TabIndex = 2;
            this.richTicker.Text = "";
            // 
            // richTrade
            // 
            this.richTrade.Location = new System.Drawing.Point(434, 135);
            this.richTrade.Name = "richTrade";
            this.richTrade.Size = new System.Drawing.Size(354, 213);
            this.richTrade.TabIndex = 3;
            this.richTrade.Text = "";
            // 
            // gbModelo
            // 
            this.gbModelo.Controls.Add(this.panel1);
            this.gbModelo.Location = new System.Drawing.Point(13, 13);
            this.gbModelo.Name = "gbModelo";
            this.gbModelo.Size = new System.Drawing.Size(775, 100);
            this.gbModelo.TabIndex = 4;
            this.gbModelo.TabStop = false;
            this.gbModelo.Text = "Treinamento";
            // 
            // lbScroll
            // 
            this.lbScroll.AutoSize = true;
            this.lbScroll.Location = new System.Drawing.Point(41, 13);
            this.lbScroll.Name = "lbScroll";
            this.lbScroll.Size = new System.Drawing.Size(0, 13);
            this.lbScroll.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.lbScroll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 81);
            this.panel1.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(752, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 81);
            this.vScrollBar1.TabIndex = 1;
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbModelo);
            this.Controls.Add(this.richTrade);
            this.Controls.Add(this.richTicker);
            this.Controls.Add(this.btnTrades);
            this.Controls.Add(this.btnTicker);
            this.Name = "Frm_Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Home_Load);
            this.gbModelo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTicker;
        private System.Windows.Forms.Button btnTrades;
        private System.Windows.Forms.RichTextBox richTicker;
        private System.Windows.Forms.RichTextBox richTrade;
        private System.Windows.Forms.GroupBox gbModelo;
        private System.Windows.Forms.Label lbScroll;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

