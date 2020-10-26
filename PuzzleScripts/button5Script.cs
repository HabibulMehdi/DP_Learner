using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button5Script : MonoBehaviour
{
    public Image enumLocation;
    public GameObject showCanvas;
    public Button hide;
    public Button enumLocationWrong;

    public void showEnumWrong()
    {
        showCanvas.SetActive(true);
        enumLocation.enabled = true;
        hide.gameObject.SetActive(false);
        enumLocationWrong.interactable = false;
    }
}