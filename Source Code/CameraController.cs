using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float cameraWidth = 10f; // Adjust this value to control the width of the camera.

    private void Update()
    {
        // Update the camera's position based on the player's position
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);

        // Adjust the orthographic size to control the width of the camera
        Camera.main.orthographicSize = cameraWidth / 2f;
    }
}
