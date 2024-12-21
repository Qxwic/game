using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class шар : MonoBehaviour
{
    // Скорость, с которой будет катиться шар
    public float speed = 10f;

    // Направление, в котором будет двигаться шар
    public Vector3 direction = Vector3.forward;

    // Ссылка на Rigidbody компонента шара
    private Rigidbody rb;

    void Start()
    {
        // Получаем Rigidbody, если он еще не назначен
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Проверяем, была ли нажата клавиша пробела
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Применяем силу к шару в заданном направлении
            rb.AddForce(direction.normalized * speed, ForceMode.VelocityChange);
        }
    }
    
}
