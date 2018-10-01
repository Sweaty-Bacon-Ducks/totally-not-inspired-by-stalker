using System.Collections;
using UnityEngine;

public class Entity : MonoBehaviour
{

    public float health = 10;

    public virtual void TakeDamage(float dmg)
    {
        health -= dmg;

        if (health <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Destroy(gameObject);
        Debug.Log("Dead");
    }
}
