using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookIterator : MonoBehaviour
{
    public GameObject uiobject;
    public GameObject[] array_triggers = new GameObject[8];


    // Start is called before the first frame update
    void Start()
    {
        uiobject.SetActive(false);

        for (int i = 0; i < 8; i++)
        {
            array_triggers[i].SetActive(false);
        }

    }

    void OnTriggerEnter(Collider Player)
    {
        var book = GameObject.Find("bookIterator");

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
        for (int i = 0; i < 8; i++)
        {
            array_triggers[i].SetActive(true);
        }

        var book = GameObject.Find("bookIterator");
        book.SetActive(false);
    }
}
