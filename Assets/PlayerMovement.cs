
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float moveSpeed = 5f;  // �������� ����������� ����

    void Update()
    {
        // �������� ���� � ������ WASD (��� �������)
        float moveX = Input.GetAxis("Horizontal");  // ������� �����-����� ��� A/D


        // ���������� ������ � ������ �������
        Vector3 move = new Vector3(0, 0, moveX) * moveSpeed * Time.deltaTime;

        // ��������� �������� � �������
        transform.Translate(move);
    }
}
