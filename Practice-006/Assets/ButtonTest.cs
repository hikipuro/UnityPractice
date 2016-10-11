using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClickButton() {
		Text text = GetComponentInChildren<Text>();
		text.text = "ボタンが押されました!";
	}
}
