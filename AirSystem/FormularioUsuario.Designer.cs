namespace AirSystem
{
    partial class FormularioUsuario
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
            this.botaoListarAvioes = new System.Windows.Forms.Button();
            this.botaoGerenciarAviao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoListarAvioes
            // 
            this.botaoListarAvioes.Location = new System.Drawing.Point(182, 99);
            this.botaoListarAvioes.Name = "botaoListarAvioes";
            this.botaoListarAvioes.Size = new System.Drawing.Size(143, 117);
            this.botaoListarAvioes.TabIndex = 0;
            this.botaoListarAvioes.Text = "Listar aviões";
            this.botaoListarAvioes.UseVisualStyleBackColor = true;
            // 
            // botaoGerenciarAviao
            // 
            this.botaoGerenciarAviao.Location = new System.Drawing.Point(468, 99);
            this.botaoGerenciarAviao.Name = "botaoGerenciarAviao";
            this.botaoGerenciarAviao.Size = new System.Drawing.Size(143, 117);
            this.botaoGerenciarAviao.TabIndex = 1;
            this.botaoGerenciarAviao.Text = "Gerenciar avião";
            this.botaoGerenciarAviao.UseVisualStyleBackColor = true;
            // 
            // FormularioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoGerenciarAviao);
            this.Controls.Add(this.botaoListarAvioes);
            this.Name = "FormularioUsuario";
            this.Text = "Tela Principal - AirSystem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoListarAvioes;
        private System.Windows.Forms.Button botaoGerenciarAviao;
    }
}