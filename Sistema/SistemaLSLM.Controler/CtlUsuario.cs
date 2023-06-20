using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLSLM.Tabelas;
using SistemaLSLM.Model;

namespace SistemaLSLM.Controler
{
	public class CtlUsuario
	{
		public static int Inserir(tblUsuario objTabela)
		{
			return new ModUsuario().Inserir(objTabela);
		}

		public List<tblUsuario> Lista()
		{
			return new ModUsuario().Lista();
		}

		public tblUsuario Login(tblUsuario objTabela)
		{
			return new ModUsuario().Login(objTabela);
		}

		public static int Excluir(tblUsuario objTabela)
		{
			return new ModUsuario().Excluir(objTabela);
		}

		public static int Editar(tblUsuario objTabela)
		{
			return new ModUsuario().Editar(objTabela);
		}

		public List<tblUsuario> Pesquisar(tblUsuario objTabela)
		{
			return new ModUsuario().Pesquisar(objTabela);
		}
	}
}
