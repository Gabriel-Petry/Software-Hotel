namespace SistemaLSLM.view
{
	partial class frLogin
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbMensagem = new System.Windows.Forms.Label();
			this.tbSenha = new System.Windows.Forms.TextBox();
			this.tbUsuario = new System.Windows.Forms.TextBox();
			this.btLogin = new System.Windows.Forms.Button();
			this.btSair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuário:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(75, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Senha:";
			// 
			// lbMensagem
			// 
			this.lbMensagem.AutoSize = true;
			this.lbMensagem.Location = new System.Drawing.Point(31, 155);
			this.lbMensagem.Name = "lbMensagem";
			this.lbMensagem.Size = new System.Drawing.Size(62, 13);
			this.lbMensagem.TabIndex = 2;
			this.lbMensagem.Text = "Mensagens";
			// 
			// tbSenha
			// 
			this.tbSenha.Location = new System.Drawing.Point(122, 74);
			this.tbSenha.Name = "tbSenha";
			this.tbSenha.Size = new System.Drawing.Size(100, 20);
			this.tbSenha.TabIndex = 3;
			this.tbSenha.Text = "123";
			// 
			// tbUsuario
			// 
			this.tbUsuario.Location = new System.Drawing.Point(122, 39);
			this.tbUsuario.Name = "tbUsuario";
			this.tbUsuario.Size = new System.Drawing.Size(100, 20);
			this.tbUsuario.TabIndex = 4;
			this.tbUsuario.Text = "Lo";
			// 
			// btLogin
			// 
			this.btLogin.Location = new System.Drawing.Point(88, 111);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(75, 23);
			this.btLogin.TabIndex = 5;
			this.btLogin.Text = "&Login";
			this.btLogin.UseVisualStyleBackColor = true;
			this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
			// 
			// btSair
			// 
			this.btSair.Location = new System.Drawing.Point(169, 111);
			this.btSair.Name = "btSair";
			this.btSair.Size = new System.Drawing.Size(75, 23);
			this.btSair.TabIndex = 6;
			this.btSair.Text = "&Sair";
			this.btSair.UseVisualStyleBackColor = true;
			this.btSair.Click += new System.EventHandler(this.btSair_Click);
			// 
			// frLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 259);
			this.Controls.Add(this.btSair);
			this.Controls.Add(this.btLogin);
			this.Controls.Add(this.tbUsuario);
			this.Controls.Add(this.tbSenha);
			this.Controls.Add(this.lbMensagem);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOGIN";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbMensagem;
		private System.Windows.Forms.TextBox tbSenha;
		private System.Windows.Forms.TextBox tbUsuario;
		private System.Windows.Forms.Button btLogin;
		private System.Windows.Forms.Button btSair;
	}
}

