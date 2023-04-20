using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TimeExtender : MonoBehaviour
{
    public float timeToAdd = 10f; // The amount of time to add to the timer
    public Timer Timer; // A reference to the Timer script that manages the game timer

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add time to the timer
            //Timer.AddTime(timeToAdd);

            // Destroy the collectible object
            Destroy(gameObject);
        }
    }
}
    
