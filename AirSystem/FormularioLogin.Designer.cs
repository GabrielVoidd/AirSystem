namespace AirSystem
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TituloUsuario = new System.Windows.Forms.Label();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.BotaoNovoUsuario = new System.Windows.Forms.Button();
            this.TituloSenha = new System.Windows.Forms.Label();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.TituloIdioma = new System.Windows.Forms.Label();
            this.OpcaoIdioma = new System.Windows.Forms.ComboBox();
            this.BotaoEntrar = new System.Windows.Forms.Button();
            this.BotaoSair = new System.Windows.Forms.Button();
            this.RelogioDigital = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TituloUsuario
            // 
            this.TituloUsuario.AutoSize = true;
            this.TituloUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloUsuario.Location = new System.Drawing.Point(106, 94);
            this.TituloUsuario.Name = "TituloUsuario";
            this.TituloUsuario.Size = new System.Drawing.Size(80, 22);
            this.TituloUsuario.TabIndex = 0;
            this.TituloUsuario.Text = "Usuário";
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.Location = new System.Drawing.Point(44, 130);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(210, 20);
            this.TextBoxUsuario.TabIndex = 1;
            // 
            // BotaoNovoUsuario
            // 
            this.BotaoNovoUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoNovoUsuario.Location = new System.Drawing.Point(269, 128);
            this.BotaoNovoUsuario.Name = "BotaoNovoUsuario";
            this.BotaoNovoUsuario.Size = new System.Drawing.Size(120, 23);
            this.BotaoNovoUsuario.TabIndex = 2;
            this.BotaoNovoUsuario.Text = "Novo Usuário";
            this.BotaoNovoUsuario.UseVisualStyleBackColor = true;
            // 
            // TituloSenha
            // 
            this.TituloSenha.AutoSize = true;
            this.TituloSenha.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloSenha.Location = new System.Drawing.Point(115, 197);
            this.TituloSenha.Name = "TituloSenha";
            this.TituloSenha.Size = new System.Drawing.Size(60, 22);
            this.TituloSenha.TabIndex = 3;
            this.TituloSenha.Text = "Senha";
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Location = new System.Drawing.Point(44, 233);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.PasswordChar = '*';
            this.TextBoxSenha.Size = new System.Drawing.Size(210, 20);
            this.TextBoxSenha.TabIndex = 4;
            // 
            // TituloIdioma
            // 
            this.TituloIdioma.AutoSize = true;
            this.TituloIdioma.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloIdioma.Location = new System.Drawing.Point(584, 94);
            this.TituloIdioma.Name = "TituloIdioma";
            this.TituloIdioma.Size = new System.Drawing.Size(70, 22);
            this.TituloIdioma.TabIndex = 5;
            this.TituloIdioma.Text = "Idioma";
            // 
            // OpcaoIdioma
            // 
            this.OpcaoIdioma.FormattingEnabled = true;
            this.OpcaoIdioma.Items.AddRange(new object[] {
            "Português",
            "Inglês"});
            this.OpcaoIdioma.Location = new System.Drawing.Point(542, 130);
            this.OpcaoIdioma.Name = "OpcaoIdioma";
            this.OpcaoIdioma.Size = new System.Drawing.Size(154, 21);
            this.OpcaoIdioma.TabIndex = 6;
            // 
            // BotaoEntrar
            // 
            this.BotaoEntrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoEntrar.Location = new System.Drawing.Point(290, 231);
            this.BotaoEntrar.Name = "BotaoEntrar";
            this.BotaoEntrar.Size = new System.Drawing.Size(75, 23);
            this.BotaoEntrar.TabIndex = 7;
            this.BotaoEntrar.Text = "Entrar";
            this.BotaoEntrar.UseVisualStyleBackColor = true;
            this.BotaoEntrar.Click += new System.EventHandler(this.BotaoEntrar_Click);
            // 
            // BotaoSair
            // 
            this.BotaoSair.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSair.Location = new System.Drawing.Point(579, 230);
            this.BotaoSair.Name = "BotaoSair";
            this.BotaoSair.Size = new System.Drawing.Size(75, 23);
            this.BotaoSair.TabIndex = 8;
            this.BotaoSair.Text = "Sair";
            this.BotaoSair.UseVisualStyleBackColor = true;
            // 
            // RelogioDigital
            // 
            this.RelogioDigital.Enabled = true;
            this.RelogioDigital.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoSair);
            this.Controls.Add(this.BotaoEntrar);
            this.Controls.Add(this.OpcaoIdioma);
            this.Controls.Add(this.TituloIdioma);
            this.Controls.Add(this.TextBoxSenha);
            this.Controls.Add(this.TituloSenha);
            this.Controls.Add(this.BotaoNovoUsuario);
            this.Controls.Add(this.TextBoxUsuario);
            this.Controls.Add(this.TituloUsuario);
            this.Name = "TelaLogin";
            this.Text = "Login - AirSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloUsuario;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.Button BotaoNovoUsuario;
        private System.Windows.Forms.Label TituloSenha;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.Label TituloIdioma;
        private System.Windows.Forms.ComboBox OpcaoIdioma;
        private System.Windows.Forms.Button BotaoEntrar;
        private System.Windows.Forms.Button BotaoSair;
        private System.Windows.Forms.Timer RelogioDigital;
        private System.Windows.Forms.Label label1;
    }
}

