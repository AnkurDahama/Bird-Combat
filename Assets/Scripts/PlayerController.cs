using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour {
    public Rigidbody Player;
    public float speed;
    public float FlySpeed;
    public float Altitude;
    public Rigidbody missle;
    public GameObject missleSpawn;
    void Start()
    {
        FlySpeed = 0;
        Altitude = 0;
    }
    void Update()
    {
        //Fly Speed setting
        if(Input.GetKey(KeyCode.UpArrow))
            FlySpeed += 0.1F;
        if (Input.GetKey(KeyCode.DownArrow))
            FlySpeed -= 0.1F;
        // Altitude Setting
        if (Input.GetKey(KeyCode.O))
            Altitude += 2F;
        if (Input.GetKey(KeyCode.P))
            Altitude -= 2F;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 rotateAngle = new Vector3(0, 0, -0.3F);
            transform.Rotate(rotateAngle);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 rotateAngle = new Vector3(0, 0, 0.3F);
            transform.Rotate(rotateAngle);
        }
        


        if (Input.GetKeyDown(KeyCode.F))
        { 
            Instantiate(missle, missleSpawn.transform.position, missleSpawn.transform.rotation);
        }

    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal*2, Altitude, FlySpeed);
        Altitude = 0;
        Player.velocity = movement * speed;
        // Tilting Code
    }

}
