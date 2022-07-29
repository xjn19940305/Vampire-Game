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
    private int _faceDirection = 1;
    public int faceDirection
    {
        get { return _faceDirection; }
    }
    public void Move(CallbackContext context)
    {
        _inputDirction = context.ReadValue<Vector2>();
        //transform.Translate(inputDir);
        if (_inputDirction.x > 0)
        {
            _faceDirection = 1;
        }
        else if (_inputDirction.x < 0)
        {
            _faceDirection = -1;
        }
    }



    public void FixedUpdate()
    {
        var position = (Vector2)transform.position;
        var targetPosition = position + _inputDirction;
        if (position == targetPosition) return;
        ///将玩家瞬移到指定地点
        //print(targetPosition);
        if (targetPosition.x < -20.50 || targetPosition.x > 20.69 || targetPosition.y > 9.97 || targetPosition.y < -8.77)
            return;
        rb.DOMove(targetPosition, speed).SetSpeedBased();
    }
}
