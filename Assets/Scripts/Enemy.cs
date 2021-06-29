using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyType enemyType = null;
    [SerializeField] private TextMeshPro typeText = null;
    void Start()
    {
        GetComponent<Renderer>().material.color = enemyType.enemyColor;
        transform.localScale = enemyType.enemyScale;
        typeText.text = enemyType.typeName;
    }


}
