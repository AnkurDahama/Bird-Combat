using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour {
    public GameObject Boom;
    void OnCollisionEnter(Collision other)
    {
        if(!other.gameObject.CompareTag("Player") && !other.gameObject.CompareTag("Terrain"))
        {
            Instantiate(Boom, other.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}