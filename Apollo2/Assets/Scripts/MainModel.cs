using System;

namespace AssemblyCSharp
{
	public static class MainModel
	{
		public static float tempo = 29;

		public static int 	residencia = 10, //bem louco
							saude = 10,
							escola = 10,
							industria = 10,
							seguranca = 10,
							alimento = 10,
							energia = 100,
							prestigio = 50,
							maxRecurso = 10,
							maxTempo = 31,
							dias,
							tempoInt,
							tempoMissao = 35;

		public static int 	auxMissao,
							auxQuestG,
							missao,
							questG;

		public static bool 	temQuel = false,
							quel = false,
							pause = false;

		public static string[] quests = {	
			"",
			"Mantenha a quantidade de energia nas residências acima de 5",
			"Mantenha a quantidade de energia nas industrias acima de 5",
			"Mantenha a quantidade de energia nos hospitais acima de 5",
			"Mantenha a quantidade de energia para o setor de segurança acima de 5",
			"Mantenha a quantidade de energia nos supermecados acima de 5",
			"Mantenha a quantidade de energia nas escolas acima de 5"
		};

		public static string[,] questoes = {
			{ "Muitas pessoas estão lavando roupa. Qual seria uma dica energética viável para que elas evitem gastar energia?", 
				"Aproveitar lavar o máximo de peças possíveis", 
				"Separa sempre as blusas das calças, na hora da lavagem", 
				"Utilizar bastante sabão para ver melhores resultados", 
				"Lavar as roupas individualmente nas máquinas", 
				"a", "20" },
			{ "Lâmpadas florescentes compactas são mais econômicas onde as luzes ficam acessas por mais tempo. Onde seria um local ideal para a utilização das mesmas?", 
				"Cozinha", 
				"Sala", 
				"Banheiro", 
				"Quarto", 
				"a", "20" },
			{ "Das alternativas abaixo, qual delas representa um impacto ambiental gerado pelo uso excessivo de energia?", 
				"Queima de combustíveis fósseis",
				"Derrubada de árvores", 
				"Poluição sonora",
				"Inundação de vegetações",
				"d", "20" },
			{ "Durante o dia, o que devemos fazer a respeito da iluminação?", 
				"Devemos preferir a luz natural.",
				"Deixar luzes acesas para melhor iluminação.", 
				"Procurar usar mais o ventilador pelo fato de estar mais quente",
				"Utilizar lampadas de LEDs",
				"a", "20" },
			{ "Um garoto levou um choque ao soltar pipa. O que potencialmente pode ter ocorrido?", 
				"Sua pipa encostou em fios da rede elétrica",
				"Ele estava com algum metal no bolso", 
				"Sua pipa era inadequada",
				"A energia é prefere passar pelo corpo humano",
				"a", "20" },
			{ "Uma criança sofreu um choque ao tocar em uma tomada que estava ao seu alcance. O que deveria ser feito para evitar isso?", 
				"Deixar a criança mais no quarto", 
				"Utilizar protetores nas tomadas",
				"Observar sempre as crianças",
				"Remover as tomadas de casa",
				"b", "20" },
			{ "Encontramos um cidadão tentando alterar o seu medidor de energia elétrica! O que isso representa?", 
				"Esperteza",
				"Economia nas contas",
				"Ajuda para outras pessoas",
				"Crime.", 
				"d", "20" },
			{ "Temos uma ocorrência a respeito do furto de energia elétrica! Como popularmente isso é conhecido?", 
				"Ratazana",
				"Papagaio de Pirata",
				"Gato",
				"Cachorro", 
				"c", "20" },
			{ "Queremos adicionar mais algumas tomadas nas nossas Fábrica, o que devemos primeiramente fazer?", 
				"Comprar as tomadas.",
				"Consultar um eletricista",
				"Contratar um estagiário",
				"Pedir pro seu sobrinho fazer", 
				"b", "20" },
			{ "Em nossa Fábrica, uma das nossas freezer quebrou. Qual deve ser a classificação do aparelho novo?",
				"Classificação A", 
				"Classificação D", 
				"Classificação G", 
				"Classificação Z", 
				"a", "20" },
		};
	}
}

