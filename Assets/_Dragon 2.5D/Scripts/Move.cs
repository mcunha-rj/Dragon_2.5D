using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	private float Speed { 
		get {return FindObjectOfType<TimeBehavirour>().m_speed;  }
		}


	void Update () {
		transform.Translate(Vector3.left * Speed * Time.deltaTime );

		if(transform.position.x < -50){
			transform.position = new Vector3(63f, transform.position.y, transform.position.z);
		}
	}
}
