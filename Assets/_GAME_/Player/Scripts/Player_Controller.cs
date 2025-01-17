using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[SelectionBase]
public class Player_Controller : MonoBehaviour
{

    #region Enums
    private enum Directions {UP, DOWN, LEFT, RIGHT}
    #endregion

    #region Editor Data 
        [Header("Movement Attributes")]
        [SerializeField] float _moveSpeed = 50f; 


        [Header("Dependencies")]
        [SerializeField] Rigidbody2D _rb;

        [SerializeField] Animator _animator;

        [SerializeField] SpriteRenderer _spriteRenderer;

    #endregion


    #region Internal Data
    private Vector2 _moveDir = Vector2.zero;
    private Directions _facingDirection = Directions.RIGHT;

    private readonly int _animMoveRight = Animator.StringToHash("Anim_Player_Move_Right");
    private readonly int _animIdleRight = Animator.StringToHash("Anim_Player_Idle_Right");
    private readonly int _animTop = Animator.StringToHash("Anim_Player_Top");
    private readonly int _animDown = Animator.StringToHash("Anim_Player_Down");


    #endregion 

    #region Tick 

    private void Update()
    {
        GatherInput();
        CalculateFacingDirection();
        UpdateAnimation();
    }


    private void FixedUpdate()
    {
        MovementUpdate();
    }

    #endregion


    #region Input Logic

    private void GatherInput()
    {
        _moveDir.x = Input.GetAxisRaw("Horizontal");
        _moveDir.y = Input.GetAxisRaw("Vertical");
        
    }
    #endregion

    #region Movement Logic
        private void MovementUpdate()
        {
            _rb.linearVelocity = _moveDir.normalized * _moveSpeed * Time.fixedDeltaTime;
        }
    #endregion

    #region Animation Logic
    private void CalculateFacingDirection()
    {
        if (_moveDir.y > 0)
        {
            _facingDirection = Directions.UP;
        }
        else if (_moveDir.y < 0)
        {
            _facingDirection = Directions.DOWN;
        }
        else if (_moveDir.x > 0)
        {
            _facingDirection = Directions.RIGHT;
        }
        else if (_moveDir.x < 0)
        {
            _facingDirection = Directions.LEFT;
        }
    }


    private void UpdateAnimation()
    {
        if (_facingDirection == Directions.LEFT)
        {
            _spriteRenderer.flipX = true;
        }
        else if (_facingDirection == Directions.RIGHT)
        {
            _spriteRenderer.flipX = false;
        }

        if (_moveDir.sqrMagnitude > 0) // Moving
        {
            if (_facingDirection == Directions.UP)
            {
                _animator.CrossFade(_animTop, 0);
            }
            else if (_facingDirection == Directions.DOWN)
            {
                _animator.CrossFade(_animDown, 0);
            }
            else
            {
                _animator.CrossFade(_animMoveRight, 0); // Utilisez des animations différentes selon la direction
            }
        }
        else
        {
            _animator.CrossFade(_animIdleRight, 0);
        }
    }

    #endregion
}
