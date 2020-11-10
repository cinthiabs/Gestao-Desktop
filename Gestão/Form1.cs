using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mais_Pães
{
    public partial class FrmMenu : Form
    {
        private SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void gerarRelatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio frmRelatorio = new FrmRelatorio();
            frmRelatorio.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutoCadastrar produtoCadastrar = new FrmProdutoCadastrar();
            produtoCadastrar.Show();
        }

        private void cadastrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendasCadastrar frmVendasCadastrar = new FrmVendasCadastrar();
            frmVendasCadastrar.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutoAtualizar frmProdutoAtualizar = new FrmProdutoAtualizar();
            frmProdutoAtualizar.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutoPesquisar frmProdutoPesquisar = new FrmProdutoPesquisar();
            frmProdutoPesquisar.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutoExcluir frmProdutoExcluir = new FrmProdutoExcluir();
            frmProdutoExcluir.Show();
        }

        private void atualizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendasAtualizar frmVendasAtualizar = new FrmVendasAtualizar();
            frmVendasAtualizar.Show();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVendasPesquisar frmVendasPesquisar = new FrmVendasPesquisar();
            frmVendasPesquisar.Show();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVendasExcluir frmVendasExcluir = new FrmVendasExcluir();
            frmVendasExcluir.Show();
        }

        private void cadastrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstoque frmEstoque = new FrmEstoque();
            frmEstoque.Show();
        }

        private void atualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEstoqueAtualizar frmEstoqueAtualizar = new FrmEstoqueAtualizar();
            frmEstoqueAtualizar.Show();

        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEstoquePesquisar frmEstoquePesquisar = new FrmEstoquePesquisar();
            frmEstoquePesquisar.Show();
        }

        private void excluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEstoqueExcluir frmEstoque = new FrmEstoqueExcluir();
            frmEstoque.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {

                this.Close();
            }
          
        }

        
        private void lblTotalVendas_Click(object sender, EventArgs e)
        {

        }
        private void totalvendas()
        {
            SqlCommand totalVendas = new SqlCommand("SELECT SUM(TOTAL) AS'VENDAS' FROM CLIENTEVENDAS  SELECT FORMAT(DATA, 'dd/MM/yyyy HH:mm:ss') from CLIENTEVENDAS where CAST(data as date) between CAST(DATEADD(day, -30,GETDATE()) as date)and cast(GETDATE() as date)", banco);

            banco.Open();
            lblTotalVendas.Text = totalVendas.ExecuteScalar().ToString();
            banco.Close();

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            totalvendas();
            totalCompras();
            totalproduto();
            Lucro();
        }

        private void totalCompras()
        {
            SqlCommand totalVendas = new SqlCommand("SELECT SUM(PRECOTOTAL) AS'COMPRAS' FROM COMPRAS  SELECT FORMAT(DATA, 'dd/MM/yyyy HH:mm:ss') from COMPRAS where CAST(data as date) between CAST(DATEADD(day, -30,GETDATE()) as date)and cast(GETDATE() as date)", banco);

            banco.Open();
            lblTotalcompra.Text = totalVendas.ExecuteScalar().ToString();
            banco.Close();

        }
        private void totalproduto()
        {
            SqlCommand totalProduto = new SqlCommand("SELECT COUNT (QUANTIDADE) AS 'TOTAL' FROM CLIENTEVENDAS   SELECT FORMAT(DATA, 'dd/MM/yyyy HH:mm:ss') from CLIENTEVENDAS where CAST(data as date) between CAST(DATEADD(day, -30,GETDATE()) as date)and cast(GETDATE() as date)", banco);

            banco.Open();
            lblTotalProduto.Text = totalProduto.ExecuteScalar().ToString();
            banco.Close();

        }
        private void Lucro()
        {
            var venda = Convert.ToDecimal(lblTotalVendas.Text);
            var compra = Convert.ToDecimal(lblTotalcompra.Text);
            var resul = venda - compra;
            lblLucro.Text = resul.ToString();
               
        }
    }
}
