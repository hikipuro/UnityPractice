using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// マウスが乗った時.
	/// </summary>
	void OnMouseEnter() {
		// ログを表示
		print("OnMouseEnter");

		// 色を変える
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.color = Color.blue;
	}

	/// <summary>
	/// マウスが出た時.
	/// </summary>
	void OnMouseExit() {
		// ログを表示
		print("OnMouseExit");

		// 色を変える
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.color = Color.white;
	}
}
