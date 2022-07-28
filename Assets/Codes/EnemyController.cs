using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 敌人控制器
/// </summary>
public class EnemyController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private PlayerManager playerManager;
    public void Awake()
    {
        playerManager = GameObject.Find("Manager").GetComponent<PlayerManager>();
    }
    public void FixedUpdate()
    {
        //获取玩家位置
        var playerPosition = playerManager.Position;
        //获取怪物位置
        var position = (Vector2)transform.position;
        //获取相差位置
        var direction = playerPosition - position;
        direction.Normalize();
        //获取需要移动的量
        var targetPosition = position + direction;
        //if (position == playerPosition)
        //    print("怪物抓到玩家了!");
        if (position == targetPosition) return;
        rb.DOMove(targetPosition, speed).SetSpeedBased();

    }
}
