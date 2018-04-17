using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPosition : MonoBehaviour {

    Wall wallReset;

    Vector3 originalPos;

    void Start()
    {
        wallReset =GetComponent<Wall>();



    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            wallReset.transform.position = originalPos;
        }

    }
}
