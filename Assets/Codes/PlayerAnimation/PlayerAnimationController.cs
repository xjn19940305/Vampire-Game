using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    //[SerializeField] private Transform playerTransform;
    [SerializeField] private string walkState;
    [SerializeField] private string idleState;
    [SerializeField] private string attackState;

    public void Move(CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        if (direction == Vector2.zero)
        {
            animator.Play(idleState);
        }
        else
        {
            animator.Play(walkState);
        }        
        if (direction.x > 0)
        {
            //playerTransform.rotation = Quaternion.Euler(0, 0, 0);
            spriteRenderer.flipX = false;
            //transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (direction.x < 0)
        {
            spriteRenderer.flipX = true;
            //transform.rotation = Quaternion.Euler(0, 180, 0);
            //playerTransform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    public void Attack()
    {
        animator.Play(attackState);
    }
}
