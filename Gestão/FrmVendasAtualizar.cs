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
    public partial class FrmVendasAtualizar : Form
    {
        private SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
        private DataTable tabela;
        private SqlDataAdapter adapter;
      

        public FrmVendasAtualizar()
        {
            InitializeComponent();
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

        private void btnpesquisar_Click(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand("select * from CLIENTEVENDAS where CODCLIENTE='"+txtcod.Text+"'", banco);

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

        private void FrmVendasAtualizar_Load(object sender, EventArgs e)
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

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand comandoUpdate = new SqlCommand("UPDATE CLIENTEVENDAS SET CODPROD=@CODPROD, DATA=@DATA, CLIENTE=@CLIENTE, QUANTIDADE=@QUANTIDADE, CATEGORIA=@CATEGORIA, PRECO=@PRECO, TOTAL=@TOTAL WHERE CODCLIENTE=@CODCLIENTE", banco);

                decimal preco = Convert.ToDecimal(txtpreco.Text);
                decimal total = Convert.ToDecimal(txttotal.Text);

                comandoUpdate.Parameters.Add("@CODCLIENTE", SqlDbType.Int).Value = txtcod.Text;
                comandoUpdate.Parameters.Add("@CODPROD", SqlDbType.Int).Value = txtproduto.Text;
                comandoUpdate.Parameters.Add("@DATA", SqlDbType.DateTime).Value = txtdata.Text;
                comandoUpdate.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = txtcliente.Text;
                comandoUpdate.Parameters.Add("@QUANTIDADE", SqlDbType.VarChar).Value = txtquantidade.Text;
                comandoUpdate.Parameters.Add("@CATEGORIA", SqlDbType.VarChar).Value = combocategoria.Text;
                comandoUpdate.Parameters.Add("@PRECO", SqlDbType.Decimal).Value = preco;
                comandoUpdate.Parameters.Add("@TOTAL", SqlDbType.Decimal).Value = total;

                if (txtproduto.Text != "" && txtdata.Text != "" && txtquantidade.Text != "" && combocategoria.Text != "" && txtpreco.Text != "" && txttotal.Text != "")
                {
                    try
                    {
                        banco.Open();
                        comandoUpdate.ExecuteNonQuery();
                        MessageBox.Show("Cadastro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);

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
            catch
            {
                MessageBox.Show("Preencha todos os campos!");
            }



        }
    }
}
