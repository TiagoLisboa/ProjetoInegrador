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

	private Image	varBarResidencia,
					varBarSaude,
					varBarEscola,
					varBarIndustria,
					varBarSeguranca,
					varBarAlimento,
					varBarEnergia,
					varBarPrestigio;

	private Image varQueNotfIcon;

	void Start () {
		varTextDias = GameObject.Find("dias").GetComponent<Text>();
		varTextHoras = GameObject.Find("tempo").GetComponent<Text>();
		varTextResidencia = GameObject.Find("textoQtdRes").GetComponent<Text>();
		varTextSaude = GameObject.Find("textoQtdSau").GetComponent<Text>();
		varTextEscola = GameObject.Find("textoQtdEsc").GetComponent<Text>();
		varTextIndustria = GameObject.Find("textoQtdInd").GetComponent<Text>();
		varTextSeguranca = GameObject.Find("textoQtdSeg").GetComponent<Text>();
		varTextAlimento = GameObject.Find("textoQtdAli").GetComponent<Text>();
		varTextPrestigio = GameObject.Find("qtdPrestigio").GetComponent<Text>();
		//varTextRelatorio = GameObject.Find("textRelatorio").GetComponent<Text>();


		varBarResidencia = GameObject.Find("barRes").GetComponent<Image>();
		varBarSaude = GameObject.Find("barSau").GetComponent<Image>();
		varBarEscola = GameObject.Find("barEsc").GetComponent<Image>();
		varBarIndustria = GameObject.Find("barInd").GetComponent<Image>();
		varBarSeguranca = GameObject.Find("barSeg").GetComponent<Image>();
		varBarAlimento = GameObject.Find("barAli").GetComponent<Image>();
		varBarEnergia = GameObject.Find("barEnergia").GetComponent<Image>();
		varBarPrestigio = GameObject.Find("barPrestigio").GetComponent<Image>();

		varQueNotfIcon = GameObject.Find("quelNotf").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		atualizarRelogio ();
		atualizarRecur ();
		atualizarEnergia ();
		atualizarPrestigio ();

		notQues ();
	}

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

	public void notQues () {
		if (mainModel.temQuel == false) {
			varQueNotfIcon.enabled = false;
		} else {
			varQueNotfIcon.enabled = true;
		}
	}
}
