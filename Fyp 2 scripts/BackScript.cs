using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackScript : MonoBehaviour
{
    public Button btn, btn1, btn2, btn3, btn4, btn5, btn6, btn7;
    public GameObject back;
    public Button done;

    public void goback()
    {
        back.SetActive(false);
        
        if(!btn.gameObject.activeSelf && !btn3.gameObject.activeSelf && !btn4.gameObject.activeSelf 
            && !btn6.gameObject.activeSelf && (!btn1.gameObject.activeSelf || btn1.interactable == false)
            && (!btn2.gameObject.activeSelf || btn2.interactable == false) 
            && (!btn5.gameObject.activeSelf || btn5.interactable == false) 
            && (!btn.gameObject.activeSelf || btn7.interactable == false))
        {
            done.gameObject.SetActive(true);
        }
    }
}
