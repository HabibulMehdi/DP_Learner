using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject aj, james, kate, louise, ajCamera, kateCamera, louiseCamera, jamesCamera;
    
    
    public void Start()
    {
        string character_Name = PlayerPrefs.GetString("character");

        if (string.Equals(character_Name, "aj") == true)
        {
            aj.SetActive(true);
            ajCamera.SetActive(true);
            Minimap.player = aj.transform; 
        }
        else if (string.Equals(character_Name, "james") == true)
        {
            james.SetActive(true);
            jamesCamera.SetActive(true);
            Minimap.player = james.transform;
        }
        else if (string.Equals(character_Name, "kate") == true)
        {
            kate.SetActive(true);
            kateCamera.SetActive(true);
            Minimap.player = kate.transform;
        }
        else
        {
            louise.SetActive(true);
            louiseCamera.SetActive(true);
            Minimap.player = louise.transform;
        }
    }

}
