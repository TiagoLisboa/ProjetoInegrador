using System;

namespace AssemblyCSharp
{
	public static class mainModel
	{
		public static float tempo = 28;

		public static int 	residencia = 5, //bem louco
							saude = 5,
							escola = 5,
							industria = 5,
							seguranca = 5,
							alimento = 5,
							energia = 100,
							prestigio = 100,
							maxRecurso = 10,
							maxTempo = 31,
							dias,
							tempoInt;

		public static int 	auxMissao,
							auxQuestG,
							missao,
							questG;

		public static bool 	temQuel = false,
							quel = false,
							pause = false;

		public static string[] quests = {	
			"",
			"Mussum ipsum cacilds, vidis litro abertis. Consetis adipiscings elitis.",
			"Pra lá , depois divoltis porris, paradis. Paisis, filhis, espiritis santis.",
			"Mé faiz elementum girarzis, nisi eros vermeio, in elementis mé pra quem é amistosis quis leo.",
			"Manduma pindureta quium dia nois paga.",
			"Sapien in monti palavris qui num significa nadis i pareci latim."
		};

		public static string[,] questoes = {
			{ "AAAAAAAAAAAAA", "a", "a", "a", "a", "a", "50" },
			{ "BBBBBBBBBBBBB", "b", "b", "b", "b", "b", "40" },
			{ "CCCCCCCCCCCCC", "c", "c", "c", "c", "c", "30" },
			{ "DDDDDDDDDDDDD", "d", "d", "d", "d", "d", "20" },
		};
	}
}

