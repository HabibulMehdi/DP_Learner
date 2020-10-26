using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button6Script : MonoBehaviour
{
    public GameObject showCanvas;
    public Button hide;
    public Image locationSubClass;

    public void showLocationSubClass()
    {
        showCanvas.SetActive(true);
        locationSubClass.enabled = true;
        hide.gameObject.SetActive(false);
    }
}
