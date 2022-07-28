using System.Collections;
using System.Collections.Generic;
using Timers;
using UnityEngine;
using UnityEngine.Events;

public class MagicMissile : MonoBehaviour
{
    [SerializeField] private MissileCreator missileCreator;
    [SerializeField] protected UnityEvent magicMissileEvent;
    [SerializeField] public float Times;
    private void LaunchMissile()
    {
        missileCreator.Create();
        magicMissileEvent.Invoke();
    }
    private void Awake()
    {
        TimersManager.SetLoopableTimer(this, Times, LaunchMissile);
    }
}
