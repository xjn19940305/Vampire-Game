using System.Collections;
using System.Collections.Generic;
using Timers;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// ¹¥»÷Àà
/// </summary>
public class Attack : MonoBehaviour
{
    [SerializeField] private string target;
    [SerializeField] private UnityEvent attackEvent;    
    private bool _canAttack = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LimitAttact(collision);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        LimitAttact(collision);
    }
    public void LimitAttact(Collider2D collision)
    {
        if (!_canAttack) return;
        if (collision.CompareTag(target))
        {
            var damageabled = collision.GetComponent<Damageable>();
            damageabled.TakeDamage(1);
            _canAttack = false;
            TimersManager.SetTimer(this, 1, () =>
            {
                _canAttack = true;
            });
            attackEvent.Invoke();
        }
    }
}
