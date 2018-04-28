using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square_script : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate(10*Time.deltaTime,10*Time.deltaTime,10*Time.deltaTime);
	}
}
