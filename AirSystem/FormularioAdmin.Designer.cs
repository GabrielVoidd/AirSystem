namespace AirSystem
{
    partial class FormularioAdmin
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
            this.BotaoListarUsuarios = new System.Windows.Forms.Button();
            this.BotaoListarAvioes = new System.Windows.Forms.Button();
            this.BotaoGerenciarAviao = new System.Windows.Forms.Button();
            this.BotaoGerenciarCompanhia = new System.Windows.Forms.Button();
            this.BotaoGerenciarRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoListarUsuarios
            // 
            this.BotaoListarUsuarios.Location = new System.Drawing.Point(147, 269);
            this.BotaoListarUsuarios.Name = "BotaoListarUsuarios";
            this.BotaoListarUsuarios.Size = new System.Drawing.Size(120, 84);
            this.BotaoListarUsuarios.TabIndex = 0;
            this.BotaoListarUsuarios.Text = "Listar usuários";
            this.BotaoListarUsuarios.UseVisualStyleBackColor = true;
            // 
            // BotaoListarAvioes
            // 
            this.BotaoListarAvioes.Location = new System.Drawing.Point(334, 270);
            this.BotaoListarAvioes.Name = "BotaoListarAvioes";
            this.BotaoListarAvioes.Size = new System.Drawing.Size(120, 83);
            this.BotaoListarAvioes.TabIndex = 1;
            this.BotaoListarAvioes.Text = "Listar aviões";
            this.BotaoListarAvioes.UseVisualStyleBackColor = true;
            // 
            // BotaoGerenciarAviao
            // 
            this.BotaoGerenciarAviao.Location = new System.Drawing.Point(513, 270);
            this.BotaoGerenciarAviao.Name = "BotaoGerenciarAviao";
            this.BotaoGerenciarAviao.Size = new System.Drawing.Size(120, 83);
            this.BotaoGerenciarAviao.TabIndex = 2;
            this.BotaoGerenciarAviao.Text = "Gerenciar avião";
            this.BotaoGerenciarAviao.UseVisualStyleBackColor = true;
            // 
            // BotaoGerenciarCompanhia
            // 
            this.BotaoGerenciarCompanhia.Location = new System.Drawing.Point(237, 124);
            this.BotaoGerenciarCompanhia.Name = "BotaoGerenciarCompanhia";
            this.BotaoGerenciarCompanhia.Size = new System.Drawing.Size(120, 83);
            this.BotaoGerenciarCompanhia.TabIndex = 3;
            this.BotaoGerenciarCompanhia.Text = "Gerenciar companhia";
            this.BotaoGerenciarCompanhia.UseVisualStyleBackColor = true;
            // 
            // BotaoGerenciarRelatorios
            // 
            this.BotaoGerenciarRelatorios.Location = new System.Drawing.Point(425, 125);
            this.BotaoGerenciarRelatorios.Name = "BotaoGerenciarRelatorios";
            this.BotaoGerenciarRelatorios.Size = new System.Drawing.Size(120, 82);
            this.BotaoGerenciarRelatorios.TabIndex = 4;
            this.BotaoGerenciarRelatorios.Text = "Gerenciar relatórios";
            this.BotaoGerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // FormularioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotaoGerenciarRelatorios);
            this.Controls.Add(this.BotaoGerenciarCompanhia);
            this.Controls.Add(this.BotaoGerenciarAviao);
            this.Controls.Add(this.BotaoListarAvioes);
            this.Controls.Add(this.BotaoListarUsuarios);
            this.Name = "FormularioAdmin";
            this.Text = "Tela Principal - AirSystem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotaoListarUsuarios;
        private System.Windows.Forms.Button BotaoListarAvioes;
        private System.Windows.Forms.Button BotaoGerenciarAviao;
        private System.Windows.Forms.Button BotaoGerenciarCompanhia;
        private System.Windows.Forms.Button BotaoGerenciarRelatorios;
    }
}