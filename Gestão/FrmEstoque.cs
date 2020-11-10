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
    public partial class FrmEstoque : Form
    {
        private SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
      
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var data = DateTime.Now.ToLongDateString();
            var hora = DateTime.Now.ToLongTimeString();
            txtdata.Text = (data + " " + hora);
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
         //   calcular();
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

        private void txtvalorunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;

                    else if (txtvalor.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Hide();
            }
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
        private void calcular()
        {
            try
            {
                var preco = Convert.ToDecimal(txtvalor.Text);
                var quant = Convert.ToDecimal(txtquantidade.Text);
                var resul = preco * quant;

                txttotal.Text = resul.ToString();
            }
            catch
            {

            }
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            Grid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("INSERT INTO COMPRAS( DATA, QUANTIDADE, DESCRICAO, PRECOUNIT, PRECOTOTAL)VALUES( @DATA, @QUANTIDADE, @DESCRICAO, @PRECOUNIT, @PRECOTOTAL)", banco);

                decimal valor = Convert.ToDecimal(txtvalor.Text);
                decimal total = Convert.ToDecimal(txttotal.Text);

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
                        MessageBox.Show("Dados cadastrados com Sucesso!");
                        txtdescricao.Text = "";
                        txtquantidade.Text = "";
                        txtvalor.Text = "";
                        txttotal.Text = "";

                        txtquantidade.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Preencha todos os campos!");
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

        private void txttotal_CursorChanged(object sender, EventArgs e)
        {
          //  calcular();
        }

        private void txttotal_Click(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
