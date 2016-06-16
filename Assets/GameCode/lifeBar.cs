using UnityEngine;
using System.Collections;

public class lifeBar : MonoBehaviour {
	private bool getAttack;
	// Use this for initialization
	void Start () {
		getAttack = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = new Vector3 (0.2f,0,0);
		if (getAttack) {
			Debug.Log ("get attack");
			if (this.gameObject.transform.localScale.x > 0) {
				this.gameObject.transform.localScale -= pos;
			}
		}
		getAttack = false;
	}

	public void enableAttack(){
		getAttack = true;
	}

}
