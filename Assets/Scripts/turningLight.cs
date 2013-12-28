using UnityEngine;
using System.Collections;

public class turningLight : MonoBehaviour {

	// This should be set to degrees per second
	float rotationAmount = 90.0f;
	
	void Update()
	{
		Vector3 rot = transform.rotation.eulerAngles;
		rot.y = rot.y + rotationAmount * Time.deltaTime;
		if(rot.y > 360)
			rot.y -= 360;
		else if(rot.y < 360)
			rot.y += 360;
		
		transform.eulerAngles = rot;
	}

}