
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 20;

    private void OnTriggerEnter(Collider other)
    {
        // Перевірка на зіткнення з ворогом
        if (other.CompareTag("Enemy"))
        {
            // Знаходимо скрипт EnemyCharacterisctics на ворогу
            EnemyСharacteristics enemy = other.GetComponent<EnemyСharacteristics>();

            if (enemy != null)
            {
                // Застосовуємо ушкодження ворогу
                enemy.TakeDamage(damage);
            }

            // Знищуємо кулю
            Destroy(gameObject);
        }
    }
}
