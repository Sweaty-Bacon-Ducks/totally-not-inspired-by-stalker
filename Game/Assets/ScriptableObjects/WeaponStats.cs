using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponStats : ScriptableObject
{
    public string Name;
    public Sprite Sprite;
    public float Damage;
    public float TimeBetweenShots;
}
