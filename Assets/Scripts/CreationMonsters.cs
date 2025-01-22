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
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;

        // Очищаємо список на початку кожного оновлення
        suitableSpawnPoints.Clear();

        foreach (GameObject obj in EntitiSpaven)
        {
            float distance = Vector3.Distance(player.transform.position, obj.transform.position);

            if (distance >= minDistance && distance <= maxDistance)
            {
                suitableSpawnPoints.Add(obj);
                
                
            }
        }
        if (suitableSpawnPoints.Count > 0)
        {
            if (timer >= spawnInterval)
            {
                timer = 0f;
                SpawnEnemy();
            }
        }
        
    }

    void SpawnEnemy()
    {
        // Вибираємо випадкову точку зі списку відповідних точок
            int randomIndex = Random.Range(0, suitableSpawnPoints.Count);
            Vector3 spawnPosition = suitableSpawnPoints[randomIndex].transform.position;

            // Спавнюємо ворога
            GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            Debug.Log("Випадкове число: " + randomIndex);
    }

}
