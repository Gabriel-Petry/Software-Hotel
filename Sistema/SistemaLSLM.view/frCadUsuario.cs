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
	public partial class frCadUsuario : Form
	{
		public frCadUsuario()
		{
			InitializeComponent();
		}

		private string opcao = "";

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btNovo_Click(object sender, EventArgs e)
		{
			opcao = "Novo";
			iniciarOpcao();
		}

		private void btSalvar_Click(object sender, EventArgs e)
		{
			opcao = "Salvar";
			iniciarOpcao();
			ListarGrid();
			DesabilitarCampos();
			LimparCampos();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (tbCodigo1.Text == "")
			{
				MessageBox.Show("Selecione um registro");
				return;
			}
			opcao = "Excluir";
			iniciarOpcao();
			ListarGrid();
			DesabilitarCampos();
			LimparCampos();
		}

		private void btEditar_Click(object sender, EventArgs e)
		{
			if (tbCodigo1.Text == "")
			{
				MessageBox.Show("Selecione um registro");
				return;
			}
			opcao = "Editar";
			iniciarOpcao();
			ListarGrid();
			DesabilitarCampos();
			LimparCampos();
		}

		private void ListarGrid()
		{
			try
			{
				List<tblUsuario> lista = new List<tblUsuario>();
				lista = new CtlUsuario().Lista();
				dgvLerDados.AutoGenerateColumns = false;
				dgvLerDados.DataSource = lista;
			}
			catch (Exception e)
			{

				MessageBox.Show("Erro ao listar dados: " + e.Message);
			}
		}

		private void iniciarOpcao()
		{
			switch (opcao)
			{
				case "Novo":
					HabilitarCampos();
					LimparCampos();
					break;
				case "Salvar":
					try
					{
						objTabela.Nome = tbNome.Text;
						objTabela.Usuario = tbUsuario.Text;
						objTabela.Senha = tbSenha.Text;

						int x = CtlUsuario.Inserir(objTabela);

						if (x > 0)
						{
							MessageBox.Show("Usuário foi inserido com sucesso!");
						} else
						{
							MessageBox.Show("Usuário não inserido!");
						}
					}
					catch (Exception erro)
					{

						MessageBox.Show("Ocorreu um erro ao salvar: " + erro.Message);
					}

					break;
				case "Excluir":

					try
					{
						objTabela.Id = int.Parse(tbCodigo1.Text);

						int x = CtlUsuario.Excluir(objTabela);

						if (x > 0)
						{
							MessageBox.Show(string.Format("Usuário {0} foi excluido com sucesso!", tbNome.Text));
						}
						else
						{
							MessageBox.Show("Usuário não excluído!");
						}
					}
					catch (Exception ex)
					{

						MessageBox.Show("Ocorreu um erro ao excluir: " + ex.Message);
					}

					break;
				case "Editar":

					try
					{

						objTabela.Id = Convert.ToInt32(tbCodigo1.Text);
						objTabela.Nome = tbNome.Text;
						objTabela.Usuario = tbUsuario.Text;
						objTabela.Senha = tbSenha.Text;

						int x = CtlUsuario.Editar(objTabela);

						if (x > 0)
						{
							MessageBox.Show(string.Format("Usuário {0} foi editado com sucesso!", tbNome.Text));
						}
						else
						{
							MessageBox.Show("Usuário não editado!");
						}

					}
					catch (Exception ez)
					{

						MessageBox.Show("Ocorreu um erro ao editar: " + ez.Message);
					}

					break;

				case "Pesquisar":

					try
					{
						objTabela.Nome = tbPesquisar.Text;

						List<tblUsuario> lista = new List<tblUsuario>();

						lista = new CtlUsuario().Pesquisar(objTabela);

						dgvLerDados.AutoGenerateColumns = false;
						dgvLerDados.DataSource = lista;
					}
					catch (Exception ex)
					{

						MessageBox.Show("Erro ao listar dados!" + ex.Message);
					}

					break;

				default:
					break;
			}
		}
		private void HabilitarCampos()
		{
			tbNome.Enabled = true;
			tbUsuario.Enabled = true;
			tbSenha.Enabled = true;
		}

		private void DesabilitarCampos()
		{
			tbNome.Enabled = false;
			tbUsuario.Enabled = false;
			tbSenha.Enabled = false;
		}

		private void LimparCampos()
		{
			tbCodigo1.Clear();
			tbNome.Clear();
			tbUsuario.Clear();
			tbSenha.Clear();
		}

		private void frCadUsuario_Load(object sender, EventArgs e)
		{
			ListarGrid();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void dgvLerDados_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			label4.Text = dgvLerDados.CurrentRow.Cells[0].Value.ToString();
			tbNome.Text = dgvLerDados.CurrentRow.Cells[1].Value.ToString();
			tbUsuario.Text = dgvLerDados.CurrentRow.Cells[2].Value.ToString();
			tbSenha.Text = dgvLerDados.CurrentRow.Cells[3].Value.ToString();
			HabilitarCampos();
		}

		private void dgvLerDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btPesquisar_Click(object sender, EventArgs e)
		{
			opcao = "Pesquisar";
			iniciarOpcao();
		}

		private void tbPesquisar_TextChanged(object sender, EventArgs e)
		{
			if (tbPesquisar.Text == "")
			{
				ListarGrid();
			}

			opcao = "Pesquisar";
			iniciarOpcao();
		}
	}
}
