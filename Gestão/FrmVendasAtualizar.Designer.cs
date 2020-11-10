namespace Mais_Pães
{
    partial class FrmVendasAtualizar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendasAtualizar));
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.combocategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.grupo2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grupo1.SuspendLayout();
            this.grupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Location = new System.Drawing.Point(434, 170);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(96, 32);
            this.btncancelar.TabIndex = 26;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadastrar.Location = new System.Drawing.Point(336, 170);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(96, 32);
            this.btncadastrar.TabIndex = 25;
            this.btncadastrar.Text = "Atualizar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // combocategoria
            // 
            this.combocategoria.FormattingEnabled = true;
            this.combocategoria.Location = new System.Drawing.Point(79, 116);
            this.combocategoria.Name = "combocategoria";
            this.combocategoria.Size = new System.Drawing.Size(112, 21);
            this.combocategoria.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cod. Produto:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(425, 117);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 24;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(253, 117);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 23;
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(427, 61);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(98, 20);
            this.txtquantidade.TabIndex = 21;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(253, 61);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(100, 20);
            this.txtcliente.TabIndex = 20;
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(79, 61);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(112, 20);
            this.txtproduto.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Codigo da Venda:";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(110, 25);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(316, 20);
            this.txtcod.TabIndex = 17;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpesquisar.Location = new System.Drawing.Point(431, 22);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(76, 25);
            this.btnpesquisar.TabIndex = 18;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtdata
            // 
            this.txtdata.AutoSize = true;
            this.txtdata.Location = new System.Drawing.Point(69, 22);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(54, 13);
            this.txtdata.TabIndex = 37;
            this.txtdata.Text = "data/hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.btnpesquisar);
            this.grupo1.Controls.Add(this.label8);
            this.grupo1.Controls.Add(this.txtcod);
            this.grupo1.Location = new System.Drawing.Point(7, 8);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(541, 78);
            this.grupo1.TabIndex = 38;
            this.grupo1.TabStop = false;
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.label9);
            this.grupo2.Controls.Add(this.txtdata);
            this.grupo2.Controls.Add(this.btncancelar);
            this.grupo2.Controls.Add(this.btncadastrar);
            this.grupo2.Controls.Add(this.label2);
            this.grupo2.Controls.Add(this.combocategoria);
            this.grupo2.Controls.Add(this.label7);
            this.grupo2.Controls.Add(this.label6);
            this.grupo2.Controls.Add(this.label5);
            this.grupo2.Controls.Add(this.label4);
            this.grupo2.Controls.Add(this.label3);
            this.grupo2.Controls.Add(this.label1);
            this.grupo2.Controls.Add(this.txttotal);
            this.grupo2.Controls.Add(this.txtpreco);
            this.grupo2.Controls.Add(this.txtquantidade);
            this.grupo2.Controls.Add(this.txtcliente);
            this.grupo2.Controls.Add(this.txtproduto);
            this.grupo2.Location = new System.Drawing.Point(9, 92);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(540, 217);
            this.grupo2.TabIndex = 39;
            this.grupo2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(252, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = "*Não obrigatorio";
            // 
            // FrmVendasAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 327);
            this.Controls.Add(this.grupo2);
            this.Controls.Add(this.grupo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVendasAtualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Venda";
            this.Load += new System.EventHandler(this.FrmVendasAtualizar_Load);
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.ComboBox combocategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Label txtdata;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.GroupBox grupo2;
        private System.Windows.Forms.Label label9;
    }
}