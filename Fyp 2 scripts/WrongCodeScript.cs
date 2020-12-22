using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WrongCodeScript : MonoBehaviour
{
    public Image wrongImage;
    public Text wrongText;
    public GameObject showCanvas;
    public Button hide;
    public Button wrongButton;

    public void show()
    {
        showCanvas.SetActive(true);
        wrongImage.enabled = true;
        wrongText.gameObject.SetActive(true);
        hide.gameObject.SetActive(false);
        wrongButton.interactable = false;
    }
}
