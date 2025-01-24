using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyСharacteristics : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int damage = 30;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int _damage)
    {
        currentHealth -= _damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
