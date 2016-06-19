using UnityEngine;
using System.Collections;

public class createBullet : MonoBehaviour {

//	private BullestMove Bullet;
	private GameObject child;
	public GameObject parent;
	public GameObject Bullet;
	public GameObject target;
	private BullestMove bulletsMoveScript;

	private float nextFire = 0.0F;
	private float fireRate = 0.5F;

	void Awake(){
		bulletsMoveScript = Bullet.GetComponent<BullestMove>();
	}

	// Use this for initialization
	void Start () {
		bulletsMoveScript.parent = parent;
		bulletsMoveScript.target = target;

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextFire) {
			Debug.Log ("shoot");

			nextFire = Time.time + fireRate;

			child = Instantiate (Bullet, parent.transform.position, parent.transform.rotation) as GameObject;
			child.transform.localPosition = parent.transform.position;
			child.transform.parent = parent.transform;


//			Bullet = new BullestMove (target, self, bullet);
		}
	}
}
