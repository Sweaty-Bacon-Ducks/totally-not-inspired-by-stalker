using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private Gun gun;
    public float time = 0;

    public void SpawnBullet(Gun gun)
    {
        this.gun = gun;

        transform.Rotate(new Vector3(0, Random.Range(-gun.gunStats.bulletSpread, gun.gunStats.bulletSpread), 0));
        GetComponent<Rigidbody>().velocity = transform.forward * gun.gunStats.bulletSpeed;
    }

    public void Update()
    {
        time += Time.deltaTime;

        if (time > gun.gunStats.bulletLifeTime)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Entity>())
        {
            other.gameObject.GetComponent<Entity>().TakeDamage(gun.gunStats.baseDamage);
        }

        Destroy(gameObject);
    }
}
