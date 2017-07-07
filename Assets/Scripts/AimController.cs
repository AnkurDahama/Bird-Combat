using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimController : MonoBehaviour {
    public Renderer AimmerMat;
    public GameObject Aimmer;
	// Use this for initialization
	void Start () {
        Aimmer.transform.localScale = new Vector3(0.0F, 0.0F, 0.0F);
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.Z))
        {
            Aimmer.transform.localScale = new Vector3(0.1312706F, 500.0002F, 0.01F);
        }
    if (Input.GetKeyUp(KeyCode.Z))
        {
            Aimmer.transform.localScale = new Vector3(0.0F, 0.0F, 0.0F);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        AimmerMat.material.SetColor("_Color", Color.green);
        Debug.Log("Target Set");
       // AimmerMat. = Color.green;
    }
    void OnTriggerExit(Collider other)
    {
        AimmerMat.material.SetColor("_Color", Color.red);
        Debug.Log("Target Not Set");
    }
}
