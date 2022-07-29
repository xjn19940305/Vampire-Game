using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 子弹
/// </summary>
public class MagicMissileMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 direction;
    private playerController playerController;
    private GameObject LocateEnemy()
    {
        var Collider2dList = new Collider2D[5];
        Physics2D.OverlapCircleNonAlloc(transform.position, 20, Collider2dList);
        foreach (var collider in Collider2dList)
        {
            if (collider != null && collider.CompareTag("Enemy"))
            {
                return collider.gameObject;
            }
        }
        return null;
    }
    private Vector2 MoveDirection(Transform target)
    {
        playerController = GameObject.Find("Player").GetComponent<playerController>();
        //通过面向判断子弹飞行的方向
        var direction = new Vector2(playerController.faceDirection, 0);
        if (target != null)
        {
            direction = (Vector2)(target.position - transform.position);
            direction.Normalize();
        }
        return direction;
    }
    private void Awake()
    {
        var Enermy = LocateEnemy();
        direction = MoveDirection(Enermy?.transform ?? null);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
        Destroy(gameObject, 3f);
    }

    private void FixedUpdate()
    {
        var targetPosition = (Vector2)transform.position + direction;
        //print(targetPosition);
        rb.DOMove(targetPosition, speed).SetSpeedBased();

    }
}
