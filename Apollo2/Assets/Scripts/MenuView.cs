using UnityEngine;
using System.Collections;

public class MenuView : MonoBehaviour {

	public GameObject menuInformacoes;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void moverPainel(){
		menuInformacoes.transform.position = new Vector3(0,0,0);
	}
		
}
