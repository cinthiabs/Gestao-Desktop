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
    public partial class FrmVendasPesquisar : Form

    {
        private SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
        private SqlDataAdapter adapter;
        private DataTable tblProdutos;
        private string strsql;
        public FrmVendasPesquisar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void FrmVendasPesquisar_Load(object sender, EventArgs e)
        {
            Grid();
        }
        private void Grid()
        {
            string SQL = "SELECT * FROM CLIENTEVENDAS";

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
            banco.Open();
            tblProdutos = new DataTable();
            
            strsql = "select * from CLIENTEVENDAS where CODCLIENTE='" + txtcod.Text + "'";
            adapter = new SqlDataAdapter(strsql, banco);
            adapter.Fill(tblProdutos);
            banco.Close();

            dataGridView.DataSource = tblProdutos;
            if (txtcod.Text == "")
            {
                Grid();
            }

        }
    }
}
