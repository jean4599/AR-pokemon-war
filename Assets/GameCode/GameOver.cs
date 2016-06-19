using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	private bool dead;
	private LookAtEachOther script;

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
		}
	}

	public void gameOver(){
		dead = true;
	}

}