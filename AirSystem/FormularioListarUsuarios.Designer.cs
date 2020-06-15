namespace AirSystem
{
    partial class FormularioListarUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DadosUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Nome = new System.Windows.Forms.Label();
            this.Sobrenome = new System.Windows.Forms.Label();
            this.Endereco = new System.Windows.Forms.Label();
            this.Nascimento = new System.Windows.Forms.Label();
            this.Número = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.BotaoAlterar = new System.Windows.Forms.Button();
            this.BotaoDeletar = new System.Windows.Forms.Button();
            this.TextBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.ConfirmarSenha = new System.Windows.Forms.Label();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.TextBoxNumero = new System.Windows.Forms.TextBox();
            this.TextBoxEndereco = new System.Windows.Forms.TextBox();
            this.TextBoxSobrenome = new System.Windows.Forms.TextBox();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NomeBusca = new System.Windows.Forms.Label();
            this.TextBoxNomeBusca = new System.Windows.Forms.TextBox();
            this.BotaoVoltar = new System.Windows.Forms.Button();
            this.BotaoEditar = new System.Windows.Forms.Button();
            this.BotaoDeletarDados = new System.Windows.Forms.Button();
            this.BotaoNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // DadosUsuario
            // 
            this.DadosUsuario.AutoSize = true;
            this.DadosUsuario.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DadosUsuario.Location = new System.Drawing.Point(620, 25);
            this.DadosUsuario.Name = "DadosUsuario";
            this.DadosUsuario.Size = new System.Drawing.Size(119, 15);
            this.DadosUsuario.TabIndex = 1;
            this.DadosUsuario.Text = "Dados do usuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(606, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 91);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(408, 188);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 15);
            this.Nome.TabIndex = 3;
            this.Nome.Text = "Nome";
            // 
            // Sobrenome
            // 
            this.Sobrenome.AutoSize = true;
            this.Sobrenome.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sobrenome.Location = new System.Drawing.Point(408, 214);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(70, 15);
            this.Sobrenome.TabIndex = 4;
            this.Sobrenome.Text = "Sobrenome";
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.Location = new System.Drawing.Point(408, 246);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(63, 15);
            this.Endereco.TabIndex = 5;
            this.Endereco.Text = "Endereço";
            // 
            // Nascimento
            // 
            this.Nascimento.AutoSize = true;
            this.Nascimento.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nascimento.Location = new System.Drawing.Point(408, 276);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(77, 15);
            this.Nascimento.TabIndex = 6;
            this.Nascimento.Text = "Nascimento";
            // 
            // Número
            // 
            this.Número.AutoSize = true;
            this.Número.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Número.Location = new System.Drawing.Point(408, 310);
            this.Número.Name = "Número";
            this.Número.Size = new System.Drawing.Size(49, 15);
            this.Número.TabIndex = 7;
            this.Número.Text = "Número";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(408, 341);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(56, 15);
            this.Usuario.TabIndex = 8;
            this.Usuario.Text = "Usuário";
            // 
            // BotaoAlterar
            // 
            this.BotaoAlterar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoAlterar.Location = new System.Drawing.Point(606, 140);
            this.BotaoAlterar.Name = "BotaoAlterar";
            this.BotaoAlterar.Size = new System.Drawing.Size(67, 23);
            this.BotaoAlterar.TabIndex = 9;
            this.BotaoAlterar.Text = "Alterar";
            this.BotaoAlterar.UseVisualStyleBackColor = true;
            // 
            // BotaoDeletar
            // 
            this.BotaoDeletar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoDeletar.Location = new System.Drawing.Point(687, 140);
            this.BotaoDeletar.Name = "BotaoDeletar";
            this.BotaoDeletar.Size = new System.Drawing.Size(70, 23);
            this.BotaoDeletar.TabIndex = 10;
            this.BotaoDeletar.Text = "Deletar";
            this.BotaoDeletar.UseVisualStyleBackColor = true;
            this.BotaoDeletar.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextBoxConfirmarSenha
            // 
            this.TextBoxConfirmarSenha.Location = new System.Drawing.Point(539, 399);
            this.TextBoxConfirmarSenha.Name = "TextBoxConfirmarSenha";
            this.TextBoxConfirmarSenha.Size = new System.Drawing.Size(151, 20);
            this.TextBoxConfirmarSenha.TabIndex = 11;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(408, 374);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(42, 15);
            this.Senha.TabIndex = 12;
            this.Senha.Text = "Senha";
            // 
            // ConfirmarSenha
            // 
            this.ConfirmarSenha.AutoSize = true;
            this.ConfirmarSenha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarSenha.Location = new System.Drawing.Point(408, 401);
            this.ConfirmarSenha.Name = "ConfirmarSenha";
            this.ConfirmarSenha.Size = new System.Drawing.Size(112, 15);
            this.ConfirmarSenha.TabIndex = 13;
            this.ConfirmarSenha.Text = "Confirmar senha";
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Location = new System.Drawing.Point(539, 368);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.Size = new System.Drawing.Size(151, 20);
            this.TextBoxSenha.TabIndex = 14;
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.Location = new System.Drawing.Point(539, 335);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(151, 20);
            this.TextBoxUsuario.TabIndex = 15;
            // 
            // TextBoxNumero
            // 
            this.TextBoxNumero.Location = new System.Drawing.Point(539, 304);
            this.TextBoxNumero.Name = "TextBoxNumero";
            this.TextBoxNumero.Size = new System.Drawing.Size(151, 20);
            this.TextBoxNumero.TabIndex = 16;
            // 
            // TextBoxEndereco
            // 
            this.TextBoxEndereco.Location = new System.Drawing.Point(539, 240);
            this.TextBoxEndereco.Name = "TextBoxEndereco";
            this.TextBoxEndereco.Size = new System.Drawing.Size(151, 20);
            this.TextBoxEndereco.TabIndex = 18;
            // 
            // TextBoxSobrenome
            // 
            this.TextBoxSobrenome.Location = new System.Drawing.Point(539, 208);
            this.TextBoxSobrenome.Name = "TextBoxSobrenome";
            this.TextBoxSobrenome.Size = new System.Drawing.Size(151, 20);
            this.TextBoxSobrenome.TabIndex = 19;
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(539, 182);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(151, 20);
            this.TextBoxNome.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(539, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // NomeBusca
            // 
            this.NomeBusca.AutoSize = true;
            this.NomeBusca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeBusca.Location = new System.Drawing.Point(27, 405);
            this.NomeBusca.Name = "NomeBusca";
            this.NomeBusca.Size = new System.Drawing.Size(54, 19);
            this.NomeBusca.TabIndex = 22;
            this.NomeBusca.Text = "Nome:";
            // 
            // TextBoxNomeBusca
            // 
            this.TextBoxNomeBusca.Location = new System.Drawing.Point(87, 404);
            this.TextBoxNomeBusca.Name = "TextBoxNomeBusca";
            this.TextBoxNomeBusca.Size = new System.Drawing.Size(139, 20);
            this.TextBoxNomeBusca.TabIndex = 23;
            // 
            // BotaoVoltar
            // 
            this.BotaoVoltar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoVoltar.Location = new System.Drawing.Point(403, 60);
            this.BotaoVoltar.Name = "BotaoVoltar";
            this.BotaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.BotaoVoltar.TabIndex = 24;
            this.BotaoVoltar.Text = "Voltar";
            this.BotaoVoltar.UseVisualStyleBackColor = true;
            // 
            // BotaoEditar
            // 
            this.BotaoEditar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoEditar.Location = new System.Drawing.Point(403, 111);
            this.BotaoEditar.Name = "BotaoEditar";
            this.BotaoEditar.Size = new System.Drawing.Size(75, 23);
            this.BotaoEditar.TabIndex = 25;
            this.BotaoEditar.Text = "Editar";
            this.BotaoEditar.UseVisualStyleBackColor = true;
            // 
            // BotaoDeletarDados
            // 
            this.BotaoDeletarDados.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoDeletarDados.Location = new System.Drawing.Point(496, 111);
            this.BotaoDeletarDados.Name = "BotaoDeletarDados";
            this.BotaoDeletarDados.Size = new System.Drawing.Size(75, 23);
            this.BotaoDeletarDados.TabIndex = 26;
            this.BotaoDeletarDados.Text = "Deletar";
            this.BotaoDeletarDados.UseVisualStyleBackColor = true;
            // 
            // BotaoNovo
            // 
            this.BotaoNovo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoNovo.Location = new System.Drawing.Point(496, 60);
            this.BotaoNovo.Name = "BotaoNovo";
            this.BotaoNovo.Size = new System.Drawing.Size(75, 23);
            this.BotaoNovo.TabIndex = 27;
            this.BotaoNovo.Text = "Novo";
            this.BotaoNovo.UseVisualStyleBackColor = true;
            // 
            // FormularioListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotaoNovo);
            this.Controls.Add(this.BotaoDeletarDados);
            this.Controls.Add(this.BotaoEditar);
            this.Controls.Add(this.BotaoVoltar);
            this.Controls.Add(this.TextBoxNomeBusca);
            this.Controls.Add(this.NomeBusca);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.TextBoxSobrenome);
            this.Controls.Add(this.TextBoxEndereco);
            this.Controls.Add(this.TextBoxNumero);
            this.Controls.Add(this.TextBoxUsuario);
            this.Controls.Add(this.TextBoxSenha);
            this.Controls.Add(this.ConfirmarSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.TextBoxConfirmarSenha);
            this.Controls.Add(this.BotaoDeletar);
            this.Controls.Add(this.BotaoAlterar);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Número);
            this.Controls.Add(this.Nascimento);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.Sobrenome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DadosUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormularioListarUsuarios";
            this.Text = "Listar usuários - AirSystem";
            this.Load += new System.EventHandler(this.FormularioListarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DadosUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Sobrenome;
        private System.Windows.Forms.Label Endereco;
        private System.Windows.Forms.Label Nascimento;
        private System.Windows.Forms.Label Número;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Button BotaoAlterar;
        private System.Windows.Forms.Button BotaoDeletar;
        private System.Windows.Forms.TextBox TextBoxConfirmarSenha;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label ConfirmarSenha;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.TextBox TextBoxNumero;
        private System.Windows.Forms.TextBox TextBoxEndereco;
        private System.Windows.Forms.TextBox TextBoxSobrenome;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label NomeBusca;
        private System.Windows.Forms.TextBox TextBoxNomeBusca;
        private System.Windows.Forms.Button BotaoVoltar;
        private System.Windows.Forms.Button BotaoEditar;
        private System.Windows.Forms.Button BotaoDeletarDados;
        private System.Windows.Forms.Button BotaoNovo;
    }
}