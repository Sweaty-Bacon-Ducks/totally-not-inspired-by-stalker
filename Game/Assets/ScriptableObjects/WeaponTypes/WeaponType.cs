using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WeaponType : ScriptableObject {

    public List<AmmoType> AmmoTypes;
    public EmptyVariable WeaponClass;
}