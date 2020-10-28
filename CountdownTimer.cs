using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    string currentTime;
    float seconds = 0f;
    float minutes = 1f;
    float count = 0f;

    [SerializeField] Text countdownText;
     void Start()
    {
        count = minutes * 60;
        minutes--;
        currentTime = minutes.ToString() + ":" + seconds.ToString();
        seconds = 60;
    }

     void Update()
    {
        count -= 1 * Time.deltaTime;
        seconds -= 1 * Time.deltaTime;

        if(seconds <= 0 && minutes != 0)
        {
            seconds = 60;
            minutes -= 1;
        }
        currentTime = minutes.ToString() + ":" + seconds.ToString();
        // print(currentTime);
       
        countdownText.text = currentTime;
       
        if (count <= 0)
        {
            currentTime = "0";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }
}
