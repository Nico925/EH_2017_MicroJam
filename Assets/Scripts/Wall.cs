using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour {


    public GameObject objWall2;
    public GameObject objWall;
    Vector3 startPosition;
    public float objectSpeed = 5;
    

   
    void Start () {

       startPosition = transform.position;
       
    }
	




	void Update () {

      
          transform.Translate(Vector3.up * (objectSpeed * Time.deltaTime));

         if (transform.localPosition.y>=100)
         {
             transform.position = startPosition;

            objWall.SetActive(false);
            objWall2.SetActive(true);
         }
         


    }



}
