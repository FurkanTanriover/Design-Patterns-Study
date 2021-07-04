using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName ="EnemyData", menuName ="Enemy Data")]
public class EnemyDataFD : ScriptableObject
{
    private float maxSpeed = 10f;
    private float attackRange = 50f;
    private float attackDamage = 10f;
    private float attackInterval = 5f;

    private int maxHp = 100;

    public int MAXHp => maxHp;
    public float MAXSpeed => maxSpeed;
    public float AttackRange => attackRange;
    public float AttackInterval => attackInterval;
    public float AttackDAMAGE => attackDamage;
}
