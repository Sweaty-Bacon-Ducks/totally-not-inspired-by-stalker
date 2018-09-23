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

    public GameEventListener listener;

    private void Start()
    {
        bulletsInMagazine = gunStats.magazineSize;
        listener.Response.AddListener(ReloadEvent);
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
        shootTimer += Time.deltaTime;
    }

    IEnumerator Reload()
    {
        GetComponent<AudioSource>().clip = gunStats.reloadSound;
        GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length); //gunStats.reloadTime

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


        GetComponent<AudioSource>().clip = gunStats.shootSounds[0];
        GetComponent<AudioSource>().Play();

        shootTimer = 0;
        bulletsInMagazine--;
    }
}
