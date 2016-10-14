using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadText : MonoBehaviour {
	/// <summary>
	/// 表示先のテキストオブジェクト.
	/// </summary>
	public Text targetText;

	// Use this for initialization
	void Start () {
		// テキストファイルを Resources フォルダからロードする
		// Resources.Load() では、拡張子を入力しない
		TextAsset textAsset = Resources.Load<TextAsset>("Test");

		// テキストオブジェクトに表示する
		if (targetText != null) {
			targetText.text = textAsset.text;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
