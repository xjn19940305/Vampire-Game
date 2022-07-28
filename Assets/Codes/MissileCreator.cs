using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCreator : MonoBehaviour
{
    [SerializeField] private GameObject missile;
    [SerializeField] private Transform PlayerTransform;
    public void Create()
    {
        Instantiate(missile, PlayerTransform.position, Quaternion.identity);
    }
}
