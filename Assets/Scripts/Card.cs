using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName ="Card",menuName ="Card Type")]
public class Card : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite ýmage;

    public int mana;
    public int attack;
    public int health;
}
