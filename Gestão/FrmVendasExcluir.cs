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
    public partial class FrmVendasExcluir : Form
    {
        private SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
        private DataTable tabela;
        private SqlDataAdapter adapter;


        public FrmVendasExcluir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Hide();
            }
        }

        private void FrmVendasExcluir_Load(object sender, EventArgs e)
        {
            banco.Open();

            tabela = new DataTable();
            SqlCommand comandoBanco = new SqlCommand("select distinct CODPRODUTO, NOME from PRODUTOS", banco);

            adapter = new SqlDataAdapter(comandoBanco);
            adapter.Fill(tabela);
            combocategoria.DataSource = tabela;
            combocategoria.DisplayMember = "NOME";
            combocategoria.ValueMember = "CODPRODUTO";

            banco.Close();

            grupo1.Visible = true;
            grupo2.Visible = false;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from CLIENTEVENDAS where CODCLIENTE='" + txtcod.Text + "'", banco);

            try
            {
                banco.Open();
                adapter = new SqlDataAdapter(comando);
                adapter.Fill(tabela);

                SqlDataReader leia = comando.ExecuteReader();

                if (leia.HasRows == false)
                {
                    MessageBox.Show("Codigo não encontrado!");
                    txtproduto.Text = "";
                    txtcod.Text = "";
                    txtcliente.Text = "";
                    txtquantidade.Text = "";
                    combocategoria.Text = "";
                    txtpreco.Text = "";
                    banco.Close();

                }
                else if (leia.HasRows == true)
                {
                    grupo2.Visible = true;
                    leia.Read();
                    txtproduto.Text = Convert.ToString(leia["CODPROD"]);
                    txtdata.Text = Convert.ToString(leia["DATA"]);
                    txtcliente.Text = Convert.ToString(leia["CLIENTE"]);
                    txtquantidade.Text = Convert.ToString(leia["QUANTIDADE"]);
                    combocategoria.Text = Convert.ToString(leia["CATEGORIA"]);
                    txtpreco.Text = Convert.ToString(leia["PRECO"]);
                    txttotal.Text = Convert.ToString(leia["TOTAL"]);

                    banco.Close();
                }
            }
            catch
            {
                banco.Close();
            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand comandoExcluir = new SqlCommand("DELETE from CLIENTEVENDAS where CODCLIENTE=@CODCLIENTE", banco);

            comandoExcluir.Parameters.Add("@CODCLIENTE", SqlDbType.Int).Value = txtcod.Text;

            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    banco.Open();
                    comandoExcluir.ExecuteNonQuery();
                    MessageBox.Show("Dados Excluidos com sucesso!");

                    txtproduto.Text = "";
                    txtcod.Text = "";
                    txtcliente.Text = "";
                    txtquantidade.Text = "";
                    combocategoria.Text = "";
                    txtpreco.Text = "";

                    grupo2.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    banco.Close();
                }
            }


        }
    }
}
