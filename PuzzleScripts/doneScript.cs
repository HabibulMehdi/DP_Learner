using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class doneScript : MonoBehaviour
{
    public GameObject resultCanvas;
    public Image passImage, failImage;
    public GameObject first_canvas;
    public Button done;
    public Button btn7, btn5;

    public void showCanvas()
    {
        first_canvas.gameObject.SetActive(false);
        resultCanvas.gameObject.SetActive(true);

        if (btn7.interactable == false && btn5.interactable == false)
        {
            passImage.enabled = true;
            
            done.gameObject.SetActive(false);

        }
        else
        {
            failImage.enabled = true;
            done.gameObject.SetActive(false);

        }

    }
}
