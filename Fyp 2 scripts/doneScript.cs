using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class doneScript : MonoBehaviour
{
    public GameObject resultCanvas;
    public GameObject first_canvas;
    public Button done;
    public Button wrong1, wrong2;
    public Text scoreText;
    const string publicCode = "5fd7c239eb36fe27143bbef1";
    const string webURL = "http://dreamlo.com/lb/";
    Highscore[] highscoresList;
    int len;
    string _username;
    int _score;

    public void Start()
    {
        StartCoroutine("DownloadHighscoresFromDatabase");
    }
    public void showCanvas()
    {
        first_canvas.gameObject.SetActive(false);
        resultCanvas.gameObject.SetActive(true);
        _username = PlayerPrefs.GetString("Username");
        
        for(int z = 0; z < len; z++)
        {
            if (highscoresList[z].username == _username)
            {
                _score = highscoresList[z].score;
                break;
            }
                
        }

        if (wrong1.interactable == false && wrong2.interactable == false)
        {
            scoreText.text = "10/10";
            _score = _score + 10;
            Highscores.AddNewHighscore(_username, _score);
        }
        else if (wrong1.interactable == false || wrong2.interactable == false)
        {
            scoreText.text = "5/10";
            _score = _score + 5;
            Highscores.AddNewHighscore(_username, _score);
        }
            
        else
        {
            scoreText.text = "0/10";
            _score = _score + 0;
            Highscores.AddNewHighscore(_username, _score);
        }
        
    }

   /* public void DownloadHighscores()
    {
        DownloadHighscoresFromDatabase();
    }
*/
    IEnumerator DownloadHighscoresFromDatabase()
    {
        WWW www = new WWW(webURL + publicCode + "/pipe/");
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            FormatHighscores(www.text);
        }
        else
        {
            print("Error Downloading: " + www.error);
        }
    }

    void FormatHighscores(string textStream)
    {
        string[] entries = textStream.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
        highscoresList = new Highscore[entries.Length];
        len = entries.Length;
        for (int i = 0; i < entries.Length; i++)
        {
            string[] entryInfo = entries[i].Split(new char[] { '|' });
            string username = entryInfo[0];
            int score = int.Parse(entryInfo[1]);
            highscoresList[i] = new Highscore(username, score);
            //Debug.Log(highscoresList[i].username + ": " + highscoresList[i].score);
        }

    }
}
