using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class FormularioNovoUsuario : Form
    {
        private Usuario usuario = null;

        public FormularioNovoUsuario()
        {
            InitializeComponent();
        }

        public FormularioNovoUsuario(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }

        private void FormularioNovoUsuario_Load(object sender, EventArgs e)
        {
            if(usuario != null)
            {
                TextBoxNome.Text = usuario.nome;
                TextBoxSobrenome.Text = usuario.sobrenome;
                TextBoxUsuario.Text = usuario.usuario;
                TextBoxSenha.Text = usuario.senha;
                TextBoxConfirmarSenha.Text = usuario.confirmarSenha;
            }
        }

        private void BotaoAlterarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                FotoPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void BotaoCadastrar_Click(object sender, EventArgs e)
        {
            SenhaCorreta(TextBoxConfirmarSenha.Text);

            if(!(TextBoxConfirmarSenha.Text == TextBoxSenha.Text))
            {
                MessageBox.Show("Não é possível fazer o cadastro com senhas distintas.");
            }

            if(!CampoVazio.TemCampoVazio(this))
            {
                UsuarioRepository repository = new UsuarioRepository();

                if(this.usuario == null)
                {
                    Usuario usuario = new Usuario
                    {
                        nome = TextBoxNome.Text,
                        sobrenome = TextBoxSobrenome.Text,
                        endereco = TextBoxEndereco.Text,
                        nascimento = dateTimePicker1.Value,
                        usuario = TextBoxUsuario.Text,
                        senha = TextBoxSenha.Text,
                        confirmarSenha = TextBoxConfirmarSenha.Text
                    };

                    repository.adicionar(usuario);

                    MessageBox.Show("Dados salvos.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    this.usuario.nome = TextBoxNome.Text;
                    this.usuario.sobrenome = TextBoxSobrenome.Text;
                    this.usuario.endereco = TextBoxEndereco.Text;
                    this.usuario.nascimento = dateTimePicker1.Value;
                    this.usuario.usuario = TextBoxUsuario.Text;
                    this.usuario.senha = TextBoxSenha.Text;
                    this.usuario.confirmarSenha = TextBoxConfirmarSenha.Text;

                    repository.editar(usuario);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool SenhaCorreta(string senha)
        {
            if (senha.Length >= 8)
            {
                string pattern = "[a-z]{1,}";

                if (Regex.IsMatch(senha, pattern))
                {
                    pattern = "[A-Z]{1,}";

                    if (Regex.IsMatch(senha, pattern))
                    {
                        pattern = "[0-9]{1,}";

                        if (Regex.IsMatch(senha, pattern))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void Input_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if(txt != null)
            {
                txt.BackColor = Color.LightYellow;

                string value = txt.Text;
            }
        }

        private void Input_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if(txt != null)
            {
                txt.BackColor = Color.White;
            }
        }
    }
}
