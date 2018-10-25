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
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScroll = new System.Windows.Forms.VScrollBar();
            this.lbScroll = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gbModelo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTicker
            // 
            this.btnTicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTicker.Location = new System.Drawing.Point(0, 283);
            this.btnTicker.Name = "btnTicker";
            this.btnTicker.Size = new System.Drawing.Size(449, 46);
            this.btnTicker.TabIndex = 0;
            this.btnTicker.Text = "Ticker";
            this.btnTicker.UseVisualStyleBackColor = true;
            this.btnTicker.Click += new System.EventHandler(this.btnMercadoBitCoin_Click);
            // 
            // btnTrades
            // 
            this.btnTrades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTrades.Location = new System.Drawing.Point(0, 283);
            this.btnTrades.Name = "btnTrades";
            this.btnTrades.Size = new System.Drawing.Size(503, 46);
            this.btnTrades.TabIndex = 1;
            this.btnTrades.Text = "Trades";
            this.btnTrades.UseVisualStyleBackColor = true;
            this.btnTrades.Click += new System.EventHandler(this.btnTrades_Click);
            // 
            // richTicker
            // 
            this.richTicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTicker.Location = new System.Drawing.Point(0, 0);
            this.richTicker.Name = "richTicker";
            this.richTicker.Size = new System.Drawing.Size(449, 283);
            this.richTicker.TabIndex = 2;
            this.richTicker.Text = "";
            // 
            // richTrade
            // 
            this.richTrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTrade.Location = new System.Drawing.Point(0, 0);
            this.richTrade.Name = "richTrade";
            this.richTrade.Size = new System.Drawing.Size(503, 283);
            this.richTrade.TabIndex = 3;
            this.richTrade.Text = "";
            // 
            // gbModelo
            // 
            this.gbModelo.Controls.Add(this.panel1);
            this.gbModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbModelo.Location = new System.Drawing.Point(0, 0);
            this.gbModelo.Name = "gbModelo";
            this.gbModelo.Size = new System.Drawing.Size(997, 235);
            this.gbModelo.TabIndex = 4;
            this.gbModelo.TabStop = false;
            this.gbModelo.Text = "Treinamento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vScroll);
            this.panel1.Controls.Add(this.lbScroll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 216);
            this.panel1.TabIndex = 1;
            // 
            // vScroll
            // 
            this.vScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScroll.Location = new System.Drawing.Point(974, 0);
            this.vScroll.Name = "vScroll";
            this.vScroll.Size = new System.Drawing.Size(17, 216);
            this.vScroll.TabIndex = 1;
            // 
            // lbScroll
            // 
            this.lbScroll.AutoSize = true;
            this.lbScroll.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbScroll.Location = new System.Drawing.Point(0, 0);
            this.lbScroll.Name = "lbScroll";
            this.lbScroll.Size = new System.Drawing.Size(0, 13);
            this.lbScroll.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnTicker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 329);
            this.panel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.richTicker);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(449, 283);
            this.panel6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.btnTrades);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(494, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 329);
            this.panel3.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.richTrade);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(503, 283);
            this.panel7.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gbModelo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(997, 235);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 235);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(997, 329);
            this.panel5.TabIndex = 8;
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 564);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "Frm_Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Home_Load);
            this.gbModelo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.VScrollBar vScroll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

