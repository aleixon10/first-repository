using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square_script : MonoBehaviour {
    float speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(1 * speed * Time.deltaTime, 1*speed*Time.deltaTime, 1 * speed * Time.deltaTime);
	}
}
