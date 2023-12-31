﻿using System;
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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TelaPrincipal telaLogin = new TelaPrincipal();
            telaLogin.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection meuSql = new MySqlConnection("server=localhost;database=db_crud;uid=root;pwd=etec");

            try
            {
                if (int.Parse(txtbEmail.Text) >= 100 && int.Parse(txtbEmail.Text) <= 18)
                {
                    throw new OverflowException();
                }

                if (txtbEmail.Text == "" && txtbNome.Text == "")
                {
                    throw new ArgumentNullException();
                }

                meuSql.Open();

                MySqlCommand insert = new MySqlCommand($"INSERT INTO tb_clientes(id_barbeiro, nome, email, telefone, senha_cliente) VALUES ({1}, '{txtbNome.Text}', '{txtbEmail.Text}', '{txtbTelefone.Text}', '{txtbSenha.Text}');", meuSql);
                insert.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Erro: algum dado é inválido.");
                txtbNome.Text = "";
                txtbEmail.Text = "";
                txtbSenha.Text = "";
                txtbTelefone.Text = "";
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void lblCloseApplication_MouseEnter(object sender, EventArgs e)
        {
            lblCloseApplication.BackColor = Color.Red;
            lblCloseApplication.ForeColor = Color.White;
        }

        private void lblCloseApplication_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void lblCloseApplication_MouseLeave(object sender, EventArgs e)
        {
            lblCloseApplication.ForeColor = Color.Black;
            lblCloseApplication.BackColor = Color.Transparent;
        }
    }
}