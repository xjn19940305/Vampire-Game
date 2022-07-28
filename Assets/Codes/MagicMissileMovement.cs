using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ×Óµ¯
/// </summary>
public class MagicMissileMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 direction;
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
        var direction = new Vector2(1, 0);
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
        rb.DOMove(targetPosition, speed).SetSpeedBased();

    }
}
