using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    float Velocity = 10;
    float speed = 5f;
    float speedHor = 5f;
    Vector3 playerPos;



    void Start()
    {
        playerPos = transform.position;
        transform.position = new Vector3(-22, 155, 8);

    }
	void Update ()
    {

        float moveH = Input.GetAxis("Mouse X")*Velocity * Time.deltaTime;
       float moveV = Input.GetAxis("Mouse Y")*Velocity * Time.deltaTime;

        transform.Translate(moveH, 0, 0);
        transform.Translate(0, 0, moveV);

        if (Input.GetMouseButton(1))
        {
            GetVelocity();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            GetSlowly();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-Vector3.up * speed * Time.deltaTime);
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
