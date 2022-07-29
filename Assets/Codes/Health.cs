using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
/// <summary>
/// 控制生命值
/// </summary>
public class Health : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private UnityEvent<int> healthChanged;
    public int Value
    {
        get { return health; }
    }

    public void SetHealth(int health)
    {
        this.health = health;
    }

    public void DecreaseHealth(int amount)
    {
        health -= amount;
        healthChanged.Invoke(health);
    }

    public void IncreaseHealth(int amount)
    {
        health += amount;
        healthChanged.Invoke(health);
    }

}
