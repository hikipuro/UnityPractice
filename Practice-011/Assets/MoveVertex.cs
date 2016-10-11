using UnityEngine;
using System.Collections;

public class MoveVertex : MonoBehaviour {
	Mesh mesh;

	// Use this for initialization
	void Start () {
		MeshFilter meshFilter = GetComponent<MeshFilter>();
		mesh = meshFilter.mesh;
	}
	
	// Update is called once per frame
	void Update () {
		// 現状の頂点列をコピー
		Vector3[] vertices = mesh.vertices;

		// ちょうど 1 Hz になる値
		float frequency = (2f * Mathf.PI) / 10f;

		// Unity の Plane は頂点数が 11x11
		for (int y = 0; y <= 10; y++) {
			for (int x = 0; x <= 10; x++) {
				int index = y * 11 + x;
				float height = Mathf.Sin(Time.time + y * frequency);
				vertices[index].y = height;
			}
		}

		// 変更した頂点を適用
		mesh.vertices = vertices;
	}
}
