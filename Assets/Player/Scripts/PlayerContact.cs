using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContact : MonoBehaviour
{
    public Transform player;
    public Transform platform;

    private Collider _collider;

    private void Start()
    {
        _collider = GetComponent<Collider>();
    }

    float PlayerHealth = 100;
    float Damage = 200;

    private void OnCollisionEnter(Collision collision)
    {
        if (_collider.gameObject.tag == "Player")
        {
            Debug.Log("Contact!");
            TakeDamage();
        }
    }
    void TakeDamage()
    {
        if (PlayerHealth >= 0)
        {
            PlayerHealth = (PlayerHealth - Damage);
        }
    }
}
