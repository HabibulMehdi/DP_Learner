using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// for 6-minutes
public class TimerSix : MonoBehaviour
{
    string currentTime;
    float seconds = 0f;
    float minutes = 6f;
    float count = 0f;

    // public GameObject TimeoverPanel;
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
        if (count > 0)
        {


            count -= 1 * Time.deltaTime;
            seconds -= 1 * Time.deltaTime;

            int s = (int)seconds;

            if (seconds <= 0 && minutes != 0)
            {
                seconds = 60;
                minutes -= 1;
            }
            currentTime = "0" + minutes.ToString() + ":" + s.ToString();
            countdownText.text = currentTime;
        }
        if (count <= 0)
        {
            currentTime = "0";
            //TimeoverPanel.gameObject.SetActive(true);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }
}

