using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour {

    public Transform Door;
    float speed = 6;
	// Use this for initialization
	void Start () {
		
	}
	


	// Update is called once per frame
	void Update () {
        Door.transform.Translate(Vector3.up*(speed*Time.deltaTime));
	}


}
