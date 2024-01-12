using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
public class LogicScript : MonoBehaviour
{
    public Text scoreText;
    public Text finalScore;
    public GameObject gameOverScreen;
    public GameObject bird;
    private AudioSource gameOverSound;
    public int playerScore;
    public string StartingPage = "StartingPageScene";
    private bool isGameOverSoundPlayed;

    [ContextMenu("Increase Score")]

    void Start()
    {
        gameOverSound = GetComponent<AudioSource>();
        gameOverSound.mute = true;
        isGameOverSoundPlayed = false;
    }

    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        finalScore.text = "Your score " +  playerScore.ToString();
        if(isGameOverSoundPlayed == false) 
        {
            gameOverSound.mute=false;
            gameOverSound.Play();
            isGameOverSoundPlayed = true;
            Debug.Log("game over");
        }
        if (PlayerPrefs.GetInt("HighScore") < playerScore) 
        { changeHighestScore(playerScore); }
        bird.transform.Rotate(0, 0, -15);
        gameOverScreen.SetActive(true);
    }

    public void changeToStartingPage()
    { SceneManager.LoadScene(StartingPage); }

    public void changeHighestScore(int playerScore)
    {
        Debug.Log("High score is changed.");
        PlayerPrefs.SetInt("HighScore", playerScore);
        Debug.Log(PlayerPrefs.GetInt("HighScore") + " is high score.");
    }
}
