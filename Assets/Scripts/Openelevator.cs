using UnityEngine;
using System.Collections;

public class Openelevator : MonoBehaviour {
	private elevatorbutton button;
	public float moveSpeed = 0.5f;


	void Start(){
		
		button = (elevatorbutton)FindObjectOfType(typeof(elevatorbutton));
	}



	// Update is called once per frame
	void Update() {
		if(button.door == true && (gameObject.transform.position.z < -15.2)){
			float myPos = gameObject.transform.position.z;
			transform.Translate(Vector3.down * (moveSpeed * Time.deltaTime));
			print (myPos);
		}
	}


}


