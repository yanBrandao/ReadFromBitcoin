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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbHistorico = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDias = new System.Windows.Forms.Label();
            this.lbTransacoes = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbSimulação = new System.Windows.Forms.Label();
            this.lbCarteira = new System.Windows.Forms.Label();
            this.lbMoedas = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.graficoCarteira = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbModelo.SuspendLayout();
            this.pTreinamento.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCarteira)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTicker
            // 
            this.btnTicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTicker.Location = new System.Drawing.Point(0, 209);
            this.btnTicker.Name = "btnTicker";
            this.btnTicker.Size = new System.Drawing.Size(281, 46);
            this.btnTicker.TabIndex = 0;
            this.btnTicker.Text = "Ticker";
            this.btnTicker.UseVisualStyleBackColor = true;
            this.btnTicker.Click += new System.EventHandler(this.btnMercadoBitCoin_Click);
            // 
            // btnTrades
            // 
            this.btnTrades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTrades.Location = new System.Drawing.Point(0, 209);
            this.btnTrades.Name = "btnTrades";
            this.btnTrades.Size = new System.Drawing.Size(332, 46);
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
            this.richTicker.Size = new System.Drawing.Size(281, 209);
            this.richTicker.TabIndex = 2;
            this.richTicker.Text = "";
            this.richTicker.TextChanged += new System.EventHandler(this.richTicker_TextChanged);
            // 
            // richTrade
            // 
            this.richTrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTrade.Location = new System.Drawing.Point(0, 0);
            this.richTrade.Name = "richTrade";
            this.richTrade.Size = new System.Drawing.Size(332, 209);
            this.richTrade.TabIndex = 3;
            this.richTrade.Text = "";
            this.richTrade.TextChanged += new System.EventHandler(this.richTrade_TextChanged);
            // 
            // gbModelo
            // 
            this.gbModelo.Controls.Add(this.pTreinamento);
            this.gbModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbModelo.Location = new System.Drawing.Point(0, 0);
            this.gbModelo.Name = "gbModelo";
            this.gbModelo.Size = new System.Drawing.Size(1073, 213);
            this.gbModelo.TabIndex = 4;
            this.gbModelo.TabStop = false;
            this.gbModelo.Text = "Treinamento";
            // 
            // pTreinamento
            // 
            this.pTreinamento.Controls.Add(this.lbScroll);
            this.pTreinamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTreinamento.Location = new System.Drawing.Point(3, 16);
            this.pTreinamento.Name = "pTreinamento";
            this.pTreinamento.Size = new System.Drawing.Size(1067, 194);
            this.pTreinamento.TabIndex = 1;
            // 
            // lbScroll
            // 
            this.lbScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbScroll.FormattingEnabled = true;
            this.lbScroll.Location = new System.Drawing.Point(0, 0);
            this.lbScroll.Margin = new System.Windows.Forms.Padding(2);
            this.lbScroll.Name = "lbScroll";
            this.lbScroll.Size = new System.Drawing.Size(1067, 194);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 255);
            this.panel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.richTicker);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 209);
            this.panel6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.btnTrades);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(741, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 255);
            this.panel3.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.richTrade);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(332, 209);
            this.panel7.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gbModelo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1073, 213);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 520);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1073, 255);
            this.panel5.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(281, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(460, 255);
            this.panel8.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(460, 255);
            this.panel9.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lbHistorico);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 100);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(460, 155);
            this.panel11.TabIndex = 8;
            // 
            // lbHistorico
            // 
            this.lbHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHistorico.Location = new System.Drawing.Point(0, 0);
            this.lbHistorico.Name = "lbHistorico";
            this.lbHistorico.Size = new System.Drawing.Size(460, 155);
            this.lbHistorico.TabIndex = 4;
            this.lbHistorico.UseCompatibleStateImageBehavior = false;
            this.lbHistorico.View = System.Windows.Forms.View.List;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDias);
            this.panel1.Controls.Add(this.lbTransacoes);
            this.panel1.Controls.Add(this.lbHora);
            this.panel1.Controls.Add(this.lbSimulação);
            this.panel1.Controls.Add(this.lbCarteira);
            this.panel1.Controls.Add(this.lbMoedas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 100);
            this.panel1.TabIndex = 7;
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDias.Location = new System.Drawing.Point(0, 52);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(110, 13);
            this.lbDias.TabIndex = 7;
            this.lbDias.Text = "Dias contabilizados: 0";
            // 
            // lbTransacoes
            // 
            this.lbTransacoes.AutoSize = true;
            this.lbTransacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTransacoes.Location = new System.Drawing.Point(0, 39);
            this.lbTransacoes.Name = "lbTransacoes";
            this.lbTransacoes.Size = new System.Drawing.Size(148, 13);
            this.lbTransacoes.TabIndex = 6;
            this.lbTransacoes.Text = "Quantidade de Transações: 0";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHora.Location = new System.Drawing.Point(0, 26);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(40, 13);
            this.lbHora.TabIndex = 5;
            this.lbHora.Text = "Início: ";
            // 
            // lbSimulação
            // 
            this.lbSimulação.AutoSize = true;
            this.lbSimulação.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbSimulação.Location = new System.Drawing.Point(368, 26);
            this.lbSimulação.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSimulação.Name = "lbSimulação";
            this.lbSimulação.Size = new System.Drawing.Size(92, 13);
            this.lbSimulação.TabIndex = 0;
            this.lbSimulação.Text = "Simulação Moeda";
            this.lbSimulação.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCarteira
            // 
            this.lbCarteira.AutoSize = true;
            this.lbCarteira.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCarteira.Location = new System.Drawing.Point(0, 13);
            this.lbCarteira.Margin = new System.Windows.Forms.Padding(2, 0, 2, 6);
            this.lbCarteira.Name = "lbCarteira";
            this.lbCarteira.Size = new System.Drawing.Size(81, 13);
            this.lbCarteira.TabIndex = 1;
            this.lbCarteira.Text = "Carteira: R$ 0.0";
            // 
            // lbMoedas
            // 
            this.lbMoedas.AutoSize = true;
            this.lbMoedas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMoedas.Location = new System.Drawing.Point(0, 0);
            this.lbMoedas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 6);
            this.lbMoedas.Name = "lbMoedas";
            this.lbMoedas.Size = new System.Drawing.Size(139, 13);
            this.lbMoedas.TabIndex = 2;
            this.lbMoedas.Text = "Quantidade de Moedas: 0.0";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.graficoCarteira);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 213);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1073, 307);
            this.panel10.TabIndex = 6;
            // 
            // graficoCarteira
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoCarteira.ChartAreas.Add(chartArea1);
            this.graficoCarteira.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.graficoCarteira.Legends.Add(legend1);
            this.graficoCarteira.Location = new System.Drawing.Point(0, 0);
            this.graficoCarteira.Name = "graficoCarteira";
            this.graficoCarteira.Size = new System.Drawing.Size(1073, 307);
            this.graficoCarteira.TabIndex = 0;
            this.graficoCarteira.Text = "Fluxo da Carteira";
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 775);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
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
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graficoCarteira)).EndInit();
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
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbSimulação;
        private System.Windows.Forms.Label lbMoedas;
        private System.Windows.Forms.Label lbCarteira;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ListView lbHistorico;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoCarteira;
        private System.Windows.Forms.Label lbTransacoes;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lbDias;
    }
}

