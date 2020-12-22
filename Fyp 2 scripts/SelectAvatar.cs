using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectAvatar : MonoBehaviour
{
    public Text characterName;
    public Button aj, kate, james, louise;
    public void aj_Button()
    {
        characterName.text = "aj";
        PlayerPrefs.SetString("character",characterName.text);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void kate_Button()
    {
        characterName.text = "kate";
        PlayerPrefs.SetString("character", characterName.text);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void louise_Button()
    {
        characterName.text = "louise";
        PlayerPrefs.SetString("character", characterName.text);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void james_Button()
    {
        characterName.text = "james";
        PlayerPrefs.SetString("character", characterName.text);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
