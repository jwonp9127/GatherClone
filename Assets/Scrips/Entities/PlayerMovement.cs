using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

enum States
{
    run = 1,
    idle = 0
}


public class PlayerMovement : MonoBehaviour
{
    private GatherCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    [SerializeField] private int speed = 5;
    Animator animator;
    string animationState = "PlayerState";

    private void Awake()
    {
        _controller = GetComponent<GatherCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void Update()
    {
        UpdateState(_movementDirection);
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void UpdateState(Vector2 direction)
    {
        if (direction == Vector2.zero)
            animator.SetInteger(animationState, (int)(States.idle));
        else
            animator.SetInteger(animationState, (int)(States.run));
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= speed;
        _rigidbody.velocity = direction;
    }
}
