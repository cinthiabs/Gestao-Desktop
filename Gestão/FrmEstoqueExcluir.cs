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
    public partial class FrmEstoqueExcluir : Form
    {
        private SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
        private DataTable tabela;
        private SqlDataAdapter adapter;

        public FrmEstoqueExcluir()
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

        private void FrmEstoqueExcluir_Load(object sender, EventArgs e)
        {
            grupo1.Visible = true;
            grupo2.Visible = false;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from COMPRAS where CODCOMPRA='" + txtcod.Text + "'", banco);

            try
            {
                banco.Open();
                adapter = new SqlDataAdapter(comando);
                tabela = new DataTable();
                adapter.Fill(tabela);

                SqlDataReader leia = comando.ExecuteReader();

                if (leia.HasRows == false)
                {
                    MessageBox.Show("Codigo não encontrado!");
                    txtdescricao.Text = "";
                    txtcod.Text = "";
                    txtquantidade.Text = "";
                    txtquantidade.Text = "";
                    txtvalor.Text = "";
                    txttotal.Text = "";
                    banco.Close();

                }
                else if (leia.HasRows == true)
                {
                    grupo2.Visible = true;
                    leia.Read();
                    txtcod.Text = Convert.ToString(leia["CODCOMPRA"]);
                    txtdata.Text = Convert.ToString(leia["DATA"]);
                    txtquantidade.Text = Convert.ToString(leia["QUANTIDADE"]);
                    txtdescricao.Text = Convert.ToString(leia["DESCRICAO"]);
                    txtvalor.Text = Convert.ToString(leia["PRECOUNIT"]);
                    txttotal.Text = Convert.ToString(leia["PRECOTOTAL"]);

                    banco.Close();
                }
            }
            catch
            {
                banco.Close();
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            SqlCommand comandoExcluir = new SqlCommand("DELETE from COMPRAS where CODCOMPRA=@CODCOMPRA", banco);

            comandoExcluir.Parameters.Add("@CODCOMPRA", SqlDbType.Int).Value = txtcod.Text;

            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    banco.Open();
                    comandoExcluir.ExecuteNonQuery();
                    MessageBox.Show("Dados Excluidos com sucesso!");

                    txtdescricao.Text = "";
                    txtcod.Text = "";
                    txtquantidade.Text = "";
                    txtquantidade.Text = "";
                    txtvalor.Text = "";
                    txttotal.Text = "";

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
