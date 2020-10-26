using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button2Script : MonoBehaviour
{
    public Image enumLocation;
    public GameObject showCanvas;
    public Button hide;
    public Button enumLocationWrong;

    public void showLocation()
    {
        showCanvas.SetActive(true);
        enumLocation.enabled = true;
        hide.gameObject.SetActive(false);
        enumLocationWrong.interactable = false;
    }
}
