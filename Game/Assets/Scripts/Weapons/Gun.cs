using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon {

    public DictionaryObject GunsReference;

    public GunStats GunStats;

    private Transform projectileSpawn;

    private void Start()
    {
        projectileSpawn = transform.Find("BulletSpawn");
        GunStats.BulletsInMagazine = GunStats.MagazineSize;
    }

    public void ChangeGunStats(GunStats gunStats)
    {
        this.GunStats = ScriptableObject.CreateInstance<GunStats>();
        this.GunStats.PasteStats(gunStats);
        GunsReference.AddGun(GunStats);
    }

    public void ReloadCheck()
    {
        if (GunStats.BulletsInMagazine < GunStats.MagazineSize && GunStats.IsReloading == false)
        {
            GunStats.IsReloading = true;
            StartCoroutine("Reload");
        }
    }

    public IEnumerator Reload()
    {
        //GetComponent<AudioSource>().clip = gunStats.reloadSound;
        //GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(2); //gunStats.reloadTime

        GunStats.BulletsInMagazine = GunStats.MagazineSize;
        GunStats.IsReloading = false;
    }

    public override void FireCheck()
    {
        if (GunStats.IsReloading == true || GunStats.BulletsInMagazine == 0)
            return;

        if (GunStats.NextFireTimer > GunStats.TimeBetweenShots)
        {
            Fire();
        }
    }

    public override void Fire()
    {
        for (int i = 0; i < GunStats.BulletCount; ++i)
        {
            GameObject bullet = Instantiate(GunStats.LoadedAmmo.BulletPrefab, projectileSpawn.position, projectileSpawn.rotation);
            bullet.GetComponent<Bullet>().SpawnBullet(this);
        }


        //GetComponent<AudioSource>().clip = gunStats.shootSounds[0];
        //GetComponent<AudioSource>().Play();

        GunStats.NextFireTimer = 0;
        GunStats.BulletsInMagazine--;
    }

    private void Update()
    {
        GunStats.NextFireTimer += Time.deltaTime;
    }
}
