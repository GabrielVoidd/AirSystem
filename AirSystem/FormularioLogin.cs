using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        public static int idioma;

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            idioma = OpcaoIdioma.SelectedIndex;

            if (OpcaoIdioma.Text.Trim().Length == 1)
            {

            }
            else
            {
                TituloUsuario.Text = "User";
                TituloSenha.Text = "Password";
                TituloIdioma.Text = "Language";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }
    }
}
