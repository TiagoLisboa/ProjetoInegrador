using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class MenuView : MonoBehaviour {

	public GameObject menuInformacoes;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void moverPainel(){
		if (MainModel.painelInfo == false) {
			menuInformacoes.transform.localScale = new Vector3 (1, 1, 1);
			MainModel.painelInfo = true;
		} else {
			menuInformacoes.transform.localScale = new Vector3 (0, 0, 0);
			MainModel.painelInfo = false;
		}

	}
		
}
