using UnityEngine;
using System.Collections;

public class createBullet : MonoBehaviour {

	public GameObject Bullet;
	public GameObject parent;
	public GameObject child;

	private float nextFire = 0.0F;
	private float fireRate = 0.5F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextFire) {
			Debug.Log ("shoot");

			nextFire = Time.time + fireRate;
			Vector3 pos = parent.transform.position + new Vector3 (0.05f, 0.015f, 0);

			child = Instantiate (Bullet);
			child.transform.localPosition = pos;
			child.transform.parent = parent.transform;
		}
	}
}
