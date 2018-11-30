using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour {
	public float playerSpeed = 3.0f;
	
	void Update()
	{
		var z = Input.GetAxis("Vertical")*Time.deltaTime*playerSpeed;

		transform.Translate(0,0,z);
		
		//VR Implemented
		transform.rotation = InputTracking.GetLocalRotation(XRNode.CenterEye);
	}
}
