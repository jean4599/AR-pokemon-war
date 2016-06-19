using UnityEngine;
using System.Collections;

public class LookAtEachOther : MonoBehaviour {
	public GameObject target;
	private bool gameOver;

	// Use this for initialization
	void Start () {
		gameOver = false;
	}

	// Update is called once per frame
	void Update () {
		if (!gameOver) {
			TurnAround ();
		}
	}

	void TurnAround(){
		var pos = target.transform.position - this.gameObject.transform.position;
//		pos.y = 0;
//		pos.x = 0;
//		pos.z = 0;
		Quaternion rotation1 = Quaternion.LookRotation(pos); 
//		Quaternion rotation1 = Quaternion.Euler(pos); 
		this.gameObject.transform.rotation = Quaternion.Slerp (this.gameObject.transform.rotation, rotation1, Time.deltaTime * 2);

	}

	public void setGameOver(){
		gameOver = true;
	}
}
