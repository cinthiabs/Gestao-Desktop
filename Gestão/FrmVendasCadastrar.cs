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
    public partial class FrmVendasCadastrar : Form
    {
        private SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
        private DataTable tabela;
        private SqlDataAdapter adapter;

        public FrmVendasCadastrar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            var data = DateTime.Now.ToLongDateString();
            var hora = DateTime.Now.ToLongTimeString();
            txtdata.Text = (data + " " + hora);
        }

        private void FrmVendasCadastrar_Load(object sender, EventArgs e)
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
            Grid();

        }
        private void calcular()
        {
            try
            {
                var preco = Convert.ToDecimal(txtpreco.Text);
                var quant = Convert.ToDecimal(txtquantidade.Text);
                var resul = preco * quant;

                txttotal.Text = resul.ToString();
            }
            catch
            {
                
            }
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

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;

                    else if (txtquantidade.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txtpreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;

                    else if (txtpreco.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcliente_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja inserir o nome do Cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                txtcliente.ReadOnly = true;

            }
            else
            {
                txtcliente.ReadOnly = false;
            }

        }

        private void txttotal_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Hide();
            }
        }

        private void txttotal_Validated(object sender, EventArgs e)
        {
         //   calcular();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO CLIENTEVENDAS(CODPROD,DATA,CLIENTE,QUANTIDADE,CATEGORIA,PRECO,TOTAL)VALUES(@CODPROD,@DATA,@CLIENTE,@QUANTIDADE,@CATEGORIA,@PRECO,@TOTAL)", banco);

            try
            {
                decimal preco = Convert.ToDecimal(txtpreco.Text);
                decimal total = Convert.ToDecimal(txttotal.Text);

                comando.Parameters.Add("@CODPROD", SqlDbType.VarChar).Value = txtproduto.Text;
                comando.Parameters.Add("@DATA", SqlDbType.DateTime).Value = txtdata.Text;
                comando.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = txtcliente.Text;
                comando.Parameters.Add("@QUANTIDADE", SqlDbType.Int).Value = txtproduto.Text;
                comando.Parameters.Add("@CATEGORIA", SqlDbType.VarChar).Value = combocategoria.Text;
                comando.Parameters.Add("@PRECO", SqlDbType.Decimal).Value = preco;
                comando.Parameters.Add("@TOTAL", SqlDbType.Decimal).Value = total;



                if (txtproduto.Text != "" && txtdata.Text != "" && txtquantidade.Text != "" && combocategoria.Text != "" && txtpreco.Text != "" && txttotal.Text != "")
                {
                    try
                    {

                        banco.Open();

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cadastro efetuado com Sucesso!");
                        txtproduto.Text = "";
                        txtdata.Text = "";
                        txtcliente.Text = "";
                        txtquantidade.Text = "";
                        combocategoria.Text = "";
                        txtpreco.Text = "";
                        txttotal.Text = "";

                        txtproduto.Focus();

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
                MessageBox.Show("Preencha todos os campos obrigatorios!");
            }


        }

        private void txtproduto_TextChanged(object sender, EventArgs e)
        {
            SqlCommand comandoProduto = new SqlCommand("select * from PRODUTOS where CODPRODUTO='" + txtproduto.Text + "'", banco);
            try
            {
                banco.Open();
                SqlDataReader leia = comandoProduto.ExecuteReader();

                if (leia.HasRows == false)
                {
                    MessageBox.Show("Codigo não encontrado!");
                    txtproduto.Text = "";
                    banco.Close();

                }
                else if (leia.HasRows == true)
                {
                    banco.Close();
                }
                else if (txtproduto.Text == " ")
                {
                    banco.Close();
                }
            }
            catch
            {
                banco.Close();
            }
        }

        private void txtproduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;

                    else if (txtquantidade.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }
    }
}
