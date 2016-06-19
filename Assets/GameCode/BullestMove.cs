using UnityEngine;
using System.Collections;

public class BullestMove : MonoBehaviour {

	public GameObject parent;
	public GameObject target;
	private Vector3 pos;

	void Awake(){
	}
		
	// Use this for initialization
	void Start () {	
		pos = (target.transform.position - parent.transform.position).normalized;
		pos = pos * 0.04f;
	}

	// Update is called once per frame
	void Update () {		
//		Debug.Log ("POS: " + pos + " " + gameObject.transform.position + " " + Time.deltaTime);
		gameObject.transform.position = gameObject.transform.position + pos;

		if (gameObject.transform.position.x > 50 || 
			gameObject.transform.position.y > 50 || 
			gameObject.transform.position.z > 50) {

			Destroy (gameObject);
		}
	}
		
}
