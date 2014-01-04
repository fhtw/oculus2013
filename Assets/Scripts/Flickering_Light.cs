using UnityEngine;
using System.Collections;

public class Flickering_Light : MonoBehaviour {
	public float interval = 0.1f;
	public float maxIntensity = 5;
	public float maxRange = 6;
	private float lastTime = 0;
	

	private void Update(){
		
	
		if(lastTime + interval <= Time.time)
		{
			lastTime = Time.time;
			gameObject.light.range = Random.Range(0, maxRange);
			gameObject.light.intensity = Random.Range(0, maxIntensity);
		}
	}
}