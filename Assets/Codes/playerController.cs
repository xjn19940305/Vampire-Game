using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
/// <summary>
/// 用户控制器
/// </summary>
public class playerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private Vector2 _inputDirction;
    [SerializeField] private float speed;
    public void Move(CallbackContext context)
    {
        _inputDirction = context.ReadValue<Vector2>();
        //transform.Translate(inputDir);
    }



    public void FixedUpdate()
    {
        var position = (Vector2)transform.position;
        var targetPosition = position + _inputDirction;
        if (position == targetPosition) return;
        ///将玩家瞬移到指定地点
        rb.DOMove(targetPosition, speed).SetSpeedBased();
    }
}
