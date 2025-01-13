using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[SelectionBase]
public class Player_Controller : MonoBehaviour
{

    #region Editor Data 
        [Header("Movement Attributes")]
        [SerializeField] float _moveSpeed = 50f; 


        [Header("Dependencies")]
        [SerializeField] Rigidbody2D _rb;
        [SerializeField] Animation _animator;
        [SerializeField] SpriteRenderer _spriteRenderer;

    #endregion


    #region Internal Data
    private Vector2 _moveDir = Vector2.zero;
    #endregion 

    #region Tick 

    private void Update()
    {
        GatherInput();
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
            _rb.linearVelocity = _moveDir * _moveSpeed * Time.fixedDeltaTime;
        }
    #endregion
}
