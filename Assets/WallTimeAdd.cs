using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTimeAdd : MonoBehaviour {


    Timer addTime;



	// Use this for initialization
	void Start () {
        addTime = GetComponent<Timer>();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            addTime.GetTime();
        }
    }


}
