using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golem_movement : MonoBehaviour {

    // Use this for initialization

    Rigidbody myBody;
    float moveForce = 10f;

	void Awake () {
        this.myBody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        this.myBody.velocity = new Vector3(-h * this.moveForce, 0f, 0f);
	}
} // class


























