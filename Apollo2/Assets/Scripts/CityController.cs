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
				maxTempo,
				dias = 0;

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
	public void addEscola () {
		if (escola < maxRecurso) {
			escola += 1;
			energia -= 1;
		}

	}

	public void addSaude () {
		if (saude < maxRecurso) {
			saude += 1;
			energia -= 1;
		}

	}

	public void addAlimento () {
		if (alimento < maxRecurso) {
			alimento += 1;
			energia -= 1;
		}

	}

	public void addPolicia () {
		if (seguranca < maxRecurso) {
			seguranca += 1;
			energia -= 1;
		}

	}

	public void addIndustria () {
		if (industria < maxRecurso) {
			industria += 1;
			energia -= 1;
		}

	}

	public void addResidencia () {
		if (residencia < maxRecurso) {
			residencia += 1;
			energia -= 1;
		}

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
		varTextDia.text = dias + " / " + tempoInt;
	}
	public double aux;
	public void updateRecursos(){
		if (tempoInt % 3 == 0) {
			residencia -= 1;
			saude -= 1;
			escola -= 1;
			Debug.Log ("3 " + tempoInt);
			updatePrestigo ();
		} else if (tempoInt % 5 == 0) {
			industria -= 1;
			seguranca -= 1;
			Debug.Log ("5 " + tempoInt);
			updatePrestigo ();
		} else if (tempoInt % 7 == 0) {
			alimento -= 1;
			Debug.Log ("7 " + tempoInt);
			updatePrestigo ();
		} else if (tempoInt == 29) {
			dias++;
			Debug.Log (dias);
			aux = energia*1.1;
			energia = (int) aux;
			if (energia > 100) {
				energia = 100;
			}
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

	void updateGUI(){
		varTextEscola.text = "Escola\n" + "(" + escola + ")";
		varTextSaude.text = "Saude\n" + "(" + saude + ")";
		varTextAlimento.text = "Alimento\n" + "(" + alimento + ")";
		varTextSeguranca.text = "Segurança\n" + "(" + seguranca + ")";
		varTextIndustria.text = "Industria\n" + "(" + industria + ")";
		varTextResidencia.text = "Residencia\n" + "(" + residencia + ")";
		varTextEnergia.text = ""+energia;
		varTextPrestigio.text = ""+prestigio;
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
		updateGUI();
	}



}
