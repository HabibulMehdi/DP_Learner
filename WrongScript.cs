using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WrongScript : MonoBehaviour
{
    public Image correspondingImage;
    public GameObject showCanvas;
    public Button hide;
    public Button hideCarWrong;

    public void showEnumClass()
    {
        showCanvas.SetActive(true);
        correspondingImage.enabled = true;
        hide.gameObject.SetActive(false);
        hideCarWrong.interactable = false;
    }
}
