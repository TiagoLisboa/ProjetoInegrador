using System;
namespace AssemblyCSharp
{
	public class RepresentanteSetor
	{
		private string nome { get; set;};
		private string caminhoDicas; //tipo de variavel que armazena caminho de um arquivo
		private string caminhoReclamacoes;

		private string[] dicas;
		private string[] reclamacoes;

		public RepresentanteSetor (string nome, string caminhoDicas, string caminhoReclamacoes)
		{
			this.nome = nome;
			//dicas recebera uma lista de palavras contidas no arquivo passado pelo caminhoDicas;
			//reclamacoes recebera uma lista de palavras contidas no arquivo passado pelo caminhoReclamacoes;
		}
		

	}
}

