using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour {
	void Start () {

	}

	void Update () {

	}
		
	public void iniciar () {
		SceneManager.LoadScene ("newMain");
	}

	public void sair(){
		Application.Quit();
	}
}
