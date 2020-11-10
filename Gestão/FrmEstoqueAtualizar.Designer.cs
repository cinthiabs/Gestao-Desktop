namespace Mais_Pães
{
    partial class FrmEstoqueAtualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoqueAtualizar));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.grupo2 = new System.Windows.Forms.GroupBox();
            this.grupo1.SuspendLayout();
            this.grupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(381, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 34);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.Location = new System.Drawing.Point(283, 163);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(96, 34);
            this.BtnCadastrar.TabIndex = 52;
            this.BtnCadastrar.Text = "Atualizar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // txtdata
            // 
            this.txtdata.AutoSize = true;
            this.txtdata.Location = new System.Drawing.Point(97, 25);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(68, 14);
            this.txtdata.TabIndex = 59;
            this.txtdata.Text = "data / hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 14);
            this.label7.TabIndex = 58;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 14);
            this.label6.TabIndex = 57;
            this.label6.Text = "Valor Unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 56;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Location = new System.Drawing.Point(194, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 55;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 54;
            this.label2.Text = "Data:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(256, 105);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 22);
            this.txttotal.TabIndex = 52;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(91, 103);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 22);
            this.txtvalor.TabIndex = 51;
            this.txtvalor.TextChanged += new System.EventHandler(this.txtvalorunit_TextChanged);
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(89, 59);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(100, 22);
            this.txtquantidade.TabIndex = 49;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(257, 59);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(218, 22);
            this.txtdescricao.TabIndex = 50;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(117, 25);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(265, 22);
            this.txtcod.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 14);
            this.label5.TabIndex = 48;
            this.label5.Text = "Codigo da Compra:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Location = new System.Drawing.Point(388, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 27);
            this.btnPesquisar.TabIndex = 48;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.btnPesquisar);
            this.grupo1.Controls.Add(this.label5);
            this.grupo1.Controls.Add(this.txtcod);
            this.grupo1.Location = new System.Drawing.Point(10, 13);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(485, 66);
            this.grupo1.TabIndex = 60;
            this.grupo1.TabStop = false;
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.txtdata);
            this.grupo2.Controls.Add(this.label7);
            this.grupo2.Controls.Add(this.label6);
            this.grupo2.Controls.Add(this.label4);
            this.grupo2.Controls.Add(this.label3);
            this.grupo2.Controls.Add(this.label2);
            this.grupo2.Controls.Add(this.txttotal);
            this.grupo2.Controls.Add(this.txtvalor);
            this.grupo2.Controls.Add(this.txtquantidade);
            this.grupo2.Controls.Add(this.txtdescricao);
            this.grupo2.Controls.Add(this.btnCancelar);
            this.grupo2.Controls.Add(this.BtnCadastrar);
            this.grupo2.Location = new System.Drawing.Point(10, 85);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(484, 211);
            this.grupo2.TabIndex = 61;
            this.grupo2.TabStop = false;
            // 
            // FrmEstoqueAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 303);
            this.Controls.Add(this.grupo2);
            this.Controls.Add(this.grupo1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEstoqueAtualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Estoque";
            this.Load += new System.EventHandler(this.FrmEstoqueAtualizar_Load);
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label txtdata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.GroupBox grupo2;
    }
}