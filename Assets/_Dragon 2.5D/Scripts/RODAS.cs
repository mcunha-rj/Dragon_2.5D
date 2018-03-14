using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RODAS : MonoBehaviour {

	public WheelCollider[] wheelCollider;
	public Transform[] rodas;

	private Vector3 pos;
	private Quaternion rot;

	
	void Update () {

		for(int i = 0; i < wheelCollider.Length; i++){
			wheelCollider[i].GetWorldPose(out pos, out rot);
			rodas[i].position = pos;
			rodas[i].rotation = rot;
		}
	}
}
