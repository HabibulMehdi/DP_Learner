using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button3Script : MonoBehaviour
{
    public GameObject showCanvas;
    public Button hide;
    public Image carMain;

    public void showCarMain()
    {
        showCanvas.SetActive(true);
        carMain.enabled = true;
        hide.gameObject.SetActive(false);
    }
    
}
