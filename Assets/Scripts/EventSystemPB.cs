using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystemPB : MonoBehaviour
{
    private float nextFireTime ;
    private float interval = 30f;
    public int x;// Інтервал в секундах

    void FixedUpdate()
    {
        nextFireTime += Time.deltaTime;

        if (nextFireTime >= interval && x >=5)
        {
            Debug.Log("Випадкове число: " + nextFireTime);
            nextFireTime -= interval; // Скидаємо таймер
            x++;
        }
    }
}
