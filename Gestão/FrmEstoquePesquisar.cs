using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mais_Pães
{
    public partial class FrmEstoquePesquisar : Form
    {
        private SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
        private SqlDataAdapter adapter;
        private DataTable tblCompras;
        private string strsql;
        public FrmEstoquePesquisar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void FrmEstoquePesquisar_Load(object sender, EventArgs e)
        {
            Grid();
        }

        private void Grid()
        {
            string SQL = "SELECT * FROM COMPRAS";

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
            tblCompras = new DataTable();

            strsql = "select * from COMPRAS where CODCOMPRA='" + txtcod.Text + "'";
            adapter = new SqlDataAdapter(strsql, banco);
            adapter.Fill(tblCompras);
            banco.Close();

            dataGridView.DataSource = tblCompras;
            if (txtcod.Text == "")
            {
                Grid();
            }
        }
    }
}
