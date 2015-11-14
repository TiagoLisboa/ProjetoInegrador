using System;
namespace AssemblyCSharp
{
	public class Setor
	{
		private string nome{ get; set;}
		private string situacao{ get; set;}
		private int energiaAtual{ get; set;}
		private int energiaDeFuncionamentoPorTurno{ get; set;}
		private Recurso recursoProduzido{ get; set;}
		private RepresentanteSetor RepresentanteSetor{ get; set;}

		public Setor (string nome, int energiaAtual, int energiaDeFuncionamentoPorTurno, Recurso recursoProduzido, RepresentanteSetor representanteSetor)
		{
			this.nome = nome;
			this.energiaAtual = energiaAtual;
			this.energiaDeFuncionamentoPorTurno = energiaDeFuncionamentoPorTurno;
			this.recursoProduzido = recursoProduzido;
			this.RepresentanteSetor = representanteSetor;
		}
		
	}
}

