using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float moveSpeed = 15.0f;

    void Start()
    {

    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float zoom = Input.GetAxis("Mouse ScrollWheel");

        Vector3 movement = new Vector3(horizontal, vertical, zoom *150) * moveSpeed * Time.deltaTime;

        transform.Translate(movement, Space.World);
        // Проверяем ось Z, чтобы не позволить отрицательные координаты
        if (transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }
}