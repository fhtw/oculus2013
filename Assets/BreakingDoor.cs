using UnityEngine;
using System.Collections;

public class BreakingDoor : MonoBehaviour {
	
	public AnimationClip clip;
	public float moveSpeed = 0.5f;
	private bool isHit;


	// Use this for initialization
	void Start () {
	
	}

	void Awake(){
		isHit = false;
	}

	// Update is called once per frame
	void Update () {
		if((isHit) && gameObject.transform.position.z > -4.322695){
			float myPos = gameObject.transform.position.z;
			transform.Translate(Vector3.down * (moveSpeed * Time.deltaTime));
		}
	}

	void OnMouseDown(){
		/*gameObject door = GameObject.Find("Door");
		Door*/
	}

	void OnCollisionEnter(Collision col){

		//Door = GameObject.Find("Door");

		//Color white = new Color (255, 255, 255);
		isHit = true;
		//if(col.gameObject.name == "Ball"){
		//gameObject.renderer.material.color = white;
		/*Animation anim = new Animation();
		anim.AddClip(clip, "break");
		anim.Play ();*/
		//}
	}
}
