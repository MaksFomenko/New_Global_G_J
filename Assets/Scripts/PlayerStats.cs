using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public float healthRegenRate;

    // Броня та ухилення
    public int armor;
    public float dodgeChance;

    // Рух
    public float moveSpeed;

    // Атака
    public int damage;
    public float spellRange;
    public float cooldown;
    public float criticalChance;
    public float criticalDamageMultiplier;

    // Інші характеристики
    public int experience;
    public float luck;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int _damage)
    {
        // Розрахунок отриманого ушкодження з урахуванням броні та ухилення
        int finalDamage = Mathf.Max(0, _damage - armor);
        if (Random.value <= dodgeChance)
        {
            // Ухилення
            return;
        }

        currentHealth -= finalDamage;
        if (currentHealth <= 0)
        {
            // Смерть гравця
            // ...
        }
    }
}
