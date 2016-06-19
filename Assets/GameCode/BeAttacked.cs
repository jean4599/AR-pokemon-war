using UnityEngine;
using System.Collections;

public class BeAttacked : MonoBehaviour {
	public lifeBar curLifeBar;
	public Explode curExplode;

	void Awake(){
	}

	void Start() {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "bullet") {
			Debug.Log ("trigger");
			curLifeBar.enableAttack ();
			curExplode.enableAttack ();
			Destroy (other.gameObject);
		}
	}
}
