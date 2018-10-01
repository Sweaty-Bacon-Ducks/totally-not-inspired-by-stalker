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

    public AmmoType LoadedAmmo;
    public WeaponType WeaponType;

    public void PasteStats(GunStats gunStats)
    {
        this.BulletSpread = gunStats.BulletSpread;
        this.BulletCount = gunStats.BulletCount;
        this.BulletLifeTime = gunStats.BulletLifeTime;
        this.MagazineSize = gunStats.MagazineSize;
        this.BulletSpeed = gunStats.BulletSpeed;
        this.ReloadTime = gunStats.ReloadTime;

        this.NextFireTimer = gunStats.NextFireTimer;
        this.BulletsInMagazine = gunStats.BulletsInMagazine;
        this.IsReloading = gunStats.IsReloading;

        this.LoadedAmmo = gunStats.LoadedAmmo;
        this.WeaponType = gunStats.WeaponType;
    }
}
