using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square_script : MonoBehaviour {
<<<<<<< HEAD

=======
    float speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
>>>>>>> e58d469e5d5541fe1cb9c8194597fc1e3681eeb5
	// Update is called once per frame
	void Update () {
		transform.Rotate(1 * speed * Time.deltaTime, 1*speed*Time.deltaTime, 1 * speed * Time.deltaTime);
	}
}
