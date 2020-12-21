using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Location : MonoBehaviour
{
 /*   private Camera maincam, puzzlecam;
    private Button btn;*/
    public Image location;
    // Start is called before the first frame update
    void Start()
    {
        /*puzzlecam = GameObject.FindWithTag("PuzzleCamera").GetComponent<Camera>();
        puzzlecam.gameObject.SetActive(false);
        btn = GameObject.FindWithTag("PuzzleBtn").GetComponent<Button>();
        btn.gameObject.SetActive(false);*/
        location.enabled = false;
    }
  /*  public void camerasplit()
    {
        maincam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        maincam.rect = new Rect(0f, 0f, 0.2f, 1f);
        puzzlecam.gameObject.SetActive(true);
        puzzlecam.rect = new Rect(0.3f, 0f, 1f, 1f);
        btn.gameObject.SetActive(true);
    }*/
    public void third_btn()
    {
        location.enabled = true;
    }
}
