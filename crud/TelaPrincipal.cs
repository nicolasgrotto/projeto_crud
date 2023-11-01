using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace crud
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            lblClosePanel.BackColor = Color.Transparent;
        }


        private void CarregarBancoDeDados()
        {
            MySqlConnection meuSql = new MySqlConnection("server=localhost;database=db_crud;uid=root;pwd=etec");

            try
            {             
                meuSql.Open();
                DataTable dt = new DataTable();

                MySqlDataAdapter adapter = null;

                string select = "select * from Aluno";
                using (MySqlCommand cmd = new MySqlCommand(select, meuSql))
                {
                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    dgvAluno.DataSource = dt;
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados.");
            }
            finally
            {
                if(meuSql.State == ConnectionState.Open)
                {
                    meuSql.Close();
                }
                meuSql.Dispose();
            }
        }

        private void FiltrarBancoDeDados()
        {
            MySqlConnection meuSql = new MySqlConnection("server=localhost;database=db_crud;uid=root;pwd=etec");

            try
            {
                meuSql.Open();

                string select = "select * from Aluno ";

                if (txtbNome.Text != "")
                {
                    select += "where nome like @nome";
                }

                DataTable dt = new DataTable();

                using(MySqlCommand command = new MySqlCommand(select, meuSql))
                {
                    if (txtbNome.Text != "")
                    {
                        command.Parameters.AddWithValue("@nome", txtbNome.Text + "%");
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);

                    dgvAluno.DataSource = dt;
                }

                MessageBox.Show("Dados Filtrados.");

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                if(meuSql.State == ConnectionState.Open)
                {
                    meuSql.Close();
                }
                meuSql.Dispose();
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            CarregarBancoDeDados();
            pnlEditar.Visible = false;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoSql = new MySqlConnection("server=localhost;database=db_crud;uid=root;pwd=etec");
            try
            {    
                conexaoSql.Open();
                MySqlCommand comandoEditar = new MySqlCommand($"UPDATE Aluno SET nome = '{txtbNome.Text}', idade = {txtbIdade.Text} Where id = {txtbId.Text};", conexaoSql);
                comandoEditar.ExecuteNonQuery();

                txtbIdade.Enabled = false;
                txtbNome.Enabled = false;

                txtbId.Text = "";
                txtbIdade.Text = "";
                txtbNome.Text = "";

                MessageBox.Show("Dados atualizados!");
                pnlEditar.Visible = false;        
            }
            catch (Exception)
            {
                MessageBox.Show("Erro.");
            }
            finally
            {
                if (conexaoSql.State == ConnectionState.Open)
                {
                    conexaoSql.Close();
                }
                conexaoSql.Dispose();
            }
            CarregarBancoDeDados();

        }

        private void dgvAluno_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtbIdade.Enabled = true;
            txtbNome.Enabled = true;
            pnlEditar.Visible = true;

            txtbId.Text = dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbNome.Text = dgvAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbIdade.Text = dgvAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmationMessage = MessageBox.Show("Deseja excluir os dados selecionados?", "Sistema da barbearia", MessageBoxButtons.YesNo);

            if (deleteConfirmationMessage == DialogResult.Yes)
            {
                MySqlConnection conexaoSql = new MySqlConnection("server=localhost;database=db_crud;uid=root;pwd=etec");
                try
                {
                    conexaoSql.Open();
                    MySqlCommand comandoEditar = new MySqlCommand($"DELETE FROM Aluno WHERE id = {txtbId.Text};", conexaoSql);
                    comandoEditar.ExecuteNonQuery();

                    txtbIdade.Enabled = false;
                    txtbNome.Enabled = false;

                    txtbId.Text = "";
                    txtbIdade.Text = "";
                    txtbNome.Text = "";

                    MessageBox.Show("Dados apagados!");
                    pnlEditar.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro.");
                }
                finally
                {
                    if (conexaoSql.State == ConnectionState.Open)
                    {
                        conexaoSql.Close();
                    }
                    conexaoSql.Dispose();
                }
                CarregarBancoDeDados();
            }
            else
            {
                MessageBox.Show("Os dados foram mantidos.");
            }
        }

        private void btnTelaCadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastro telaCadastro = new Cadastro();
            telaCadastro.Show();
        }

        private void lblClosePanel_MouseLeave(object sender, EventArgs e)
        {
            lblClosePanel.BackColor = Color.Transparent;
        }

        private void lblClosePanel_MouseClick(object sender, MouseEventArgs e)
        {
            pnlEditar.Visible = false;
            CarregarBancoDeDados();
        }

        private void lblClosePanel_MouseEnter(object sender, EventArgs e)
        {
            lblClosePanel.BackColor = Color.Red;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarBancoDeDados();
        }

        private void tsFIltrarBtn_Click(object sender, EventArgs e)
        {
            pnlEditar.Visible = true;

            txtbNome.Enabled = true;
        }
    }
}
