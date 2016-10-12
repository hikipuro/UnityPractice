using UnityEngine;
using System.Collections;

public class CopyPrefab : MonoBehaviour {
	/// <summary>
	/// コピー元のプレハブオブジェクト.
	/// </summary>
	public GameObject BasePrefab;

	/// <summary>
	/// フレーム数のカウンタ.
	/// </summary>
	private int count = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// プレハブがセットされていない時は実行しない
		if (BasePrefab == null) {
			return;
		}

		// 1 秒に 1 回だけ実行する
		count++;
		if (count < 60) {
			return;
		}
		count = 0;

		// プレハブをコピーする
		GameObject instance = Instantiate<GameObject>(BasePrefab);

		// ランダムな位置に移動する
		float x = Random.Range(-4f, 4f);
		float y = Random.Range(-3f, 3f);
		instance.transform.position = new Vector3(x, y, 0);
	}
}
