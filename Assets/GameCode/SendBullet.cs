using UnityEngine;
using System.Collections;

public class SendBullet : MonoBehaviour {
	public GameObject Bullet;
	public GameObject parent;
	public GameObject child;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			Vector3 pos = gameObject.transform.position + new Vector3(0.05f,0.015f,0);

			child = Instantiate(Bullet);
			child.transform.localPosition = pos;
			child.transform.parent = parent.transform;
		}
	}
}
