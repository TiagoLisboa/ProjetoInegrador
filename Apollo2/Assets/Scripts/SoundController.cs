using UnityEngine;
using AssemblyCSharp;

public class SoundController : MonoBehaviour {


	public AudioClip alert, click, vaias,shoque;
	AudioSource audio;

	public void Start (){
		audio = GetComponent<AudioSource> ();
	}

	public void Update () {
		if (MainModel.executarAlerta) {
			MainModel.executarAlerta = false;
			audio.PlayOneShot (alert, 0.12F);
			audio.Stop ();
		}
		somVaias ();
	}

	public void somClick(){
		audio.PlayOneShot (click, 0.12F);
		audio.Stop ();
		if (MainModel.energia < 10) {
			audio.PlayOneShot (shoque, 0.01f);
		}
	}

	public void somVaias (){
		if (MainModel.perdeu == true) {
			audio.PlayOneShot (vaias, 0.1F);
		}
	}
}
