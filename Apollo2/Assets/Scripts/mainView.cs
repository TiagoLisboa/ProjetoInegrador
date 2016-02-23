using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using AssemblyCSharp;

public class mainView : MonoBehaviour {

	// Use this for initialization

	private Text 	varTextDias,
					varTextHoras,
					varTextResidencia,
					varTextSaude,
					varTextEscola,
					varTextIndustria,
					varTextSeguranca,
					varTextAlimento,
					varTextPrestigio,
					varTextRelatorio;

	private Text 	questao,
					resA,
					resB,
					resC,
					resD;
	//textChamada

	private Image	varBarResidencia,
					varBarSaude,
					varBarEscola,
					varBarIndustria,
					varBarSeguranca,
					varBarAlimento,
					varBarEnergia,
					varBarPrestigio;

	private Image varQueNotfIcon;


	public GameObject questionarioPainel;
	private Animator anime;



	void Start () {
		//variaveis de texto do contador de tempo
		varTextDias = GameObject.Find("dias").GetComponent<Text>();
		varTextHoras = GameObject.Find("tempo").GetComponent<Text>();

		//variáveis de texto da quantidade de recursos
		varTextResidencia = GameObject.Find("textoQtdRes").GetComponent<Text>();
		varTextSaude = GameObject.Find("textoQtdSau").GetComponent<Text>();
		varTextEscola = GameObject.Find("textoQtdEsc").GetComponent<Text>();
		varTextIndustria = GameObject.Find("textoQtdInd").GetComponent<Text>();
		varTextSeguranca = GameObject.Find("textoQtdSeg").GetComponent<Text>();
		varTextAlimento = GameObject.Find("textoQtdAli").GetComponent<Text>();

		//variável de texto da quantidade de prestigio
		varTextPrestigio = GameObject.Find("qtdPrestigio").GetComponent<Text>();

		//relatorio e questinarios
		varTextRelatorio = GameObject.Find("missoes").GetComponent<Text>();
		questao = GameObject.Find("questao").GetComponent<Text>();
		resA = GameObject.Find("resA").GetComponent<Text>();
		resB = GameObject.Find("resB").GetComponent<Text>();
		resC = GameObject.Find("resC").GetComponent<Text>();
		resD = GameObject.Find("resD").GetComponent<Text>();

		//barras gerais
		varBarResidencia = GameObject.Find("barRes").GetComponent<Image>();
		varBarSaude = GameObject.Find("barSau").GetComponent<Image>();
		varBarEscola = GameObject.Find("barEsc").GetComponent<Image>();
		varBarIndustria = GameObject.Find("barInd").GetComponent<Image>();
		varBarSeguranca = GameObject.Find("barSeg").GetComponent<Image>();
		varBarAlimento = GameObject.Find("barAli").GetComponent<Image>();
		varBarEnergia = GameObject.Find("barEnergia").GetComponent<Image>();
		varBarPrestigio = GameObject.Find("barPrestigio").GetComponent<Image>();

		//icone de alerta relatorio
		varQueNotfIcon = GameObject.Find("quelNotf").GetComponent<Image>();

		//animator do questionario
		anime = questionarioPainel.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		atualizarRelogio ();
		atualizarRecur ();
		atualizarEnergia ();
		atualizarPrestigio ();
		atualizarRelatorio ();
		atualizarQuestionario ();

		notQues ();
	}

	/**********************************************************************/
	/*******************************funções********************************/
	/**********************************************************************/

	public void atualizarRelogio () {
		varTextDias.text = "" + mainModel.dias;
		varTextHoras.text = "" + mainModel.tempoInt;
	}

	public void atualizarRecur () {
		varTextEscola.text = "" + mainModel.escola;
		varTextSaude.text = "" + mainModel.saude;
		varTextAlimento.text = "" + mainModel.alimento;
		varTextSeguranca.text = "" + mainModel.seguranca;
		varTextIndustria.text = "" + mainModel.industria;
		varTextResidencia.text = "" + mainModel.residencia;

		varBarSaude.rectTransform.localScale = new Vector3(mainModel.saude/10f, 1, 1);
		varBarAlimento.rectTransform.localScale = new Vector3(mainModel.alimento/10f, 1, 1);
		varBarEscola.rectTransform.localScale = new Vector3(mainModel.escola/10f, 1, 1);
		varBarSeguranca.rectTransform.localScale = new Vector3(mainModel.seguranca/10f, 1, 1);
		varBarIndustria.rectTransform.localScale = new Vector3(mainModel.industria/10f, 1, 1);
		varBarResidencia.rectTransform.localScale = new Vector3(mainModel.residencia/10f, 1, 1);
	}

	public void atualizarEnergia () {
		varBarEnergia.rectTransform.localScale = new Vector3(mainModel.energia/100f, 1, 1);
	}

	public void atualizarPrestigio () {
		varTextPrestigio.text = "" + mainModel.prestigio;
		varBarPrestigio.rectTransform.localScale = new Vector3(mainModel.prestigio/100f, 1, 1);
	}

	public void atualizarRelatorio () {
		varTextRelatorio.text = "Missões Diárias:\n\n" + mainModel.quests [mainModel.missao] + "\n\n";
	}

	public void atualizarQuestionario () {
		if (mainModel.temQuel == true) {
			questao.text = mainModel.questoes [mainModel.questG, 0];
			//textChamada.text = mainModel.questoes [mainModel.questG, 0];
			resA.text = mainModel.questoes [mainModel.questG, 1];
			resB.text = mainModel.questoes [mainModel.questG, 2];
			resC.text = mainModel.questoes [mainModel.questG, 3];
			resD.text = mainModel.questoes [mainModel.questG, 4];
		}
	}

	public void moverQuestionario () {
		if (mainModel.temQuel == true) {
			if (mainModel.quel == false) {
				mainModel.pause = true;
				anime.enabled = true;
				mainModel.quel = true;
				anime.Play ("questionarioSlide");
			} else if (mainModel.quel == true) {
				mainModel.pause = false;
				anime.enabled = true;
				mainModel.quel = false;
				anime.Play ("questionarioSlideBack");
			}
		}
	}

	public void notQues () {
		if (mainModel.temQuel == false) {
			varQueNotfIcon.enabled = false;
		} else {
			varQueNotfIcon.enabled = true;
		}
	}
}
