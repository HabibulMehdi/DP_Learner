using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class TriggerUIShow : MonoBehaviour
{
    public GameObject uiobject;
    
    
    // Start is called before the first frame update
    void Start()
    {
        uiobject.SetActive(false);
    }
    void OnTriggerEnter(Collider Player)
    {
        uiobject.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerExit(Collider Player)
    {
        uiobject.SetActive(false);
    }
}
