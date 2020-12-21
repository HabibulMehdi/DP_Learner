using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCodeScript : MonoBehaviour
{
    public Image image, image1, image2, image3, image4, image5, image6, image7;
    public Text text, text1, text2, text3, text4, text5, text6, text7;
    public GameObject showCanvas;
    public Button hide;
    public Button done;
    public GameObject resultCanvas;

    private void Start()
    {
        showCanvas.SetActive(false);
        image.enabled = false;
        image1.enabled = false;
        image2.enabled = false;
        image3.enabled = false;
        image4.enabled = false;
        image5.enabled = false;
        image6.enabled = false;
        image7.enabled = false;
        done.gameObject.SetActive(false);
        resultCanvas.gameObject.SetActive(false);

        //Setting text false
        text.gameObject.SetActive(false);
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);
        text4.gameObject.SetActive(false);
        text5.gameObject.SetActive(false);
        text6.gameObject.SetActive(false);
        text7.gameObject.SetActive(false);
    }

    public void show()
    {
        showCanvas.SetActive(true);
        image.enabled = true;
        text.gameObject.SetActive(true);
        hide.gameObject.SetActive(false);
    }
}
