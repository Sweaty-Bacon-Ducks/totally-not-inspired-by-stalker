using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AmmoType : ScriptableObject {

    public string Name;
    public Sprite Sprite;

    public GameObject BulletPrefab;
}
