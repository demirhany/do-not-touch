using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighestSceneManagerScript : MonoBehaviour
{
    private string StartingPage = "StartingPageScene";
    public Text highestScore;
    void Start()
    {
        changeToScore();
    }
    public void changeToStartingPage()
    { SceneManager.LoadScene(StartingPage); }
    public void changeToScore()
    {
        Debug.Log("changeToScore is called in the highest score scene.");
        Debug.Log(PlayerPrefs.GetInt("HighScore") + " is high score.");
        highestScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
