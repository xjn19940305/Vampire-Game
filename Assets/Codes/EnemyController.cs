using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private PlayerManager playerManager;
    public void FixedUpdate()
    {
        //��ȡ���λ��
        var playerPosition = playerManager.Position;
        //��ȡ����λ��
        var position = (Vector2)transform.position;
        //��ȡ���λ��
        var direction = playerPosition - position;
        print(playerPosition);
        print(position);
        print(direction);
        
        direction.Normalize();
        //��ȡ��Ҫ�ƶ�����
        var targetPosition = position + direction;
        //if (position == playerPosition)
        //    print("����ץ�������!");
        if (position == targetPosition) return;
        rb.DOMove(targetPosition, speed).SetSpeedBased();

    }
}
