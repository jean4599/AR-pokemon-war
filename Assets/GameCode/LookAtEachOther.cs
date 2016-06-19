using UnityEngine;
using System.Collections;

public class LookAtEachOther : MonoBehaviour {
	public GameObject target;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		TurnAround ();
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
}
