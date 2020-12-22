using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookStructural2 : MonoBehaviour
{
    public GameObject uiobject;
    public GameObject[] array_triggers = new GameObject[7];


    // Start is called before the first frame update
    void Start()
    {
        uiobject.SetActive(false);

        for (int i = 0; i < 7; i++)
        {
            array_triggers[i].SetActive(false);
        }
      
    }

    void OnTriggerEnter(Collider Player)
    {
        var book = GameObject.Find("bookStructural2");

        //Checking if the book is false then it's canvas is false
        if (book.active == false)
        {
            uiobject.SetActive(false);

        }
        else
        {
            uiobject.SetActive(true);
        }
        uiobject.SetActive(true);
    }
    void OnTriggerExit(Collider Player)
    {
        uiobject.SetActive(false);
        for (int i = 0; i < 7; i++)
        {
            array_triggers[i].SetActive(true);
        }

        var book = GameObject.Find("bookStructural2");
        book.SetActive(false);

    }
}

