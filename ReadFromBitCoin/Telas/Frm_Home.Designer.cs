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
            this.pTreinamento = new System.Windows.Forms.Panel();
            this.lbScroll = new System.Windows.Forms.ListBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbSimulação = new System.Windows.Forms.Label();
            this.lbCarteira = new System.Windows.Forms.Label();
            this.lbMoedas = new System.Windows.Forms.Label();
            this.lbHistorico = new System.Windows.Forms.ListBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.gbModelo.SuspendLayout();
            this.pTreinamento.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTicker
            // 
            this.btnTicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTicker.Location = new System.Drawing.Point(0, 516);
            this.btnTicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTicker.Name = "btnTicker";
            this.btnTicker.Size = new System.Drawing.Size(577, 71);
            this.btnTicker.TabIndex = 0;
            this.btnTicker.Text = "Ticker";
            this.btnTicker.UseVisualStyleBackColor = true;
            this.btnTicker.Click += new System.EventHandler(this.btnMercadoBitCoin_Click);
            // 
            // btnTrades
            // 
            this.btnTrades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTrades.Location = new System.Drawing.Point(0, 516);
            this.btnTrades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrades.Name = "btnTrades";
            this.btnTrades.Size = new System.Drawing.Size(650, 71);
            this.btnTrades.TabIndex = 1;
            this.btnTrades.Text = "Trades";
            this.btnTrades.UseVisualStyleBackColor = true;
            this.btnTrades.Click += new System.EventHandler(this.btnTrades_Click);
            // 
            // richTicker
            // 
            this.richTicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTicker.Location = new System.Drawing.Point(0, 0);
            this.richTicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTicker.Name = "richTicker";
            this.richTicker.Size = new System.Drawing.Size(577, 516);
            this.richTicker.TabIndex = 2;
            this.richTicker.Text = "";
            this.richTicker.TextChanged += new System.EventHandler(this.richTicker_TextChanged);
            // 
            // richTrade
            // 
            this.richTrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTrade.Location = new System.Drawing.Point(0, 0);
            this.richTrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTrade.Name = "richTrade";
            this.richTrade.Size = new System.Drawing.Size(650, 516);
            this.richTrade.TabIndex = 3;
            this.richTrade.Text = "";
            this.richTrade.TextChanged += new System.EventHandler(this.richTrade_TextChanged);
            // 
            // gbModelo
            // 
            this.gbModelo.Controls.Add(this.pTreinamento);
            this.gbModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbModelo.Location = new System.Drawing.Point(0, 0);
            this.gbModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbModelo.Name = "gbModelo";
            this.gbModelo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbModelo.Size = new System.Drawing.Size(1496, 273);
            this.gbModelo.TabIndex = 4;
            this.gbModelo.TabStop = false;
            this.gbModelo.Text = "Treinamento";
            // 
            // pTreinamento
            // 
            this.pTreinamento.Controls.Add(this.lbScroll);
            this.pTreinamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTreinamento.Location = new System.Drawing.Point(4, 24);
            this.pTreinamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pTreinamento.Name = "pTreinamento";
            this.pTreinamento.Size = new System.Drawing.Size(1488, 244);
            this.pTreinamento.TabIndex = 1;
            // 
            // lbScroll
            // 
            this.lbScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbScroll.FormattingEnabled = true;
            this.lbScroll.ItemHeight = 20;
            this.lbScroll.Location = new System.Drawing.Point(0, 0);
            this.lbScroll.Name = "lbScroll";
            this.lbScroll.Size = new System.Drawing.Size(1488, 244);
            this.lbScroll.TabIndex = 0;
            this.lbScroll.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.lbScroll_ControlAdded);
            this.lbScroll.MouseHover += new System.EventHandler(this.lbScroll_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnTicker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 587);
            this.panel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.richTicker);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(577, 516);
            this.panel6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.btnTrades);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(846, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 587);
            this.panel3.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.richTrade);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(650, 516);
            this.panel7.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1496, 868);
            this.panel4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbModelo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1496, 273);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 281);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1496, 587);
            this.panel5.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.lbMoedas);
            this.panel8.Controls.Add(this.lbCarteira);
            this.panel8.Controls.Add(this.lbSimulação);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(577, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(269, 587);
            this.panel8.TabIndex = 7;
            // 
            // lbSimulação
            // 
            this.lbSimulação.AutoSize = true;
            this.lbSimulação.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSimulação.Location = new System.Drawing.Point(0, 0);
            this.lbSimulação.Name = "lbSimulação";
            this.lbSimulação.Size = new System.Drawing.Size(136, 20);
            this.lbSimulação.TabIndex = 0;
            this.lbSimulação.Text = "Simulação Moeda";
            this.lbSimulação.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCarteira
            // 
            this.lbCarteira.AutoSize = true;
            this.lbCarteira.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCarteira.Location = new System.Drawing.Point(0, 20);
            this.lbCarteira.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbCarteira.Name = "lbCarteira";
            this.lbCarteira.Size = new System.Drawing.Size(120, 20);
            this.lbCarteira.TabIndex = 1;
            this.lbCarteira.Text = "Carteira: R$ 0.0";
            // 
            // lbMoedas
            // 
            this.lbMoedas.AutoSize = true;
            this.lbMoedas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMoedas.Location = new System.Drawing.Point(0, 40);
            this.lbMoedas.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbMoedas.Name = "lbMoedas";
            this.lbMoedas.Size = new System.Drawing.Size(205, 20);
            this.lbMoedas.TabIndex = 2;
            this.lbMoedas.Text = "Quantidade de Moedas: 0.0";
            // 
            // lbHistorico
            // 
            this.lbHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHistorico.FormattingEnabled = true;
            this.lbHistorico.ItemHeight = 20;
            this.lbHistorico.Location = new System.Drawing.Point(0, 0);
            this.lbHistorico.Name = "lbHistorico";
            this.lbHistorico.Size = new System.Drawing.Size(269, 527);
            this.lbHistorico.TabIndex = 3;
            this.lbHistorico.SelectedIndexChanged += new System.EventHandler(this.lbHistorico_SelectedIndexChanged);
            this.lbHistorico.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.lbHistorico_ControlAdded);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbHistorico);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(269, 527);
            this.panel9.TabIndex = 4;
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 868);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Home_Load);
            this.gbModelo.ResumeLayout(false);
            this.pTreinamento.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTicker;
        private System.Windows.Forms.Button btnTrades;
        private System.Windows.Forms.RichTextBox richTicker;
        private System.Windows.Forms.RichTextBox richTrade;
        private System.Windows.Forms.GroupBox gbModelo;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pTreinamento;
        private System.Windows.Forms.ListBox lbScroll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbSimulação;
        private System.Windows.Forms.Label lbMoedas;
        private System.Windows.Forms.Label lbCarteira;
        private System.Windows.Forms.ListBox lbHistorico;
        private System.Windows.Forms.Panel panel9;
    }
}

