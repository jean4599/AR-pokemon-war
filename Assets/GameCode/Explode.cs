using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {
	private bool getAttack;
	public ParticleSystem curExplode;

	// Use this for initialization
	void Start () {
		getAttack = false;
		curExplode.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		if (getAttack) {
			curExplode.Play ();
		}
		getAttack = false;
	}

	public void enableAttack(){
		getAttack = true;
	}
}
