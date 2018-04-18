using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Point : MonoBehaviour {

    
    public Text score;
    int count;
    public Text wintext;
    public Text restart;

    void Start()
    {
      ;
        count = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Pick up"))
        {

            other.gameObject.SetActive(false);
            count = count +1;
            SetCount();

        }
    }


    void SetCount()
    {
        score.text = "" + count.ToString();
        if (count >= 10)
        {
            wintext.text = "WIN";
            restart.text = "RESTART";
        }
    }
}
