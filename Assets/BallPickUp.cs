using UnityEngine;
using System.Collections;

public class BallPickUp : MonoBehaviour {

	public AudioClip ImpactSound;
	private AudioSource _audioSource;
	private GameObject Ball;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void Awake(){
		Ball = GameObject.Find ("ball");
		_audioSource = Ball.GetComponentInChildren<AudioSource> ();
	}

	void OnMouseDown(){

		StartCoroutine (Pickup());
	}

	IEnumerator Pickup(){
		GameObject Character = GameObject.Find("Main Camera");

		if(Ball.CompareTag("Carryable") && (Vector3.Distance(Character.transform.position, Ball.transform.position) <= 2)){
			Ball.renderer.collider.rigidbody.isKinematic = true;
			/*Ball.renderer.collider.rigidbody.useGravity = false;
			Ball.renderer.collider.rigidbody.velocity = Vector3.zero;
			Ball.renderer.collider.rigidbody.angularVelocity = Vector3.zero;*/

			//Ball.AddComponent(DragRigidbody);
			
			Ball.transform.parent = Character.transform;
			//carrying = true;
			yield return new WaitForEndOfFrame();
			Ball.tag = "Carried";			
		}
	}

	void OnCollisionEnter(){
		_audioSource.clip = ImpactSound;
		_audioSource.Play();
	}

}
