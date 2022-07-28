using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 用户行为
/// </summary>
public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private Health health;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("IncreaseHP"))
        {
            health.IncreaseHealth(1);
            Destroy(collision.gameObject);
        }
    }
}
