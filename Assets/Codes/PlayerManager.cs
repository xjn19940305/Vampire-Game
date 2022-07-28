using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 控制中心
/// </summary>
public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    public Vector2 Position
    {
        get
        {
            return playerTransform.position;
        }
    }

}

