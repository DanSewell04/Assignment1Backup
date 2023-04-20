using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float totalTime = 60.0f;
    public Text countdownText;

    private float timeLeft;

    private void Start()
    {
        timeLeft = totalTime; // Set the initial time left
        UpdateCountdownText(); // Display the initial countdown text
    }

    private void Update()
    {
        timeLeft -= Time.deltaTime; // Subtract the elapsed time since the last frame from the total time left

        if (timeLeft <= 0)
        {
            timeLeft = 0;
            GameOver(); // When timer = 0, Game over screen initiated.
        }

        UpdateCountdownText(); // Update the countdown text
    }

    private void UpdateCountdownText()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);
        string timeString = string.Format("{0:0}:{1:00}", minutes, seconds);
        countdownText.text = "Time Left: " + timeString;
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver"); // GameOver Scene is prompted.
    }

}

