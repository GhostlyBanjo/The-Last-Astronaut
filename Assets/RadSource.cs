using UnityEngine;
using System.Collections;

public class RadSource : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onCollisionEnter(Collision c){
		GameObject g = c.gameObject;
		Renderer r = g.GetComponent<Renderer> ();
		r.material.SetColor("_SpecColor",Color.green);
		
	}

	void onCollisionExit(Collision c){
		GameObject g = c.gameObject;
		Renderer r = g.GetComponent<Renderer> ();
			r.material.SetColor("_SpecColor",Color.red);

	}
}
