using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLSLM.Tabelas;
using System.Data.SqlClient;

using System.Data;

namespace SistemaLSLM.Model
{
	public class ModUsuario
	{
		public int Inserir(tblUsuario objTabela)
		{
			using (SqlConnection conexao = new SqlConnection())
			{
				conexao.ConnectionString = Properties.Settings.Default.Banco;

				SqlCommand Sql = new SqlCommand();

				Sql.CommandType = CommandType.Text;

				conexao.Open();
				Sql.CommandText = "INSERT INTO tblUsuario ([Nome], [Usuario], [Senha]) VALUES (@Nome, @Usuario, @Senha)";

				Sql.Parameters.Add("Nome", SqlDbType.VarChar).Value = objTabela.Nome;
				Sql.Parameters.Add("Usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
				Sql.Parameters.Add("Senha", SqlDbType.VarChar).Value = objTabela.Senha;

				Sql.Connection = conexao;

				int quantidade = Sql.ExecuteNonQuery();

				return quantidade;
			}
		}

		public List<tblUsuario> Pesquisar(tblUsuario objTabela)
		{
			using (SqlConnection conexao = new SqlConnection())
			{
				conexao.ConnectionString = Properties.Settings.Default.Banco;

				SqlCommand sql = new SqlCommand();

				sql.CommandType = CommandType.Text;

				conexao.Open();

				sql.CommandText = "SELECT * FROM tblUsuario WHERE Nome LIKE @nome";

				sql.Parameters.Add("Nome", SqlDbType.VarChar).Value = objTabela.Nome + "%";

				sql.Connection = conexao;

				SqlDataReader dr;

				List<tblUsuario> lista = new List<tblUsuario>();

				dr = sql.ExecuteReader();

				if (dr.HasRows)
				{
					while (dr.Read())
					{
						tblUsuario dado = new tblUsuario();

						dado.Id = Convert.ToInt32(dr["idUsuario"]);
						dado.Nome = Convert.ToString(dr["Nome"]);
						dado.Usuario = Convert.ToString(dr["Usuario"]);
						dado.Senha = Convert.ToString(dr["Senha"]);

						lista.Add(dado);
					}
				}

				return lista;
			}
		}

		public int Editar(tblUsuario objTabela)
		{
			using (SqlConnection conexao = new SqlConnection())
			{
				conexao.ConnectionString = Properties.Settings.Default.Banco;

				SqlCommand sql = new SqlCommand();

				sql.CommandType = CommandType.Text;

				conexao.Open();

				sql.CommandText = "UPDATE tblUsuario SET Nome = @Nome, Usuario = @Usuario, Senha = @senha WHERE idUsuario = @id";

				sql.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
				sql.Parameters.Add("Nome", SqlDbType.VarChar).Value = objTabela.Nome;
				sql.Parameters.Add("Usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
				sql.Parameters.Add("Senha", SqlDbType.VarChar).Value = objTabela.Senha;

				sql.Connection = conexao;

				int quantidade = sql.ExecuteNonQuery();

				return quantidade;
			}
		}

		public int Excluir(tblUsuario objTabela)
		{
			using (SqlConnection conexao = new SqlConnection())
			{
				conexao.ConnectionString = Properties.Settings.Default.Banco;

				SqlCommand sql = new SqlCommand();

				sql.CommandType = CommandType.Text;

				conexao.Open();

				sql.CommandText = "DELETE FROM tblUsuario WHERE idUsuario = @id";

				sql.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;

				sql.Connection = conexao;

				int quantidade = sql.ExecuteNonQuery();

				return quantidade;
			}
		}

		public tblUsuario Login(tblUsuario objTabela)
		{
			using (SqlConnection conexao = new SqlConnection())
			{
				conexao.ConnectionString = Properties.Settings.Default.Banco;

				SqlCommand Sql = new SqlCommand();

				Sql.CommandType = CommandType.Text;

				conexao.Open();
				Sql.CommandText = "SELECT * FROM tblUsuario WHERE Usuario = @Usuario AND Senha = @Senha";

				Sql.Connection = conexao;

				Sql.Parameters.Add("Usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
				Sql.Parameters.Add("Senha", SqlDbType.VarChar).Value = objTabela.Senha;

				SqlDataReader dr;

				dr = Sql.ExecuteReader();

				if (dr.HasRows)
				{
					while (dr.Read())
					{
						tblUsuario dado = new tblUsuario();
						dado.Usuario = Convert.ToString(dr["Usuario"]);
						dado.Senha = Convert.ToString(dr["Senha"]);
					}
				}
				else
				{
					objTabela.Senha = null;
					objTabela.Usuario = null;
				}
				return objTabela;
			}
		}

		public List<tblUsuario> Lista()
		{
			using (SqlConnection conexao = new SqlConnection())
			{
				conexao.ConnectionString = Properties.Settings.Default.Banco;

				SqlCommand Sql = new SqlCommand();

				Sql.CommandType = CommandType.Text;

				conexao.Open();
				Sql.CommandText = "SELECT * FROM tblUsuario ORDER BY idUsuario DESC";

				Sql.Connection = conexao;

				SqlDataReader dr;

				List<tblUsuario> lista = new List<tblUsuario>();

				dr = Sql.ExecuteReader();

				if (dr.HasRows)
				{
					while (dr.Read())
					{
						tblUsuario dado = new tblUsuario();
						dado.Id = Convert.ToInt32(dr["idUsuario"]);
						dado.Nome = Convert.ToString(dr["Nome"]);
						dado.Usuario = Convert.ToString(dr["Usuario"]);
						dado.Senha = Convert.ToString(dr["Senha"]);

						lista.Add(dado);
					}
				}
				return lista;
			}
		}
	}
}
