using UnityEngine;
using System.Collections;
using Practice012.DLL;

public class DLLTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int test1 = Practice012DLL.Add(1, 2);
		print("1 + 2 = " + test1);

		int test2 = Practice012DLL.Mul(2, 3);
		print("2 * 3 = " + test2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
