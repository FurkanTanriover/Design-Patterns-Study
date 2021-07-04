using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFD : MonoBehaviour
{
    [SerializeField] private EnemyDataFD enemyDataFD = null;

    private float currentSpeed = 0f;
    private int currentHp = 100;
    
    private void Start()
    {
        var speed = enemyDataFD.MAXSpeed;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveForward();
        }
    }
    void MoveForward()
    {
        transform.Translate(Vector3.forward * enemyDataFD.MAXSpeed);
    }

}
