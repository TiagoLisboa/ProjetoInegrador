using UnityEngine;
using AssemblyCSharp;

public class SoundController : MonoBehaviour {

	public void som(){
		if (MainModel.temQuel == true){
			AudioSource audio = gameObject.AddComponent<AudioSource>();
			audio.clip = Resources.Load ("Alert") as AudioClip;
			audio.Play();
		}
	}
}
