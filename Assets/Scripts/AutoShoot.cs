using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShoot : MonoBehaviour
{
    public GameObject player;
    public GameObject bulletPrefab;
    public float fireRate = 3f; // Частота стрільби в пострілах за секунду
    public float range = 10f; // Максимальна дальність стрільби
    public float speed = 10f; // Максимальна дальність стрільби

    private float nextFireTime = 0f;

    void FixedUpdate()
    {
        nextFireTime += Time.deltaTime;
        GameObject nearestEnemy = FindClosestEnemy();
        if (nextFireTime >= fireRate)
        {
            if (nearestEnemy != null)
            {
                nextFireTime = 0f;
                Shoot(nearestEnemy.transform.position);
            }
        }
        
        /*
        if (Time.time >= nextFireTime)
        {
            GameObject nearestEnemy = FindClosestEnemy();
            if (nearestEnemy != null)
            {
                Shoot(nearestEnemy.transform.position); 
                //nextFireTime = fireRate + Time.deltaTime;
                nextFireTime = Time.time + 1f / fireRate;
            }
        }*/
    }

    GameObject FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject nearest = null;
        float minDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (distance < minDistance && distance <= range)
            {
                minDistance = distance;
                nearest = enemy;
            }
        }
        return nearest;
    }

    void Shoot(Vector3 target)
    {
        // Створюємо снаряд і направляємо його в ціль
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Vector3 direction = target - transform.position;
        bullet.GetComponent<Rigidbody>().velocity = direction.normalized * speed ; // Приклад з використанням Rigidbody
    }
}