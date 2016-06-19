using UnityEngine;
using System.Collections;

public class BeAttackedByLightning : MonoBehaviour {
	public lifeBar curLifeBar;
	public GameObject lightningMarker;
	private bool getAttack;
	private float nextFire = 0.0F;
	private float fireRate = 0.3F;

	void Awake(){
	}

	void Start() {
		getAttack = false;
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			getAttack = lightningMarker.GetComponent<ARTrackedObject> ().getVisible ();
			if (getAttack) {
				curLifeBar.enableAttack ();
			}
		}
	}
}
