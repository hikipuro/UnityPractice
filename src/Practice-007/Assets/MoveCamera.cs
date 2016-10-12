using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKey(KeyCode.UpArrow)) {
			// 上キーが押された時
			transform.position += transform.forward * 0.05f;
		} else if (Input.GetKey(KeyCode.DownArrow)) {
			// 下キーが押された時
			transform.position += transform.forward * -0.05f;
		}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			// 左キーが押された時
			transform.Rotate(0, -1f, 0, Space.World);
		} else if (Input.GetKey(KeyCode.RightArrow)) {
			// 右キーが押された時
			transform.Rotate(0, 1f, 0, Space.World);
		}
	}
}
