using SistemaLSLM.Controler;
using SistemaLSLM.Tabelas;

namespace SistemaLSLM.view
{
	public partial class frCadUsuario
	{
		tblUsuario objTabela = new tblUsuario();

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
			this.label1 = new System.Windows.Forms.Label();
			this.btNovo = new System.Windows.Forms.Button();
			this.btSalvar = new System.Windows.Forms.Button();
			this.btExcluir = new System.Windows.Forms.Button();
			this.btEditar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbUsuario = new System.Windows.Forms.TextBox();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.tbSenha = new System.Windows.Forms.TextBox();
			this.dgvLerDados = new System.Windows.Forms.DataGridView();
			this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.tbCodigo1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbPesquisar = new System.Windows.Forms.TextBox();
			this.btPesquisar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 164);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btNovo
			// 
			this.btNovo.Location = new System.Drawing.Point(63, 253);
			this.btNovo.Name = "btNovo";
			this.btNovo.Size = new System.Drawing.Size(75, 23);
			this.btNovo.TabIndex = 1;
			this.btNovo.Text = "&Novo";
			this.btNovo.UseVisualStyleBackColor = true;
			this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
			// 
			// btSalvar
			// 
			this.btSalvar.Location = new System.Drawing.Point(165, 253);
			this.btSalvar.Name = "btSalvar";
			this.btSalvar.Size = new System.Drawing.Size(75, 23);
			this.btSalvar.TabIndex = 2;
			this.btSalvar.Text = "&Salvar";
			this.btSalvar.UseVisualStyleBackColor = true;
			this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
			// 
			// btExcluir
			// 
			this.btExcluir.Location = new System.Drawing.Point(264, 253);
			this.btExcluir.Name = "btExcluir";
			this.btExcluir.Size = new System.Drawing.Size(75, 23);
			this.btExcluir.TabIndex = 3;
			this.btExcluir.Text = "&Excluir";
			this.btExcluir.UseVisualStyleBackColor = true;
			this.btExcluir.Click += new System.EventHandler(this.button3_Click);
			// 
			// btEditar
			// 
			this.btEditar.Location = new System.Drawing.Point(361, 253);
			this.btEditar.Name = "btEditar";
			this.btEditar.Size = new System.Drawing.Size(75, 23);
			this.btEditar.TabIndex = 4;
			this.btEditar.Text = "E&ditar";
			this.btEditar.UseVisualStyleBackColor = true;
			this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 191);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Usuário:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Senha:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// tbUsuario
			// 
			this.tbUsuario.Enabled = false;
			this.tbUsuario.Location = new System.Drawing.Point(77, 188);
			this.tbUsuario.Name = "tbUsuario";
			this.tbUsuario.Size = new System.Drawing.Size(215, 20);
			this.tbUsuario.TabIndex = 7;
			// 
			// tbNome
			// 
			this.tbNome.Enabled = false;
			this.tbNome.Location = new System.Drawing.Point(77, 161);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(215, 20);
			this.tbNome.TabIndex = 8;
			// 
			// tbSenha
			// 
			this.tbSenha.Enabled = false;
			this.tbSenha.Location = new System.Drawing.Point(77, 214);
			this.tbSenha.Name = "tbSenha";
			this.tbSenha.Size = new System.Drawing.Size(215, 20);
			this.tbSenha.TabIndex = 9;
			// 
			// dgvLerDados
			// 
			this.dgvLerDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLerDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.Nome,
            this.Usuario,
            this.Senha});
			this.dgvLerDados.Location = new System.Drawing.Point(43, 282);
			this.dgvLerDados.Name = "dgvLerDados";
			this.dgvLerDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLerDados.Size = new System.Drawing.Size(435, 210);
			this.dgvLerDados.TabIndex = 10;
			this.dgvLerDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLerDados_CellClick);
			this.dgvLerDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLerDados_CellContentClick);
			// 
			// idUsuario
			// 
			this.idUsuario.DataPropertyName = "id";
			this.idUsuario.HeaderText = "Código";
			this.idUsuario.Name = "idUsuario";
			this.idUsuario.Width = 50;
			// 
			// Nome
			// 
			this.Nome.DataPropertyName = "Nome";
			this.Nome.HeaderText = "Nome do usuário";
			this.Nome.Name = "Nome";
			this.Nome.Width = 120;
			// 
			// Usuario
			// 
			this.Usuario.DataPropertyName = "Usuario";
			this.Usuario.HeaderText = "Usuário";
			this.Usuario.Name = "Usuario";
			this.Usuario.Width = 120;
			// 
			// Senha
			// 
			this.Senha.DataPropertyName = "Senha";
			this.Senha.HeaderText = "Senha";
			this.Senha.Name = "Senha";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Código";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// tbCodigo1
			// 
			this.tbCodigo1.Location = new System.Drawing.Point(80, 118);
			this.tbCodigo1.Name = "tbCodigo1";
			this.tbCodigo1.Size = new System.Drawing.Size(100, 20);
			this.tbCodigo1.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(97, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Pesquisa";
			// 
			// tbPesquisar
			// 
			this.tbPesquisar.Location = new System.Drawing.Point(153, 30);
			this.tbPesquisar.Name = "tbPesquisar";
			this.tbPesquisar.Size = new System.Drawing.Size(239, 20);
			this.tbPesquisar.TabIndex = 14;
			this.tbPesquisar.TextChanged += new System.EventHandler(this.tbPesquisar_TextChanged);
			// 
			// btPesquisar
			// 
			this.btPesquisar.Location = new System.Drawing.Point(398, 30);
			this.btPesquisar.Name = "btPesquisar";
			this.btPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btPesquisar.TabIndex = 15;
			this.btPesquisar.Text = "&Pesquisar";
			this.btPesquisar.UseVisualStyleBackColor = true;
			this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
			// 
			// frCadUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 504);
			this.Controls.Add(this.btPesquisar);
			this.Controls.Add(this.tbPesquisar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbCodigo1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgvLerDados);
			this.Controls.Add(this.tbSenha);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.tbUsuario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btEditar);
			this.Controls.Add(this.btExcluir);
			this.Controls.Add(this.btSalvar);
			this.Controls.Add(this.btNovo);
			this.Controls.Add(this.label1);
			this.Name = "frCadUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frCadUsuario";
			this.Load += new System.EventHandler(this.frCadUsuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btNovo;
		private System.Windows.Forms.Button btSalvar;
		private System.Windows.Forms.Button btExcluir;
		private System.Windows.Forms.Button btEditar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbUsuario;
		private System.Windows.Forms.TextBox tbNome;
		private System.Windows.Forms.TextBox tbSenha;
		private System.Windows.Forms.DataGridView dgvLerDados;
		private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbCodigo1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbPesquisar;
		private System.Windows.Forms.Button btPesquisar;
	}
}