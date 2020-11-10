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
    public partial class FrmEstoqueAtualizar : Form
    {
        private SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
        private DataTable tabela;
        private SqlDataAdapter adapter;

        public FrmEstoqueAtualizar()
        {
            InitializeComponent();
        }

        private void txtvalorunit_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var data = DateTime.Now.ToLongDateString();
            var hora = DateTime.Now.ToLongTimeString();
            txtdata.Text = (data + " " + hora);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Hide();
            }
        }

        private void FrmEstoqueAtualizar_Load(object sender, EventArgs e)
        {
            grupo1.Visible = true;
            grupo2.Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
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
                   txtquantidade.Text="";
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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand comando = new SqlCommand("UPDATE COMPRAS SET DATA=@DATA, QUANTIDADE=@QUANTIDADE, DESCRICAO=@DESCRICAO, PRECOUNIT=@PRECOUNIT, PRECOTOTAL=@PRECOTOTAL WHERE CODCOMPRA=@CODCOMPRA", banco);

                decimal valor = Convert.ToDecimal(txtvalor.Text);
                decimal total = Convert.ToDecimal(txttotal.Text);

                comando.Parameters.Add("@CODCOMPRA", SqlDbType.Int).Value = txtcod.Text;
                comando.Parameters.Add("@DATA", SqlDbType.DateTime).Value = txtdata.Text;
                comando.Parameters.Add("@QUANTIDADE", SqlDbType.Int).Value = txtquantidade.Text;
                comando.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = txtdescricao.Text;
                comando.Parameters.Add("@PRECOUNIT", SqlDbType.Decimal).Value = valor;
                comando.Parameters.Add("@PRECOTOTAL", SqlDbType.Decimal).Value = total;


                if (txtquantidade.Text != "" && txtdescricao.Text != "" && txtvalor.Text != "" && txttotal.Text != "")
                {
                    try
                    {
                        banco.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cadastro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);

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
            catch
            {
                MessageBox.Show("Preencha todos os campos!");
            }

        }
    }
}
