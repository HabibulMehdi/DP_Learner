using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour
{
    public Image wrongCarType, carFactory, enumClass, enumLocation, carMainClass, carSubClass, locationSubClass,
        enumLocationWrong;
    
    public GameObject showCanvas;
    public Button hide;
    public Button done;
    public GameObject resultCanvas;
    public Image passImage, failImage;

    private void Start()
    {
        showCanvas.SetActive(false);
        carFactory.enabled = false;
        enumClass.enabled = false;
        enumLocation.enabled = false;
        carMainClass.enabled = false;
        carSubClass.enabled = false;
        locationSubClass.enabled = false;
        enumLocationWrong.enabled = false;
        passImage.enabled = false;
        failImage.enabled = false;
        wrongCarType.enabled = false;
        done.gameObject.SetActive(false);
        resultCanvas.gameObject.SetActive(false);
    }

    public void showCarFactory()
    {
        showCanvas.SetActive(true);
        carFactory.enabled = true;
        hide.gameObject.SetActive(false);
    }
    
}
