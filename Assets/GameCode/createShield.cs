using UnityEngine;
using System.Collections;

public class createShield : MonoBehaviour {
	public GameObject shield;
	public GameObject parent;

	// Use this for initialization
	void Start () {
		shield.transform.parent = parent.transform;
		shield.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		shield.SetActive (true);
	}
}
