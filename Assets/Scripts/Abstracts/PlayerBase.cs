using System;
using Cinemachine;
using Interface;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace Abstracts
{
    public abstract class PlayerBase: MonoBehaviour
    {
        [SerializeField] protected Rigidbody _rigidbody;
        [SerializeField] protected float _speed;
        [SerializeField] protected Collider _collider;
        [SerializeField] protected CinemachineVirtualCamera _virtualCamera;
        [SerializeField] protected PlayerInput _playerInput;
        
        protected Vector3 _moveDirection;



        public void OnMove(InputAction.CallbackContext value)
        {
            _moveDirection = value.ReadValue<Vector2>();
            _rigidbody.AddForce(new Vector3(_moveDirection.x, 0, _moveDirection.y) * _speed,ForceMode.VelocityChange);
        }
        protected void PlayerMove(Vector3 move)
        {
            _rigidbody.AddForce(move.x,0,move.y,ForceMode.VelocityChange);
        }
        
        protected void CalculateMovementInputSmoothing(Vector3 movement)
        {
        
            _moveDirection = Vector3.Lerp(movement, _moveDirection, Time.deltaTime * _speed);

        }
        
    }

    
}