using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AmmoStats : ScriptableObject {

    public new string name;
    public string description;
    public Sprite sprite;

    public AmmoClass ammoClass;
    public float jammingMultiplier;
    public GameObject bulletPrefab;

    public float weight; // weight per round
    public float price;
}

public enum AmmoClass
{
    ShotgunShell,
    Type9mm
};
