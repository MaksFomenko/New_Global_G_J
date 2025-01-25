using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform; // Об'єкт, за яким камера буде стежити
    public Vector3 offset;
    public float camPositionSpeed = 5f;

    void Update()
    {
        Vector3 newCamPosition = new Vector3(offset.x + playerTransform.position.x, offset.y + playerTransform.position.y, offset.z + playerTransform.position.z);
        transform.position = Vector3.Lerp(transform.position, newCamPosition, camPositionSpeed * Time.deltaTime);
    }
}
