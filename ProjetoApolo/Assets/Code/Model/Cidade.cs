using System;
namespace AssemblyCSharp
{
	public class Cidade
	{
		private Setor[] setores{ get; set;}
		private int energiaMaxima{ get; set;}
		private int energiaAtual{ get; set;}

		public Cidade (int energiaMaxima, int energiaAtual)
		{
			this.energiaMaxima = energiaMaxima;
			this.energiaAtual = energiaAtual;
		}
		
		
	}
}

