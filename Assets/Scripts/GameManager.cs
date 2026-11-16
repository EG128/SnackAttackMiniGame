using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float score;
    public float timer = 60f;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject forTheKirk;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + score.ToString("F0");

        timerText.text = "Timer:" + timer.ToString("F0");


        timer -= Time.deltaTime;

        if(timer < 0)
        {
        if (score >= 10)
        {
            Debug.Log("You Win");
        }
        else if (score < 10)
        {
            Debug.Log("You Lose");
        }

        if( score > 15)
        {
            Destroy(forTheKirk);
            Debug.Log("YOOOOO");

        }

        }
       

        
    }
}
