using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectCodeScript : MonoBehaviour
{
    public GameObject showCanvas;
    public Button hide;
    public Image correctImage;
    public Text correctText;

    public void show()
    {
        showCanvas.SetActive(true);
        correctImage.enabled = true;
        correctText.gameObject.SetActive(true);
        hide.gameObject.SetActive(false);
    }
}
