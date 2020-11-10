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
    public partial class FrmProdutoCadastrar : Form
    {
        public FrmProdutoCadastrar()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E; Initial Catalog=NovoProjeto; Integrated Security = True");
            SqlCommand comando = new SqlCommand("INSERT INTO PRODUTOS(NOME, PRECO)VALUES(@NOME, @PRECO)",banco);

            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtnome.Text;
            comando.Parameters.Add("@PRECO", SqlDbType.VarChar).Value = txtpreco.Text;


            if (txtnome.Text !="" && txtpreco.Text!="")
            {
                try
                {
                    banco.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso!","Sucesso"+MessageBoxButtons.OK);
                    txtnome.Text = "";
                    txtpreco.Text = "";

                }
                catch(Exception ex)
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
                MessageBox.Show("Por favor digite todos os campos!");
                txtnome.Focus();
            }
            
        }
    }
}
