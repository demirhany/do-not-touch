using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public string GameScene = "SampleScene";
    public string HighestScoreScene = "HighestScoreScene";

    public void changeToGameScene()
    { SceneManager.LoadScene(GameScene); }

    public void changeToHighestScoreScene()
    { SceneManager.LoadScene(HighestScoreScene); }

    public void quitGame()
    {
        Debug.Log("Game Closed");
        Application.Quit();
    }
}
