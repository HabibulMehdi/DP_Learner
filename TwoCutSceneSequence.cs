using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// for two Cameras//
public class TwoCutSceneSequence : MonoBehaviour
{

    // Animation Camera
    public GameObject Cam1;
    public GameObject Cam2;
    // Initializing the UI components
    public GameObject dialogBox;
    public Canvas mainCanvas;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(4);
        // making the camera 1 off and camera 2 on
        Cam1.SetActive(false);
        Cam2.SetActive(true);

        yield return new WaitForSeconds(4);
        // Making Camera 2 off
        Cam2.SetActive(false);
        dialogBox.SetActive(true);
        mainCanvas.gameObject.SetActive(true);
    }
}
