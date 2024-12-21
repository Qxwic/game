using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject spherePrefab;
    private void OnTriggerEnter()
    {
        GameObject enemyInstance = Instantiate(spherePrefab, new Vector3(149, 10, -374), Quaternion.Euler(0f, -90f, 0f));
        Destroy(spherePrefab);
    }
}
