using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {


    float speed = 5f;
    float speedHor = 5f;


	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-Vector3.up * speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.up * speed*Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector3.right * speedHor*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speedHor*Time.deltaTime);
        }

        if (Input.GetMouseButton(1))
        {
            GetVelocity();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            GetSlowly();
        }

	}

    void GetVelocity()
    {
        speed+= 1;
        
        Debug.Log(speed);
    }

    void GetSlowly()
    {
        speed -= 1;
        Debug.Log(speed);
    }


}
