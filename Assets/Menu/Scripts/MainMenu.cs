using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Level1Scene"); // Load the game scene
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay"); // goes to How to play
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu"); //returns to the menu
    }


    public void Exit()
    {
        Application.Quit(); // Quit the application
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver"); // GameOver Scene is prompted.
    }

    //public void NextLevel()
    //{

    //}
}

