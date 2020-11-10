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
    public partial class FrmProdutoExcluir : Form
    {
        SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
        public FrmProdutoExcluir()
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("DELETE  from PRODUTOS where CODPRODUTO=@CODPRODUTO",banco);

            comando.Parameters.Add("@CODPRODUTO", SqlDbType.VarChar).Value = txtcod.Text;

            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
            {
                try
                {
                    banco.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados Excluidos com sucesso!");
                    txtcod.Text = "";
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
           
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from PRODUTOS where CODPRODUTO=@CODPRODUTO", banco);

            comando.Parameters.Add("@CODPRODUTO", SqlDbType.VarChar).Value = txtcod.Text;

            try
            {
                banco.Open();
                SqlDataReader leia = comando.ExecuteReader();
                if (leia.HasRows == false)
                {
                    throw new Exception("Produto não encontrado, tente novamente!");

                }
                leia.Read();
                txtcod.Text = Convert.ToString(leia["CODPRODUTO"]);
                txtnome.Text = Convert.ToString(leia["NOME"]);
                txtpreco.Text = Convert.ToString(leia["PRECO"]);

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
