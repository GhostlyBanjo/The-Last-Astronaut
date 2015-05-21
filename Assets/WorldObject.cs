using UnityEngine;
using System.Collections;

public class WorldObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


			if(Input.GetKeyDown(KeyCode.RightArrow)){
			this.transform.position+= new Vector3(-1,0,0);}
		 if(Input.GetKeyDown(KeyCode.LeftArrow))
		   this.transform.position+= new Vector3(1,0,0);
	
	}
	void onCollisionEnter(Collision c){
		GameObject g = c.gameObject;
		Renderer r = g.GetComponent<Renderer> ();
		r.material.SetColor("_SpecColor",Color.green);
		
	}
	
	void onCollisionExit(Collision c){
		GameObject g = c.gameObject;
		Renderer r = this.GetComponent<Renderer> ();
		r.material.SetColor("_SpecColor",Color.red);
		
	}
}
