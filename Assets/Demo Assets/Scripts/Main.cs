using UnityEngine;
using System.Collections;
using Parabox.CSG;

public class Main : MonoBehaviour {


	MeshRenderer renderer;
	GameObject composite;
	// Use this for initialization
	void Start () {
		// Initialize two new meshes in the scene
		GameObject numbers = GameObject.Find("twoNum");
		GameObject ring = GameObject.Find("ring");
		// Perform boolean operation
		Mesh m = CSG.Intersect(ring,numbers);

		// Create a gameObject to render the result
		composite = new GameObject();
		composite.AddComponent<MeshFilter>().mesh = m;
		composite.AddComponent<MeshRenderer>().sharedMaterial = ring.GetComponent<MeshRenderer>().sharedMaterial;

	}
	
	// Update is called once per frame
	void Update () {
	}
}
