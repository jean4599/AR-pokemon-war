using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {
	private bool getAttack;
	public ParticleSystem curExplode;
	private AudioSource curaudio;

	// Use this for initialization
	void Start () {
		getAttack = false;
		curaudio = gameObject.GetComponent<AudioSource> ();
		curExplode.Stop ();
		curaudio.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		if (getAttack) {
			curExplode.Play ();
			curaudio.Play ();
		}
		getAttack = false;
	}

	public void enableAttack(){
		getAttack = true;
	}
}
