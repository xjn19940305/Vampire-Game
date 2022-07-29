using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Death : MonoBehaviour
{
    [SerializeField] private UnityEvent deathEvent;

    public void Awake()
    {
        
    }
    public void CheckDeath(int health)
    {
        if (health <= 0)
            Die();
    }
    public void Die()
    {
        gameObject.SetActive(false);
        deathEvent.Invoke();
    }
}
