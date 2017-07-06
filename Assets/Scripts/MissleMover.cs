using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleMover : MonoBehaviour {

    public Rigidbody Missle;
    public float speed;
	// Use this for initialization
	void Start () {

        speed = 700.0F;
        Missle.velocity = transform.forward * speed;
	}
}
