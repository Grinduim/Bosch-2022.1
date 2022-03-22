using System;
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
    public partial class MenuConvidados : Form
    {
        int count = 1;
        int page = 0;
        int wait = 1;
        int pageTotal = 0;

        public MenuConvidados()
        {
            
            InitializeComponent();
            BtnProxPag.Hide();
            BtnPagAnt.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            Status1.Hide();
            Status2.Hide();
            Status3.Hide();
            Status4.Hide();
            Status1.Text = "Cadastrado";
            Status2.Text = "Cadastrado";
            Status3.Text = "Cadastrado";
            Status4.Text = "Cadastrado";
            Status1.ForeColor = Color.Black;
            Status2.ForeColor = Color.Black;
            Status3.ForeColor = Color.Black;
            Status4.ForeColor = Color.Black;

            string ServerConnection = "Server= JVLPC0497; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instancia de conexão 
            SqlCommand comando;

            try
            {
                comando = new SqlCommand($"SELECT Foto from Usuarios where idUsuario = {EmailValidation.idUsuario}", conexao);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();

                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Foto"]);
                    img_Perf.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Usuário sem foto de perfil | {0}", ex);
                img_Perf.Image = Image.FromFile(@"S:\COM\Human_Resources\01.Engineering_Tech_School\02.Internal\10 - Aprendizes\5 - Desenvolvimento de Sistemas\1 - Alunos\Allan Kley\Desafio c# 15.03\DataFiles\Icones\SemFoto.png");
            }







            conexao.Open();
            // ADICIONA OS DADOS DE NOME
            comando = new SqlCommand($"Select apelido from Usuarios where idIndicado = {EmailValidation.idUsuario} ", conexao);
            SqlDataReader dataReader = comando.ExecuteReader();


            while (dataReader.Read())
            {
                pageTotal++;
            }
  
            pageTotal = (pageTotal + 4 - 1) / 4;
            conexao.Close();

                conexao.Open();
            // ADICIONA OS DADOS DE NOME
            comando = new SqlCommand($"Select apelido from Usuarios where idIndicado = {EmailValidation.idUsuario} order by apelido asc", conexao);
            dataReader = comando.ExecuteReader();
            

            while (dataReader.Read())
            {
                if (page+1 == pageTotal)
                {
                    BtnProxPag.Hide();
                }
           
                if (count == 1)
                {
                    textBox1.Show();
                    pictureBox1.Show();
                    Status1.Show();

                    textBox1.Text = dataReader[0].ToString();

                    if(textBox1.Text == "")
                    {
                        textBox1.Text = "anon";
                        Status1.Text = "Pendente";
                        Status1.ForeColor = Color.Yellow;
                    }
                }
                else if (count == 2)
                {
                    textBox2.Show();
                    pictureBox2.Show();
                    Status2.Show();

                    textBox2.Text = dataReader[0].ToString();
                    if (textBox2.Text == "")
                    {
                        textBox2.Text = "anon";
                        Status2.Text = "Pendente";
                        Status2.ForeColor = Color.Yellow;
                    }

                }
                else if (count == 3)
                {
                    textBox3.Show();
                    pictureBox3.Show();
                    Status3.Show();
                    textBox3.Text = dataReader[0].ToString();
                    if (textBox3.Text == "")
                    {
                        textBox3.Text = "anon";
                        Status3.ForeColor = Color.Yellow;
                        Status3.Text = "Pendente";
                    }
                }
                else if (count == 4)
                {
                    textBox4.Show();
                    pictureBox4.Show();
                    Status4.Show();
                    textBox4.Text = dataReader[0].ToString();
                    BtnProxPag.Show();
                    if (textBox4.Text == "")
                    {
                        textBox4.Text = "anon";
                        Status4.Text = "Pendente";
                        Status4.ForeColor = Color.Yellow;
                    }
                }
                
                count++;
            }
            conexao.Close();

           
        }

        private void BtnProxPag_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            Status1.Hide();
            Status2.Hide();
            Status3.Hide();
            Status4.Hide();
            Status1.Text = "Cadastrado";
            Status2.Text = "Cadastrado";
            Status3.Text = "Cadastrado";
            Status4.Text = "Cadastrado";
            Status1.ForeColor = Color.Black;
            Status2.ForeColor = Color.Black;
            Status3.ForeColor = Color.Black;
            Status4.ForeColor = Color.Black;

            count = 1;
            wait = 0;
            page++;
            BtnPagAnt.Show();

            
            string ServerConnection = "Server= JVLPC0497; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instância de conexão 
            SqlCommand comando;


            // ADICIONA OS DADOS DE NOME E TIME FAVORITO PARA O LISTVIEW
            comando = new SqlCommand($"Select apelido from Usuarios where idIndicado = {EmailValidation.idUsuario} order by apelido asc", conexao);
            conexao.Open();
            SqlDataReader dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                if (page+1 == pageTotal)
                {
                    BtnProxPag.Hide();
                }
                if (wait >= 4 * page)
                {
                    if (count == 1)
                    {
                        textBox1.Show();
                        pictureBox1.Show();
                        Status1.Show();
                        textBox1.Text = dataReader[0].ToString();

                        if (textBox1.Text == "")
                        {
                            textBox1.Text = "anon";
                            Status1.Text = "Pendente";
                            Status1.ForeColor = Color.Yellow;
                        }
                    }
                    else if (count == 2)
                    {
                        textBox2.Show();
                        pictureBox2.Show();
                        Status2.Show();
                        textBox2.Text = dataReader[0].ToString();
                        if (textBox2.Text == "")
                        {
                            textBox2.Text = "anon";
                            Status2.Text = "Pendente";
                            Status2.ForeColor = Color.Yellow;
                        }

                    }
                    else if (count == 3)
                    {
                        textBox3.Show();
                        pictureBox3.Show();
                        Status3.Show();
                        textBox3.Text = dataReader[0].ToString();
                        if (textBox3.Text == "")
                        {
                            textBox3.Text = "anon";
                            Status3.Text = "Pendente";
                            Status3.ForeColor = Color.Yellow;
                        }
                    }
                    else if (count == 4)
                    {
                        textBox4.Show();
                        pictureBox4.Show();
                        Status4.Show();
                        textBox4.Text = dataReader[0].ToString();
                        if (textBox4.Text == "")
                        {
                            textBox4.Text = "anon";
                            Status4.Text = "Pendente";
                            Status4.ForeColor = Color.Yellow;
                        }
                    }

                    count++;
                }
                wait++;
            }
            conexao.Close();
        }

        private void BtnPagAnt_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            Status1.Hide();
            Status2.Hide();
            Status3.Hide();
            Status4.Hide();
            Status1.Text = "Cadastrado";
            Status2.Text = "Cadastrado";
            Status3.Text = "Cadastrado";
            Status4.Text = "Cadastrado";
            Status1.ForeColor = Color.Black;
            Status2.ForeColor = Color.Black;
            Status3.ForeColor = Color.Black;
            Status4.ForeColor = Color.Black;

            count = 1;
            page--;
            wait = 0;
            BtnProxPag.Show();
            if (page == 0)
            {
                BtnPagAnt.Hide();
            }
            
            string ServerConnection = "Server= JVLPC0497; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instância de conexão 
            SqlCommand comando1;
            


            // ADICIONA OS DADOS DE NOME E TIME FAVORITO PARA O LISTVIEW
            comando1 = new SqlCommand($"Select apelido from Usuarios where idIndicado = {EmailValidation.idUsuario} order by apelido asc", conexao);
            conexao.Open();
            SqlDataReader dataReader = comando1.ExecuteReader();


            while (dataReader.Read())
            {
                if (wait >= 4 * page)
                {
                    if (count == 1)
                    {
                        textBox1.Show();
                        pictureBox1.Show();
                        Status1.Show();

                        textBox1.Text = dataReader[0].ToString();

                        if (textBox1.Text == "")
                        {
                            textBox1.Text = "anon";
                            Status1.Text = "Pendente";
                            Status1.ForeColor = Color.Yellow;
                        }
                    }
                    else if (count == 2)
                    {
                        textBox2.Show();
                        pictureBox2.Show();
                        Status2.Show();

                        textBox2.Text = dataReader[0].ToString();
                        if (textBox2.Text == "")
                        {
                            textBox2.Text = "anon";
                            Status2.Text = "Pendente";
                            Status2.ForeColor = Color.Yellow;
                        }

                    }
                    else if (count == 3)
                    {
                        textBox3.Show();
                        pictureBox3.Show();
                        Status3.Show();

                        textBox3.Text = dataReader[0].ToString();
                        if (textBox3.Text == "")
                        {
                            textBox3.Text = "anon";
                            Status3.Text = "Pendente";
                            Status3.ForeColor = Color.Yellow;
                        }
                    }
                    else if (count == 4)
                    {
                        textBox4.Show();
                        pictureBox4.Show();
                        Status4.Show();

                        textBox4.Text = dataReader[0].ToString();
                        if (textBox4.Text == "")
                        {
                            textBox4.Text = "anon";
                            Status4.Text = "Pendente";
                            Status4.ForeColor = Color.Yellow;
                        }
                    }

                    count++;
                }
                wait++;
            }
            conexao.Close();
        }


        private void img_Perf_Click(object sender, EventArgs e)
        {
            TelaPerfil perfil = new TelaPerfil();
            perfil.Show();
         
        }

        private void BtnJogos_Click_1(object sender, EventArgs e)
        {
            FormJogos jogos = new FormJogos();
            jogos.Show();
            this.Hide();
        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
