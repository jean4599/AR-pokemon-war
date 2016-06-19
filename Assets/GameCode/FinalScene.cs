using UnityEngine;
using System.Collections;

public class FinalScene : MonoBehaviour {

	private AudioSource curaudio;
	private bool play;
	// Use this for initialization
	void Start () {
		play = false;
		gameObject.SetActive (false);
		curaudio = gameObject.GetComponent<AudioSource> ();
		curaudio.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		if (play) {
			Debug.Log ("in final play");
			curaudio.Play ();
		}
	}

	public void playMusic(){
		play = true;
	}
}
