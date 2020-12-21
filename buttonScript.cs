using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour
{
    public Image wrongAnswer1, rightAnswer1, rightAnswer2, rightAnswer3, rightAnswer4, rightAnswer5, rightAnswer6,
        wrongAnswer2;
    
    public GameObject showCanvas;
    public Button hide;
    public Button done;
    public GameObject resultCanvas;

    private void Start()
    {
        showCanvas.SetActive(false);
        rightAnswer1.enabled = false;
        rightAnswer2.enabled = false;
        rightAnswer3.enabled = false;
        rightAnswer4.enabled = false;
        rightAnswer5.enabled = false;
        rightAnswer6.enabled = false;
        wrongAnswer2.enabled = false;
        wrongAnswer1.enabled = false;
        done.gameObject.SetActive(false);
        resultCanvas.gameObject.SetActive(false);
    }

    public void showCarFactory()
    {
        showCanvas.SetActive(true);
        rightAnswer1.enabled = true;
        hide.gameObject.SetActive(false);
    }
    
}
