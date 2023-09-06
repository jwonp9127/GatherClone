using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : GatherCharacterController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newGaze = value.Get<Vector2>();
        Vector2 WorldPos = _camera.ScreenToWorldPoint(newGaze);
        newGaze = (WorldPos - (Vector2)transform.position).normalized;

        if(newGaze.magnitude >= 0.9f)
        {
            CallLookEvent(newGaze);
        }
    }
}
