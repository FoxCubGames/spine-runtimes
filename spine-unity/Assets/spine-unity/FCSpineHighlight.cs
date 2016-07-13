#if !UNITY_EDITOR || FCLOG
using Debug = FC.Debug;
#else
using Debug = UnityEngine.Debug;
#endif

//using UnityEngine;
//using System.Collections;

//[ExecuteInEditMode]
//public class FCSpineHighlight : MonoBehaviour {

//	void LateUpdate() {
//		var mesh = GetComponent<MeshFilter>().sharedMesh;
		
//		//mesh.uv2 = new Vector2[] {
//		//	new Vector2(0f, 1f),
//		//	new Vector2(0f, 0f),
//		//	new Vector2(1f, 1f),
//		//	new Vector2(1f, 0f)
//		//};

//		var uv2 = new Vector2[mesh.vertexCount];
//		uv2[0] = new Vector2(0f, 0f);
//		uv2[1] = new Vector2(1f, 0f);
//		uv2[2] = new Vector2(0f, 1f);
//		uv2[3] = new Vector2(1f, 1f);

//		mesh.uv2 = uv2;
//	}

//}
