using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CityController : MonoBehaviour {
	public int 	residencia, //bem louco
			   	saude,
			   	escola,
			   	industria,
			   	seguranca,
			   	alimento,
			   	energia,
			   	prestigio,
				maxRecurso,
				maxTempo;

	public float tempo;

	public int tempoInt;

	private Text 	varTextDia,
					varTextResidencia,
					varTextSaude,
					varTextEscola,
					varTextIndustria,
					varTextSeguranca,
					varTextAlimento,
					varTextEnergia,
					varTextPrestigio;

	// Use this for initialization
	public void addEscola (int valor) {
		if (escola < maxRecurso) {
			escola += valor;
			energia -= valor;
		}
		varTextEscola.text = "Escola\n" + "(" + escola + ")";
	}

	public void addSaude (int valor) {
		if (saude < maxRecurso) {
			saude += valor;
			energia -= valor;
		}
		varTextSaude.text = "Saude\n" + "(" + saude + ")";
	}

	public void addAlimento (int valor) {
		if (alimento < maxRecurso) {
			alimento += valor;
			energia -= valor;
		}
		varTextAlimento.text = "Alimento\n" + "(" + alimento + ")";
	}

	public void addPolicia (int valor) {
		if (seguranca < maxRecurso) {
			seguranca += valor;
			energia -= valor;
		}
		varTextSeguranca.text = "Segurança\n" + "(" + seguranca + ")";
	}

	public void addIndustria (int valor) {
		if (industria < maxRecurso) {
			industria += valor;
			energia -= valor;
		}
		varTextIndustria.text = "Industria\n" + "(" + industria + ")";
	}

	public void addResidencia (int valor) {
		if (residencia < maxRecurso) {
			residencia += valor;
			energia -= valor;
		}
		varTextResidencia.text = "Residencia\n" + "(" + residencia + ")";
	}

	public void updateTempo(){
		if (tempo >= maxTempo) {
			tempo = 0;
			tempoInt = 0;
		} else if (tempo < maxTempo) {
			tempo += Time.deltaTime;
		}
		if ((int)tempo > tempoInt) {
			tempoInt = (int)tempo;
			updateRecursos ();
		}
		varTextDia.text = ""+tempoInt;
	}

	public void updateRecursos(){
		if (tempoInt%3 == 0) {
			addResidencia(-1);
			addSaude(-1);
			addEscola(-1);
			updatePrestigo ();
		} else if (tempoInt%5 == 0) {
			addIndustria(-1);
			addPolicia(-1);
			updatePrestigo ();
		} else if (tempoInt%7 == 0) {
			addAlimento (-1);
			updatePrestigo ();
		}
	}

	public void updatePrestigo () {
		if (residencia < 0) {
			prestigio += residencia;
		}
		if (saude < 0) {
			prestigio += saude;
		}
		if (escola < 0) {
			prestigio += escola;
		}
		if (industria < 0) {
			prestigio += industria;
		}
		if (seguranca < 0) {
			prestigio += seguranca;
		}
		if (alimento < 0) {
			prestigio += alimento;
		}

	}


	void Start () { //start significa iniciar
		varTextDia = GameObject.Find("textDia").GetComponent<Text>();
		varTextResidencia = GameObject.Find("textResidencia").GetComponent<Text>();
		varTextSaude = GameObject.Find("textSaude").GetComponent<Text>();
		varTextEscola = GameObject.Find("textEscola").GetComponent<Text>();
		varTextIndustria = GameObject.Find("textIndustria").GetComponent<Text>();
		varTextSeguranca = GameObject.Find("textPolicia").GetComponent<Text>();
		varTextAlimento = GameObject.Find("textAlimento").GetComponent<Text>();
		varTextEnergia = GameObject.Find("textEnergia").GetComponent<Text>();
		varTextPrestigio = GameObject.Find("textPrestigio").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () { //update significa atualizar
		updateTempo();

	}



}
