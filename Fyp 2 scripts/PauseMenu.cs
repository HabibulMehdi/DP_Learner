using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;
    public Canvas mainCanvas;
    public Canvas dialogueCanvas;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        mainCanvas.gameObject.SetActive(true);
        dialogueCanvas.gameObject.SetActive(true);
    }


    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        mainCanvas.gameObject.SetActive(false);
        dialogueCanvas.gameObject.SetActive(false);
    }

    /*public void LoadMenu()
    {
        SceneManager.LoadScene("AbstractFactory");
        Debug.Log("Loading menu....");
    }*/

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
        Debug.Log(" Loading Main Menu......");
        
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game....");
        Application.Quit();
    }
}
