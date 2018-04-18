using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddTime : MonoBehaviour {

    float time = 20;
    public Text timeText;
    public Text gameoverText;
    public Text restartText;

    void Start()
    {
        gameoverText.text = "";
        restartText.text = "";
    }


    void Update()
    {
        time -= Time.deltaTime;
        timeText.text = time.ToString("00");
        if(time <= 0)
        {
            time = 0;
            gameoverText.text = "GAMEOVER";
            restartText.text = "RESTART";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AddTime"))
        {

            time = time + 2;
        }
    }





}
