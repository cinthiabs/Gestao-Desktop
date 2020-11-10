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
using System.IO;

namespace Mais_Pães
{
    public partial class FrmRelatorio : Form
    {
        private SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            Grid();
            totalvendas();
            totalCompras();
            totalproduto();
            Lucro();

        }
        private void Grid()
        {
            string SQL = "SELECT * FROM CLIENTEVENDAS  INNER JOIN COMPRAS ON CLIENTEVENDAS.CODCLIENTE = COMPRAS.CODCOMPRA SELECT FORMAT(DATA, 'dd/MM/yyyy HH:mm:ss') from COMPRAS where CAST(data as date) between CAST(DATEADD(day, -365,GETDATE()) as date)and cast(GETDATE() as date)";

            SqlCommand sqlCommand = null;
            sqlCommand = new SqlCommand(SQL, banco);

            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                DataTable dtLista = new DataTable();

                sqlData.Fill(dtLista);
                dataGridView.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Ocorreu erro ao se conectar!");
                banco.Close();
            }

        }
        private void totalvendas()
        {
            SqlCommand totalVendas = new SqlCommand("SELECT SUM(TOTAL) AS'VENDAS' FROM CLIENTEVENDAS  SELECT FORMAT(DATA, 'dd/MM/yyyy HH:mm:ss') from CLIENTEVENDAS where CAST(data as date) between CAST(DATEADD(day, -30,GETDATE()) as date)and cast(GETDATE() as date)", banco);

            banco.Open();
            lblTotalVendas.Text = totalVendas.ExecuteScalar().ToString();
            banco.Close();

        }


        private void totalCompras()
        {
            SqlCommand totalVendas = new SqlCommand("SELECT SUM(PRECOTOTAL) AS'COMPRAS' FROM COMPRAS  SELECT FORMAT(DATA, 'dd/MM/yyyy HH:mm:ss') from COMPRAS where CAST(data as date) between CAST(DATEADD(day, -365,GETDATE()) as date)and cast(GETDATE() as date)", banco);

            banco.Open();
            lblTotalcompra.Text = totalVendas.ExecuteScalar().ToString();
            banco.Close();

        }
        private void totalproduto()
        {
            SqlCommand totalProduto = new SqlCommand("SELECT COUNT (QUANTIDADE) AS 'TOTAL' FROM CLIENTEVENDAS   SELECT FORMAT(DATA, 'dd/MM/yyyy HH:mm:ss') from CLIENTEVENDAS where CAST(data as date) between CAST(DATEADD(day, -365,GETDATE()) as date)and cast(GETDATE() as date)", banco);

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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK) // abre a caixa de dialogo salvar como
                {
                    // criando uma veriavel arquivo para poder salvar o documento (dentro do paramentro, importante)
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamWriter cfb_streamWriter = new StreamWriter(arquivo);
                    cfb_streamWriter.Flush();
                    cfb_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    cfb_streamWriter.WriteLine("RELATÓRIO ANUAL");
                  
                    cfb_streamWriter.Write(this.Vendas.Text);
                    cfb_streamWriter.Write(this.lblTotalVendas.Text);
                    cfb_streamWriter.Write("\n");
                    cfb_streamWriter.Write(this.Compras.Text);
                    cfb_streamWriter.Write(this.lblTotalcompra.Text);
                    cfb_streamWriter.Write("\n");
                    cfb_streamWriter.Write(this.Lucros.Text);
                    cfb_streamWriter.Write(this.lblLucro.Text);
                    cfb_streamWriter.Flush();
                    cfb_streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação" + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
