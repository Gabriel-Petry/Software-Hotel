using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLSLM.Tabelas
{
    public class tblUsuario
    {
		//Atributos
		private int id;
		private string nome;
		private string usuario;
		private string senha;

		//Propriedades
		public string Nome { get => nome; set => nome = value; }
		public string Usuario { get => usuario; set => usuario = value; }
		public string Senha { get => senha; set => senha = value; }
		public int Id { get => id; set => id = value; }
	}
}
