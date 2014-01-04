using UnityEngine;
using System.Collections;

public class elevatorbutton : MonoBehaviour {
	public bool door;
	
	private AudioSource _audioSource;
	public AudioClip elevator_open;
	public AudioClip elevator_close;

	void Awake(){
		_audioSource = gameObject.GetComponentInChildren<AudioSource>();
	}

	void OnMouseDown() {

	 if(!door && !_audioSource.isPlaying){
			door = true;
			_audioSource.clip = elevator_close;
			_audioSource.Play();
		
		}
	}
}
