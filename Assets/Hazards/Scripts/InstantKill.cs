using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InstantKill : MonoBehaviour
{
    private bool isTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTriggered)
        {
            isTriggered = true; // Set the trap to triggered so that it doesn't kill the player again
            GameOver();
            Debug.Log("You have died!");
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver"); // GameOver Scene is prompted.
    }
}
