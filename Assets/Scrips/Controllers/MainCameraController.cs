using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainCameraController : MonoBehaviour
{
    public GameObject player;
    public float cameraSpeed = 5.0f;
    private void Update()
    {
        Vector2 PlayerPos = player.transform.position - this.transform.position;
        Vector2 move = new Vector2(PlayerPos.x * cameraSpeed * Time.deltaTime, PlayerPos.y * cameraSpeed * Time.deltaTime);
        this.transform.Translate(move);
    }
}