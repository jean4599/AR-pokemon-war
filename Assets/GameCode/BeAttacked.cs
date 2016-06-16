using UnityEngine;
using System.Collections;

public class BeAttacked : MonoBehaviour {
	public lifeBar curLifeBar;
	void Start() {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "bullet") {
			Debug.Log ("trigger");
			curLifeBar.enableAttack ();
			Destroy (other.gameObject);
		}
	}
}
