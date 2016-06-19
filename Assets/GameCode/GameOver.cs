using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	private bool dead;
	private LookAtEachOther script;
	public GameObject attackMarker1;
	public GameObject attackMarker2;
	public GameObject text;


	// Use this for initialization
	void Start () {
		dead = false;
		script = gameObject.GetComponent<LookAtEachOther> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (dead) {
			script.setGameOver ();
			gameObject.SetActive (false);
			attackMarker1.SetActive (false);
			attackMarker2.SetActive (false);
			text.SetActive (true);
			text.GetComponent<FinalScene> ().playMusic ();
		}
	}

	public void gameOver(){
		dead = true;
	}

}