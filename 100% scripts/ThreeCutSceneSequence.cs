using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class ThreeCutSceneSequence : MonoBehaviour
{
    // Animation Cameras 
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    // intiliaizing the UI components
    public Canvas mainCanvas;
    public GameObject dialogBox;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        // Making Cam2 on and Cam1 off
        yield return new WaitForSeconds(4);
        Cam2.SetActive(true);
        Cam1.SetActive(false);
        // Making Cam3 on and Cam2 off
        yield return new WaitForSeconds(4);
        Cam3.SetActive(true);
        Cam2.SetActive(false);
        yield return new WaitForSeconds(4);
        //Making cam3 off
        Cam3.SetActive(false);
        dialogBox.SetActive(true);
        mainCanvas.gameObject.SetActive(true);
    }
    
}
