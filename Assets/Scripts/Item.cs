using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Data/Items/BaseItem",fileName = "BaseItem")]
public class Item :ScriptableObject
{
    public string name;
    public string description;
    public Sprite itemIcon;

    public virtual void Use()
    {
        //Базові функцій
        //Можно оставити пустим
    }
    public virtual void LMB_Down(){}
    public virtual void DMB_Down(){}
}