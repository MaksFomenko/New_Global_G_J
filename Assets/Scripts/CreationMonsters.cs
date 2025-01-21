using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreationMonsters : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> EntitiSpaven;
    public GameObject enemyPrefab;
    public float minDistance = 2f;
    public float maxDistance = 3f;
    public float spawnInterval = 60f;
    private float timer = 0f;
    public List<GameObject> suitableSpawnPoints = new List<GameObject>();

    void Update()
    {
        
        foreach (GameObject obj in EntitiSpaven)
        {
            timer += Time.deltaTime;
            float distance = Vector3.Distance(player.transform.position, obj.transform.position);

            if (distance >= minDistance && distance <= maxDistance)
            {
                suitableSpawnPoints.Add(obj);
            }
                if (timer >= spawnInterval)
                {
                    timer = 0f;
                    SpawnEnemy();
                }
        }
    }
    
    void SpawnEnemy()
    {
        if (suitableSpawnPoints.Count > 0)
        {
            // Вибираємо випадкову точку зі списку відповідних точок
            int randomIndex = Random.Range(0, suitableSpawnPoints.Count);
            Vector3 spawnPosition = suitableSpawnPoints[randomIndex].transform.position;

            // Спавнюємо ворога
            GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
    
}
