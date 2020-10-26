using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn0CameraScript : MonoBehaviour
{
    /*private Camera maincam, puzzlecam;
    private Button btn;*/
    public Image carFactory, enumClass;
    public GameObject showCanvas;

    // Start is called before the first frame update
    void Start()
    {

        showCanvas.SetActive(false);
        /*puzzlecam = GameObject.FindWithTag("PuzzleCamera").GetComponent<Camera>();
        puzzlecam.gameObject.SetActive(false);
        btn = GameObject.FindWithTag("PuzzleBtn").GetComponent<Button>();
        btn.gameObject.SetActive(false);*/
        enumClass.enabled = false;
        carFactory.enabled = false;
    }

    public void camerasplit()
    {
        showCanvas.SetActive(true);
       /* maincam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        maincam.rect = new Rect(0f, 0f, 0.2f, 1f);
        puzzlecam.gameObject.SetActive(true);
        puzzlecam.rect = new Rect(0.3f, 0f, 1f, 1f);
        btn.gameObject.SetActive(true);*/

    }
}
