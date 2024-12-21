
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float moveSpeed = 5f;  // Скорость перемещения шара

    void Update()
    {
        // Получаем ввод с клавиш WASD (или стрелок)
        float moveX = Input.GetAxis("Horizontal");  // Стрелки влево-вправ или A/D


        // Перемещаем объект с учетом времени
        Vector3 move = new Vector3(moveX, 0, 0) * moveSpeed * Time.deltaTime;

        // Применяем движение к объекту
        transform.Translate(move);
    }
}
