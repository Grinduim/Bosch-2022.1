using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ModuloDesktop
{
    public partial class Configuraçoes : Form
    {
        public Configuraçoes()
        {
            InitializeComponent();
        }

        private void BtnLimparSenha_Click(object sender, EventArgs e)
        {
            string arq = "senhas.txt";
            StreamWriter escritor;
            escritor = File.CreateText(arq);
            escritor.WriteLine("");
            escritor.Close();
        }
    }
}
