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
    public partial class FrmProdutoPesquisar : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblProdutos;
        private string strsql, strconex;

        public FrmProdutoPesquisar()
        {
            InitializeComponent();
        }

        private void FrmProdutoPesquisar_Load(object sender, EventArgs e)
        {
            Grid();
        }

        private void Grid()
        {
            string SQL = "SELECT * FROM PRODUTOS";

            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
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
        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            strconex = "Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True";
            conexao = new SqlConnection(strconex);

            conexao.Open();
            tblProdutos = new DataTable();

            strsql = "select * from PRODUTOS where CODPRODUTO='" + txtcod.Text + "'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblProdutos);

            dataGridView.DataSource = tblProdutos;
            if (txtcod.Text == "")
            {
                Grid();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }
    }
}
