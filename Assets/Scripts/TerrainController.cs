using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour {
    public GameObject Boom;
    void OnCollisionEnter(Collision other)
    {
        Instantiate(Boom, other.transform.position, Quaternion.identity);
        Destroy(other.gameObject);
    }
}
