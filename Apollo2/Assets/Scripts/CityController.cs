using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CityController : MonoBehaviour {
	public int residencia, //bem louco
			   saude,
			   escola,
			   industria,
			   seguranca,
			   alimento,
			   energia,
			   prestigio;
	public int maxRecurso = 10;
	public int maxTempo = 30;
	public float tempo;
	public int tempoInt;
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
	}

	public void updateRecursos(){
		if (tempoInt%3 == 0) {
			residencia -= 1;
			saude -= 1;
			escola -= 1;
			Debug.Log ("3 " + tempoInt);
			updatePrestigo ();
		} else if (tempoInt%5 == 0) {
			industria -= 1;
			seguranca -= 1;
			Debug.Log ("5 " + tempoInt);
			updatePrestigo ();
		} else if (tempoInt%7 == 0) {
			alimento -= 1;
			Debug.Log ("7 " + tempoInt);
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
		x = GameObject.Find("textDia").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () { //update significa atualizar
		updateTempo();
		x.text = "XUI";
	}

	private Text x;

}
