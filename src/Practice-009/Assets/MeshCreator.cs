using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MeshCreator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 五角形のメッシュを作成
		Mesh mesh = CreatePolygon(5, 1);

		// メッシュフィルタに適用する
		var meshFilter = GetComponent<MeshFilter>();
		meshFilter.sharedMesh = mesh;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// 多角形のメッシュを作成する
	/// </summary>
	/// <param name="vertexCount">頂点の数.</param>
	/// <param name="radius">半径.</param>
	/// <returns></returns>
	Mesh CreatePolygon(int vertexCount, float radius) {
		List<Vector3> vertices = new List<Vector3>();
		List<int> triangles = new List<int>();

		// 頂点間の角度
		float angle = 2f * Mathf.PI / vertexCount;

		// 中心に点を置く (インデックス: 0)
		vertices.Add(new Vector3(0, 0, 0));

		// 頂点の数だけ繰り返す
		for (int i = 0; i < vertexCount; i++) {
			// 頂点を 1 つ追加
			float x = Mathf.Sin(angle * i) * radius;
			float y = Mathf.Cos(angle * i) * radius;
			vertices.Add(new Vector3(x, y, 0));
		}

		for (int i = 1; i <= vertexCount; i++) {
			// 三角形 1 つ分ずつ、インデックスのリストを作成
			triangles.Add(0);
			triangles.Add(i);
			if (i + 1 > vertexCount) {
				triangles.Add(1);
			} else {
				triangles.Add(i + 1);
			}
		}

		// 新しいメッシュに、頂点と三角形のインデックスの列をセットする
		Mesh mesh = new Mesh();
		mesh.vertices = vertices.ToArray();
		mesh.triangles = triangles.ToArray();
		return mesh;
	}
}
