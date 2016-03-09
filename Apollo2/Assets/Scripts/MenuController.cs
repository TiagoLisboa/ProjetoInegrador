using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuController : MonoBehaviour {
	void Start () {

	}

	void Update () {
		voltarAnd ();
	}
		
	public void iniciar () {
		SceneManager.LoadScene ("newMain");
	}

	public void sair(){
		Application.Quit();
	}

	public void voltarAnd () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
