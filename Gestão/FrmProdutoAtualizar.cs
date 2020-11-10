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
    public partial class FrmProdutoAtualizar : Form

    {
        SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
        public FrmProdutoAtualizar()
        {
            InitializeComponent();
        }

        private void FrmProdutoAtualizar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Hide();
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("update PRODUTOS set NOME=@NOME, PRECO=@PRECO where CODPRODUTO=@CODPRODUTO", banco);

            comando.Parameters.Add("@CODPRODUTO", SqlDbType.Int).Value = txtcodigo.Text;
            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtnome.Text;
            comando.Parameters.Add("@PRECO", SqlDbType.VarChar).Value = txtpreco.Text;

            if(txtnome.Text !="" && txtpreco.Text != "")
            {
                try
                {
                    banco.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);

                    txtcodigo.Text = "";
                    txtnome.Text = "";
                    txtpreco.Text = "";
               
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    banco.Close();
                }
            }
            else
            {
                banco.Close();
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from PRODUTOS where CODPRODUTO=@CODPRODUTO", banco);

            comando.Parameters.Add("@CODPRODUTO", SqlDbType.VarChar).Value = txtcodigo.Text;


            try
            {
                banco.Open();
                SqlDataReader leia = comando.ExecuteReader();
                if (leia.HasRows == true)
                {
                    leia.Read();
                    txtcodigo.Text = Convert.ToString(leia["CODPRODUTO"]);
                    txtnome.Text = Convert.ToString(leia["NOME"]);
                    txtpreco.Text = Convert.ToString(leia["PRECO"]);

                }
                else if (txtcodigo.Text == "")
                {
                    txtcodigo.Text = "";
                    txtnome.Text = "";
                    txtpreco.Text = "";
                }
                else
                {
                    MessageBox.Show("Produto não encontrado, tente novamente");
                    banco.Close();
                }


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
