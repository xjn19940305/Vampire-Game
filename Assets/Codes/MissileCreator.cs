using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCreator : MonoBehaviour
{
    [SerializeField] private GameObject missile;
    [SerializeField] private Transform PlayerTransform;
    public void Create()
    {
        //print("ÃæÏò:" + PlayerTransform.rotation);
        Instantiate(missile, new Vector3(PlayerTransform.position.x, PlayerTransform.position.y - 1.5f, PlayerTransform.position.z), Quaternion.identity);
    }
}
