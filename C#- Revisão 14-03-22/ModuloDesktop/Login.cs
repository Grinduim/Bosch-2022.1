﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ModuloDesktop
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

            string ServerConnection = "Server= JVLPC0497; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instancia de coneção de conexão 
            SqlCommand comando;
            comando = new SqlCommand($"Select Email,Senha,TagSenha from Usuarios where IdUsuario ={EmailValidation.idUsuario}", conexao);
            conexao.Open();
            SqlDataReader dataReader = comando.ExecuteReader();
            dataReader.Read();
          

            TxbEmail.Text = dataReader[0].ToString();
            TxbEmail.Enabled = false;

            string arq = "senhas.txt";
            StreamReader leitor = new StreamReader(arq);
            string linha = leitor.ReadLine();
            leitor.Close();

            if (linha == EmailValidation.idUsuario)
            {
                TxbSenha.Text = dataReader[1].ToString();
                TxbSenha.Enabled = false;
                CbxSenha.Checked = true;
            }
            else
            {
                TxbSenha.Text = "";
                CbxSenha.Checked = false;
            }
            conexao.Close();

            TxbSenha.UseSystemPasswordChar = true;
            OlhoAberto.Visible = true;
            OlhoCortado.Visible = false;
        }

 

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void LinkSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            EsqueciSenha esqueciSenha = new EsqueciSenha();
            esqueciSenha.Show();
            this.Hide();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string ServerConnection = "Server= JVLPC0497; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instancia de coneção de conexão 
            SqlCommand comando;
            comando = new SqlCommand($"Select Senha from Usuarios where IdUsuario ={EmailValidation.idUsuario}", conexao);
            conexao.Open();
            SqlDataReader dataReader = comando.ExecuteReader();
            dataReader.Read();
           
            if (dataReader[0].ToString() == TxbSenha.Text)
            {
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                this.Hide();
                telaPrincipal.Show();

            }
            else
            {
                MessageBox.Show("Senha Inválida");
            }


            conexao.Close();

        }

        private void OlhoCortado_Click(object sender, EventArgs e)
        {
            TxbSenha.UseSystemPasswordChar = true;
            OlhoAberto.Visible = true;
            OlhoCortado.Visible = false;
        }

        private void OlhoAberto_Click(object sender, EventArgs e)
        {
            TxbSenha.UseSystemPasswordChar = false;
            OlhoAberto.Visible = false;
            OlhoCortado.Visible = true;
        }

        private void CbxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if(CbxSenha.Checked == true)
            {
                try
                {
                    string arq = "senhas.txt";
                    StreamWriter escritor = new StreamWriter(arq);
                    escritor.WriteLine(EmailValidation.idUsuario);
                    escritor.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
            else
            {
                string arq = "senhas.txt";
                StreamWriter escritor;
                escritor = File.CreateText(arq);
                escritor.WriteLine("");
                escritor.Close();
            }

        }
    }
}
