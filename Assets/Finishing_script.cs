using UnityEngine;
using System.Collections;

public class Finishing_script : MonoBehaviour {

	public GameObject myDoorLeft;
	public GameObject myDoorRight;
	public GameObject myLight_01;
	public GameObject myLight_02;
	public GameObject myLight_03;
	public GameObject myLight_04;
	public float moveSpeed = 0.5f;
	private elevatorbutton button;
	bool started = false;
	private AudioSource _audioSource;
	public AudioClip myAudioClip;


	void Start () {
		button = (elevatorbutton)FindObjectOfType(typeof(elevatorbutton));
	}	
	
	// Update is called once per frame
		void Update () {
			if(started == true & myDoorLeft.transform.position.z < -17.1){
				myDoorLeft.transform.Translate(Vector3.down * (moveSpeed * Time.deltaTime));
			}
			if(started == true & myDoorRight.transform.position.z > -16.3){
				myDoorRight.transform.Translate(Vector3.up * (moveSpeed * Time.deltaTime));
			}
		}

		void Awake(){
			_audioSource = gameObject.GetComponentInChildren<AudioSource>();
		}

		void OnMouseDown(){
			if(started == false){
			button.door = false; // damit es sich nicht mit dem ersten script blockiert
				
				_audioSource.clip = myAudioClip;
				_audioSource.Play();
				StartCoroutine(LightShow());
			}
		}

		IEnumerator LightShow(){
		yield return new WaitForSeconds(4);
		myLight_02.gameObject.SetActive(false);
		started = true;
		yield return new WaitForSeconds(3);
		myLight_03.gameObject.SetActive(false);
		yield return new WaitForSeconds(3);
		myLight_01.gameObject.SetActive(false);
		yield return new WaitForSeconds(2.1f);
		myLight_04.gameObject.SetActive(false);
		}
}





