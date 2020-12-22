using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookUI : MonoBehaviour
{
    public GameObject uiobject;
    public GameObject[] array_triggers = new GameObject[8];
    

    // Start is called before the first frame update
    void Start()
    {
        uiobject.SetActive(false);

        //Finding each prefab
        /*lamp = GameObject.Find("lamp04_A");
        lamp.SetActive(false);

        barrel01 = GameObject.Find("barrel04_B");
        barrel01.SetActive(false);
        
        barrel02 = GameObject.Find("barrel03_A 1");
        barrel02.SetActive(false);

        barrel03 = GameObject.Find("barrel03_A");
        barrel03.SetActive(false);*/

        for(int i = 0; i < 8; i++)
        {
            array_triggers[i].SetActive(false);
        }
/*        tire = GameObject.Find("tire_B");
        tire.SetActive(false);*/
    }

    void OnTriggerEnter(Collider Player)
    {
        var book = GameObject.Find("book01");

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
        
        var book = GameObject.Find("book01");
        book.SetActive(false);
           

        //tire.SetActive(true);
        //Setting each prefab triggers to true when the player has find the book
        /*lamp.SetActive(true);
        barrel01.SetActive(true);
        barrel02.SetActive(true);
        barrel03.SetActive(true);*/


    }
}
