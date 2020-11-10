namespace Mais_Pães
{
    partial class FrmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.Label();
            this.Vendas = new System.Windows.Forms.Label();
            this.Produtos = new System.Windows.Forms.Label();
            this.Compras = new System.Windows.Forms.Label();
            this.Lucros = new System.Windows.Forms.Label();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.lblTotalProduto = new System.Windows.Forms.Label();
            this.lblTotalcompra = new System.Windows.Forms.Label();
            this.lblLucro = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Location = new System.Drawing.Point(15, 447);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(119, 38);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(792, 334);
            this.dataGridView.TabIndex = 1;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Total.Location = new System.Drawing.Point(12, 365);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(104, 13);
            this.Total.TabIndex = 2;
            this.Total.Text = "TOTAL (ANUAL):";
            // 
            // Vendas
            // 
            this.Vendas.AutoSize = true;
            this.Vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendas.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Vendas.Location = new System.Drawing.Point(136, 365);
            this.Vendas.Name = "Vendas";
            this.Vendas.Size = new System.Drawing.Size(61, 13);
            this.Vendas.TabIndex = 3;
            this.Vendas.Text = "VENDAS ";
            // 
            // Produtos
            // 
            this.Produtos.AutoSize = true;
            this.Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produtos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Produtos.Location = new System.Drawing.Point(235, 365);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(80, 13);
            this.Produtos.TabIndex = 4;
            this.Produtos.Text = "PRODUTOS ";
            // 
            // Compras
            // 
            this.Compras.AutoSize = true;
            this.Compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compras.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Compras.Location = new System.Drawing.Point(336, 365);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(71, 13);
            this.Compras.TabIndex = 5;
            this.Compras.Text = "COMPRAS ";
            // 
            // Lucros
            // 
            this.Lucros.AutoSize = true;
            this.Lucros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lucros.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Lucros.Location = new System.Drawing.Point(441, 365);
            this.Lucros.Name = "Lucros";
            this.Lucros.Size = new System.Drawing.Size(53, 13);
            this.Lucros.TabIndex = 6;
            this.Lucros.Text = "LUCRO ";
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendas.Location = new System.Drawing.Point(139, 404);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(77, 16);
            this.lblTotalVendas.TabIndex = 7;
            this.lblTotalVendas.Text = "NUMEROS";
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.AutoSize = true;
            this.lblTotalProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProduto.Location = new System.Drawing.Point(237, 404);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(77, 16);
            this.lblTotalProduto.TabIndex = 8;
            this.lblTotalProduto.Text = "NUMEROS";
            // 
            // lblTotalcompra
            // 
            this.lblTotalcompra.AutoSize = true;
            this.lblTotalcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalcompra.Location = new System.Drawing.Point(341, 404);
            this.lblTotalcompra.Name = "lblTotalcompra";
            this.lblTotalcompra.Size = new System.Drawing.Size(77, 16);
            this.lblTotalcompra.TabIndex = 9;
            this.lblTotalcompra.Text = "NUMEROS";
            // 
            // lblLucro
            // 
            this.lblLucro.AutoSize = true;
            this.lblLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucro.Location = new System.Drawing.Point(443, 404);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(77, 16);
            this.lblLucro.TabIndex = 10;
            this.lblLucro.Text = "NUMEROS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "_________________________________________________________________________________" +
    "__";
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLucro);
            this.Controls.Add(this.lblTotalcompra);
            this.Controls.Add(this.lblTotalProduto);
            this.Controls.Add(this.lblTotalVendas);
            this.Controls.Add(this.Lucros);
            this.Controls.Add(this.Compras);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.Vendas);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.BtnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Relatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Vendas;
        private System.Windows.Forms.Label Produtos;
        private System.Windows.Forms.Label Compras;
        private System.Windows.Forms.Label Lucros;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Label lblTotalProduto;
        private System.Windows.Forms.Label lblTotalcompra;
        private System.Windows.Forms.Label lblLucro;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}