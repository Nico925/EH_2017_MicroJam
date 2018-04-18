using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall2 : MonoBehaviour {
    
   
    
    Vector3 startPosition;
    public float objectSpeed = 5;



    void Start()
    {
        
        startPosition = transform.position;

    }





    void Update()
    {


        transform.Translate(Vector3.up * (objectSpeed * Time.deltaTime));

    }
}
