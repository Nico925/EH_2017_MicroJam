using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameOver : MonoBehaviour {

    public Text restartText;
    public Text GameoverText;
    
   
    private void Start()
    {
        GameoverText.text = "";
        restartText.text = "";
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
            GameoverText.text = "GAMEOVER";
            restartText.text = "RESTART";
           
            
        }
    }

 
   
  
   
}
