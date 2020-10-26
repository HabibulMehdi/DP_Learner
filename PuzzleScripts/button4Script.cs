using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button4Script : MonoBehaviour
{
    public GameObject showCanvas;
    public Button hide;
    public Image subCarClass;

    public void showSubCarClass()
    {
        showCanvas.SetActive(true);
        subCarClass.enabled = true;
        hide.gameObject.SetActive(false);
    }
}
