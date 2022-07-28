using System.Collections;
using System.Collections.Generic;
using Timers;
using UnityEngine;

public class MagicMissile : MonoBehaviour
{
    [SerializeField] private MissileCreator missileCreator;

    private void LaunchMissile()
    {
        missileCreator.Create();
    }
    private void Awake()
    {
        TimersManager.SetLoopableTimer(this, 2, LaunchMissile);        
    }
}
