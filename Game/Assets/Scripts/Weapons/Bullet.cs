using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Gun gun;
    public float time = 0;

    public void SpawnBullet(Gun gun)
    {
        this.gun = gun;

        transform.Rotate(new Vector3(0, Random.Range(-gun.GunStats.BulletSpread, gun.GunStats.BulletSpread), 0));
        GetComponent<Rigidbody>().velocity = transform.forward * gun.GunStats.BulletSpeed;
    }

    public void Update()
    {
        time += Time.deltaTime;

        if (time > gun.GunStats.BulletLifeTime)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Entity>())
        {
            other.gameObject.GetComponent<Entity>().TakeDamage(gun.GunStats.Damage);
        }

        Destroy(gameObject);
    }
}
