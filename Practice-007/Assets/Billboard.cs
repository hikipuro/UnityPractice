using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {
	public new Camera camera = null;

	// Use this for initialization
	void Start () {
		if (camera == null) {
			camera = Camera.main;
		}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 target = transform.position + camera.transform.rotation * Vector3.forward;
		transform.LookAt(target);
	}
}
