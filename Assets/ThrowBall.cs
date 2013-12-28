using UnityEngine;
using System.Collections;

public class ThrowBall : MonoBehaviour {

	public float force;
	private GameObject Ball;
	private GameObject Character;

	// Use this for initialization
	void Start () {
	
	}

	void Awake(){
		Ball = GameObject.Find ("ball");
		Character = gameObject;
	}

	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0) && Ball.CompareTag("Carried")){
			Ball.renderer.collider.rigidbody.isKinematic = false;
			//Ball.renderer.collider.rigidbody.useGravity = true;
			Ball.transform.parent = null;
			Ball.renderer.collider.rigidbody.velocity = Character.transform.forward * force;
			Ball.tag = "Carryable";
		}
	}

}
