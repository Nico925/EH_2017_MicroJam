using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour {

    public Text winText;
    public Text restartText;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            winText.text = "WIN";
            restartText.text = "RESTART";


        }
    }
}
