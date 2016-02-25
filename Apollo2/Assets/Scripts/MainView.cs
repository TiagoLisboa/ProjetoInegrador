using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using AssemblyCSharp;

public class MainView : MonoBehaviour {

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
					varTextRelatorio,
					varTextResultado;

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
		varTextResultado = GameObject.Find("resultado").GetComponent<Text>();
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
		revelarResultadoMissao ();

		notQues ();
	}

	/**********************************************************************/
	/*******************************funções********************************/
	/**********************************************************************/

	public void atualizarRelogio () {
		varTextDias.text = "" + MainModel.dias;
		varTextHoras.text = "" + MainModel.tempoInt;
	}

	public void atualizarRecur () {
		varTextEscola.text = "" + MainModel.escola;
		varTextSaude.text = "" + MainModel.saude;
		varTextAlimento.text = "" + MainModel.alimento;
		varTextSeguranca.text = "" + MainModel.seguranca;
		varTextIndustria.text = "" + MainModel.industria;
		varTextResidencia.text = "" + MainModel.residencia;

		varBarSaude.rectTransform.localScale = new Vector3(MainModel.saude/10f, 1, 1);
		varBarAlimento.rectTransform.localScale = new Vector3(MainModel.alimento/10f, 1, 1);
		varBarEscola.rectTransform.localScale = new Vector3(MainModel.escola/10f, 1, 1);
		varBarSeguranca.rectTransform.localScale = new Vector3(MainModel.seguranca/10f, 1, 1);
		varBarIndustria.rectTransform.localScale = new Vector3(MainModel.industria/10f, 1, 1);
		varBarResidencia.rectTransform.localScale = new Vector3(MainModel.residencia/10f, 1, 1);

		atualizarCoresBarras ();
	}

	public void atualizarCoresBarras(){
		int bom = 5;
		int ruinzinho = 3;
		if (MainModel.alimento < ruinzinho) {
			varBarAlimento.GetComponent<Image>().color = Color.red;
		} else if (MainModel.alimento < bom) {
			varBarAlimento.GetComponent<Image>().color = Color.blue;
		} else {
			varBarAlimento.GetComponent<Image>().color = Color.green;
		}

		if (MainModel.escola < ruinzinho) {
			varBarEscola.GetComponent<Image>().color = Color.red;
		} else if (MainModel.escola < bom) {
			varBarEscola.GetComponent<Image>().color = Color.blue;
		} else {
			varBarEscola.GetComponent<Image>().color = Color.green;
		}

		if (MainModel.industria < ruinzinho) {
			varBarIndustria.GetComponent<Image>().color = Color.red;
		} else if (MainModel.industria < bom) {
			varBarIndustria.GetComponent<Image>().color = Color.blue;
		} else {
			varBarIndustria.GetComponent<Image>().color = Color.green;
		}

		if (MainModel.residencia < ruinzinho) {
			varBarResidencia.GetComponent<Image>().color = Color.red;
		} else if (MainModel.residencia < bom) {
			varBarResidencia.GetComponent<Image>().color = Color.blue;
		} else {
			varBarResidencia.GetComponent<Image>().color = Color.green;
		}

		if (MainModel.saude < ruinzinho) {
			varBarSaude.GetComponent<Image>().color = Color.red;
		} else if (MainModel.saude < bom) {
			varBarSaude.GetComponent<Image>().color = Color.blue;
		} else {
			varBarSaude.GetComponent<Image>().color = Color.green;
		}

		if (MainModel.seguranca < ruinzinho) {
			varBarSeguranca.GetComponent<Image>().color = Color.red;
		} else if (MainModel.seguranca < bom) {
			varBarSeguranca.GetComponent<Image>().color = Color.blue;
		} else {
			varBarSeguranca.GetComponent<Image>().color = Color.green;
		}
	}

	public void atualizarEnergia () {
		varBarEnergia.rectTransform.localScale = new Vector3(MainModel.energia/100f, 1, 1);
	}

	public void atualizarPrestigio () {
		varTextPrestigio.text = "" + MainModel.prestigio;
		varBarPrestigio.rectTransform.localScale = new Vector3(MainModel.prestigio/100f, 1, 1);
	}

	public void atualizarRelatorio () {
		varTextRelatorio.text = "Missões Diárias:\n\n" + MainModel.quests [MainModel.missao] + "\n\n";
	}

	public void revelarResultadoMissao () {
		if (MainModel.tempoMissao == 35) {
			varTextResultado.text = "Falhou!";
		} else {
			varTextResultado.text = "";
		}
	}

	public void atualizarQuestionario () {
		if (MainModel.temQuel == true) {
			questao.text = MainModel.questoes [MainModel.questG, 0];
			//textChamada.text = MainModel.questoes [MainModel.questG, 0];
			resA.text = MainModel.questoes [MainModel.questG, 1];
			resB.text = MainModel.questoes [MainModel.questG, 2];
			resC.text = MainModel.questoes [MainModel.questG, 3];
			resD.text = MainModel.questoes [MainModel.questG, 4];
		}
	}

	public void moverQuestionario () {
		if (MainModel.temQuel == true) {
			if (MainModel.quel == false) {
				MainModel.pause = true;
				anime.enabled = true;
				MainModel.quel = true;
				anime.Play ("questionarioSlide");
			} else if (MainModel.quel == true) {
				MainModel.pause = false;
				anime.enabled = true;
				MainModel.quel = false;
				anime.Play ("questionarioSlideBack");
			}
		}
	}

	public void notQues () {
		if (MainModel.temQuel == false) {
			varQueNotfIcon.enabled = false;
		} else {
			varQueNotfIcon.enabled = true;
		}
	}
}
