using System;
namespace AssemblyCSharp
{
	public class Recurso{
		private string nome { get; set;}
		private int quantidade { get; set;}
		private int ganhoPorTurno { get; set;}
		private int decrementoPorTurno { get; set;}
		private int minimoASerAtendido { get; set;}

		public Recurso (string nome, int quantidade, int ganhoPorTurno, int decrementoPorTurno, int minimoASerAtendido)
		{
			this.nome = nome;
			this.quantidade = quantidade;
			this.ganhoPorTurno = ganhoPorTurno;
			this.decrementoPorTurno = decrementoPorTurno;
			this.minimoASerAtendido = minimoASerAtendido;
		}

	}
}
