using System;
namespace AssemblyCSharp
{
	public class Jogador
	{
		private string nome{ get; set;}
		private int prestigio{ get; set;}
		private int diasDecorridos{ get; set;}
		private int turnoAtual{ get; set;}

		public Jogador (string nome, int prestigio)
		{
			this.nome = nome;
			this.prestigio = prestigio;
		}
		
	}
}

