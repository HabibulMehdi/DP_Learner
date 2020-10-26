using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button1Script : MonoBehaviour
{
    public Image enumClass;
    public GameObject showCanvas;
    public Button hide;
    public Button hideCarWrong;

    public void showEnumClass()
    {
        showCanvas.SetActive(true);
        enumClass.enabled = true;
        hide.gameObject.SetActive(false);
        hideCarWrong.interactable = false;
    }
}
