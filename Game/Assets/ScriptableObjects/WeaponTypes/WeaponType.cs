using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WeaponType : ScriptableObject {

    public List<AmmoType> AmmoTypes;
    public WeaponClass WeaponClass;
}

public enum WeaponClass
{
    Pistol,
    Shotgun
};