using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    
    float timer;
    public Text timerText;
    public float TimeEnd = 60;
    public Text gameOverText;


	// Use this for initialization
	void Start () {
		
	}
	


	// Update is called once per frame
	void Update ()
    {
        TimeEnd -= Time.deltaTime;
        timerText.text = TimeEnd.ToString();
    }

    public void GetTime()
    {
        
        TimeEnd += 10;
         
        
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            GetTime();
        }
    }

    void TimeZero()
    {
        if (TimeEnd <= 0)
        {
            gameOverText.text = "GAMEOVER";
            Time.timeScale = 0;
        }
    }
  

}
