using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update() {
		transform.rotation = Quaternion.LookRotation (transform.position - target.position);
		float y = transform.localEulerAngles.y;
		if (y > 180) y -= 360;
		transform.localEulerAngles = new Vector3(
			transform.localEulerAngles.x + Random.Range(-0.2f, 0.2f),
			Clamp(y, -40.0f, 40.0f) + Random.Range(-0.8f, 0.8f),
			transform.localEulerAngles.z + Random.Range(-.2f,.2f)
		);
	}

	public static float Clamp(float value, float min, float max)  {  
		return (value < min) ? min : (value > max) ? max : value;  
	}
}