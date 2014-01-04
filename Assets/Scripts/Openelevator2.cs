using UnityEngine;
using System.Collections;

public class Openelevator2 : MonoBehaviour {

	private elevatorbutton button;
	public float moveSpeed = 0.9f;
	
	void Start(){
		
		button = (elevatorbutton)FindObjectOfType(typeof(elevatorbutton));
	}
	
	
	
	// Update is called once per frame
	void Update() {
		if(button.door == true && (gameObject.transform.position.z > -18.3)){
			float myPos = gameObject.transform.position.z;
			transform.Translate(Vector3.up * (moveSpeed * Time.deltaTime));
		}

	}
}
