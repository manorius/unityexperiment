using UnityEngine;
using System.Collections;
// Include the library
using Parabox.CSG;

public class Main : MonoBehaviour {

	private GameObject d;
	private GameObject n;

	MeshRenderer renderer;
	GameObject composite;
	// Use this for initialization
	void Start () {
		// Initialize two new meshes in the scene
		//GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		//GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		GameObject door = GameObject.Find("door");
		GameObject digits = GameObject.Find("digits");
		GameObject c = GameObject.Find("c");
		GameObject numbers = GameObject.Find("numbers");
		GameObject num7 = GameObject.Find("num7");
		GameObject num5 = GameObject.Find("num5");
		GameObject num6 = GameObject.Find("num6");
		GameObject ring = GameObject.Find("ring");
		//sphere.transform.localScale = Vector3.one * 1.3;
	//	Debug.Log(m.triangles.Length/3);
		// Perform boolean operation
		Mesh m = CSG.Intersect(ring,num6);

		Debug.Log(m.triangles.Length/3);
		//Debug.Log(m.triangles.Length/3);
		// Create a gameObject to render the result
		composite = new GameObject();
		///composite.AddComponent<MeshFilter>().sharedMesh = m;
		composite.AddComponent<MeshFilter>().mesh = m;
		composite.AddComponent<MeshRenderer>().sharedMaterial = door.GetComponent<MeshRenderer>().sharedMaterial;
		//Debug.Log(composite.GetComponent<MeshFilter>().mesh.triangles.Length/3);

	}
	
	// Update is called once per frame
	void Update () {
		//hand.transform.Rotate(0, 100 * Time.deltaTime, 0);
	}
}


/*
 // Include the library
using Parabox.CSG;

...
	
	// Initialize two new meshes in the scene
	GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
sphere.transform.localScale = Vector3.one * 1.3;

// Perform boolean operation
Mesh m = CSG.Subtract(cube, sphere);

// Create a gameObject to render the result
composite = new GameObject();
composite.AddComponent<MeshFilter>().sharedMesh = m;
*/