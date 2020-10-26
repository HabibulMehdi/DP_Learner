using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button7Script : MonoBehaviour
{
    public Image wrongCarType;
    public GameObject showCanvas;
    public Button hide;
    public Button carType;
   

    public void showEnumWrong()
    {
        showCanvas.SetActive(true);
        wrongCarType.enabled = true;
        hide.gameObject.SetActive(false);
        carType.interactable = false;
    }

    
}
