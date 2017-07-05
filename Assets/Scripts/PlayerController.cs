using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Rigidbody Player;
    public float speed;
    public float FlySpeed;
    public float Altitude;
    void Start()
    {
        FlySpeed = 0;
        Altitude = 0;
    }
    void Update()
    {
        //Fly Speed setting
        if(Input.GetKey(KeyCode.Q))
            FlySpeed += 0.1F;
        if (Input.GetKey(KeyCode.A))
            FlySpeed -= 0.1F;
        // Altitude Setting
        if (Input.GetKey(KeyCode.UpArrow))
            Altitude += 2F;
        if (Input.GetKey(KeyCode.DownArrow))
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
