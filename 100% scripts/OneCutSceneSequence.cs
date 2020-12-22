using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// for one Camera
public class OneCutSceneSequence : MonoBehaviour
{
    // Animation Camera
    public GameObject Cam1;
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
        // making the camera off
        Cam1.SetActive(false);
        dialogBox.SetActive(true);
        mainCanvas.gameObject.SetActive(true);
    }

}
