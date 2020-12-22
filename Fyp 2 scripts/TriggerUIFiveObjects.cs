using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// For 5 objects //  
public class TriggerUIFiveObjects : MonoBehaviour
{
    public GameObject uiobject;
    public GameObject off;
    [SerializeField] private GameObject[] triggers;
    short count = 0;
    int remainingObjects = 0;
    [SerializeField] Text objectsText;

    // Start is called before the first frame update
    void Start()
    {
        uiobject.SetActive(false);
        remainingObjects = triggers.Length;
        objectsText.text = "Remaining Objects: " + count + "/" + remainingObjects;
    }
    void OnTriggerEnter(Collider Player)
    {
        uiobject.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerExit(Collider Player)
    {
        uiobject.SetActive(false);
        off.SetActive(false);
        check_End();
    }

    public void check_End()
    {

        for (int i = 0; i < 5; i++)
        {
            if (!triggers[i].activeSelf)
            {
                count++;
                objectsText.text = "Remaining Objects: " + count + "/" + remainingObjects;
            }

            if (count == 5)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
