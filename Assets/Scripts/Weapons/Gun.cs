using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    protected bool reloading = false;
    protected float shootTimer = 0;

    public Transform projectileSpawn;

    public GunStats gunStats;
    public AmmoStats loadedAmmo;

    private int bulletsInMagazine;

    private void Start()
    {
        bulletsInMagazine = gunStats.magazineSize;
    }

    public void ReloadEvent()
    {
        if (bulletsInMagazine < gunStats.magazineSize && reloading == false)
        {
            reloading = true;
            StartCoroutine("Reload");
        }
    }

    private void Update()
    {
        //if (Input.GetKey(KeyCode.R))
        //{
        //    if (bulletsInMagazine < gunStats.magazineSize && reloading == false)
        //    {
        //        reloading = true;
        //        StartCoroutine("Reload");
        //    }
        //}

        shootTimer += Time.deltaTime;
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(gunStats.reloadTime);

        bulletsInMagazine = gunStats.magazineSize;
        reloading = false;
    }

    public virtual void ShootCheck()
    {
        if (reloading == true || bulletsInMagazine == 0)
            return;

        if (shootTimer > gunStats.timeBetweenShots)
        {
            Shoot();
        }
    }

    public virtual void Shoot()
    {
        for (int i = 0; i < gunStats.bulletCount; ++i)
        {
            GameObject bullet = Instantiate(loadedAmmo.bulletPrefab, projectileSpawn.position, projectileSpawn.rotation);
            bullet.GetComponent<Bullet>().SpawnBullet(this);
        }

        shootTimer = 0;
        bulletsInMagazine--;
    }
}
