using SistemaLSLM.Controler;
using SistemaLSLM.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLSLM.view
{
	public partial class frLogin : Form
	{
		public frLogin()
		{
			InitializeComponent();
		}

		private void btLogin_Click(object sender, EventArgs e)
		{

			try
			{
				if (tbUsuario.Text == "")
				{
					MessageBox.Show("Preencha o campo usuário!");
					tbUsuario.Focus();
					return;
				}
				if (tbUsuario.Text == "")
				{
					MessageBox.Show("Preencha o campo senha!");
					tbSenha.Focus();
					return;
				}

				tblUsuario objTabela = new tblUsuario();
				objTabela.Usuario = tbUsuario.Text;
				objTabela.Senha = tbSenha.Text;

				objTabela = new CtlUsuario().Login(objTabela);

				if (objTabela.Usuario == null)
				{
					lbMensagem.Text = "Usuário ou senha não encontrado!";
					lbMensagem.ForeColor = Color.Red;
					return;
				}
			}
			catch (Exception erro)
			{
				MessageBox.Show("Erro no logar " + erro.Message);
			}

			frCadUsuario frCadUsu = new frCadUsuario();
			//this.Hide();
			frCadUsu.ShowDialog();
		}

		private void btSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
