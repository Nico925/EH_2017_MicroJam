using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour {


    public Text GameoverText;
    Vector3 startPosition;
    

	// Use this for initialization
	void Start () {

        startPosition = transform.position;
       
    }
	



	// Update is called once per frame
	void Update () {
        
        transform.Translate(0, 1, 0);
        

        if (transform.position.y>200)
        {
            transform.position = startPosition;

        }
        
        
	}

 

}
