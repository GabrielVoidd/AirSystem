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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }

        private void BotaoNovoUsuario_Click(object sender, EventArgs e)
        {
            new FormularioNovoUsuario().ShowDialog();
        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            idioma = OpcaoIdioma.SelectedIndex;

            if(TextBoxUsuario.Text.Trim().Length == 0)
            {
                TituloUsuario.Text = "User";
                TituloIdioma.Text = "Language";
                TituloSenha.Text = "Password";
            }
        }
    }
}
