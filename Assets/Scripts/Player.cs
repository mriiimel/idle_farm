using System;
using Abstracts;
using Cinemachine;
using Interface;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;


public class Player: PlayerBase, IPlayer
    {
        public float PlayerSpeed
        {
            get => _speed;
        }

        public Collider PlayerCollider
        {
            get => _collider;
        }

        public Rigidbody PlayerRB 
        {
            get => _rigidbody;
        }

        private Vector3 _movement;

        private void Awake()
        {
            _moveDirection = new Vector3();
        }

        private void Update()
        {
            _movement = _moveDirection;
            CalculateMovementInputSmoothing(_movement);
        }

        private void FixedUpdate()
        {
            PlayerMove(_movement);
        }
        
    }
