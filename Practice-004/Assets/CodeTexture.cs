using UnityEngine;
using System.Collections;

public class CodeTexture : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 32x32 サイズのテクスチャを作成
		Texture2D texture;
		texture = new Texture2D(32, 32, TextureFormat.ARGB32, false);

		// 1 ピクセルずつ色をセットする
		for (int y = 0; y < texture.height; y++) {
			for (int x = 0; x < texture.width; x++) {
				Color color = new Color(x / 32f, y / 32f, 0.0f, 1.0f);
				texture.SetPixel(x, y, color);
			}
		}

		// セットしたピクセル列の内容でテクスチャを更新
		texture.Apply();

		// 作ったテクスチャをマテリアルにセットする
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = texture;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
