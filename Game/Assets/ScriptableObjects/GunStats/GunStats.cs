using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GunStats : WeaponStats {

    public float BulletSpread;
    public int BulletCount;
    public float BulletLifeTime;
    public int MagazineSize;
    public float BulletSpeed;
    public float ReloadTime;

    public float NextFireTimer;
    public int BulletsInMagazine;
    public bool IsReloading;

    public WeaponType WeaponType;
}
