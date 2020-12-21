using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayHighscores : MonoBehaviour
{
	const string publicCode = "5fd7c239eb36fe27143bbef1";
	const string webURL = "http://dreamlo.com/lb/";
	public User[] highscoresList;
	public User[] topFive = new User[5];
	public Text[] highscoreFields;
	public Text[] scoreFields;
	
	void Start() 
	{
		StartCoroutine("DownloadHighscoresFromDatabase");
	}

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
		highscoresList = new User[entries.Length];

		for (int i = 0; i < entries.Length; i++)
		{
			string[] entryInfo = entries[i].Split(new char[] { '|' });
			string username = entryInfo[0];
			int score = int.Parse(entryInfo[1]);
			highscoresList[i] = new User(username, score);
		}

		topFive = find_Top_Five(highscoresList, entries.Length);
		for(int k = 0; k < 5; k++)
        {
			scoreFields[k].text = (topFive[k].score).ToString();
			highscoreFields[k].text = (k + 1) + ". " + topFive[k].username;
		}
	}

	public User[] find_Top_Five(User[] list, int len)
    {
		short count = 0;
		int highScore;
		string name;

		for(int i = 0; i < len; i++)
        {
			if (count == 5)
				break;
			highScore = list[i].score;
			name = list[i].username;
			
			for (int j = i+1; j < len-1; j++)
            {
				if (list[j].score > highScore)
				{
					highScore = list[j].score;
					name = list[j].username;
				}
				
			}
			topFive[count].username = name;
			topFive[count].score = highScore;
			count++;
			
        }

		return topFive;
    }

}

public struct User
{
	public string username;
	public int score;

	public User(string _username, int _score)
	{
		username = _username;
		score = _score;
	}



}
