using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerGaze : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    private GatherCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<GatherCharacterController>();
    }

    private void Start()
    {
        _controller.OnLookEvent += OnGaze;
    }

    public void OnGaze(Vector2 newGazeDirection)
    {
        FlipSplite(newGazeDirection);
    }

    private void FlipSplite(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;


    }
}
