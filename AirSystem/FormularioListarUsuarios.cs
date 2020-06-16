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
    public partial class FormularioListarUsuarios : Form
    {
        public FormularioListarUsuarios()
        {
            InitializeComponent();
        }

        private void FormularioListarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            new FormularioAdmin().ShowDialog();
        }
    }
}
