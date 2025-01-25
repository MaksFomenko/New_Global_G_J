using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string name;
    public string description;
    public Sprite icon;

    public virtual void Use()
    {
        //Базові функцій
        //Можно оставити пустим
    }
}
