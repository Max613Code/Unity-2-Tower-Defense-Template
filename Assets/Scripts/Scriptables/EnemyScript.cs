﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySO", menuName = "CustomObjects/Enemy")]
public class EnemyScript : ScriptableObject
{
    // Overrides the name attribute from ScriptableObject class
    public new string name;

    public int health;
    public int speed;
    public int rotRate;
    public int damage;
    public Color healthyColor;
    public Color damagedColor;
    public List<string> targetTags;
}
