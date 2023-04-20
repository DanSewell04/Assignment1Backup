using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnCollision : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint; // Set this to the location where you want the player to respawn
    private bool isTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTriggered)
        {
            RespawnPlayer(other.gameObject);
            isTriggered = true; // Set the trap to triggered so that it doesn't kill the player again
        }
    }

    private void RespawnPlayer(GameObject player)
    {
        // Add code here to respawn the player, such as resetting their position and restoring their health
        player.transform.position = respawnPoint.position;
        Debug.Log("Player has been respawned!");
    }
}

