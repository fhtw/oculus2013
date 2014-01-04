using UnityEngine;
using System.Collections;

public class walk_sound : MonoBehaviour {
	
	
	private AudioSource _audioSource;
	public AudioClip walkSound;
	
	
	void Awake(){
		_audioSource = gameObject.GetComponentInChildren<AudioSource>();
	}
	
	void Update(){
		CharacterController controller = GetComponent<CharacterController>();
		if(controller.velocity.magnitude < 0.3){
			_audioSource.clip = walkSound;
			audio.pitch = Random.Range(0.75f, 0.8f);
			_audioSource.Play();
		}
		
		
	}

}