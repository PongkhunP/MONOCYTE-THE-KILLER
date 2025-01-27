using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Healing Object", menuName ="Inventory System/Items/Healing")]
public class HealObject : ItemObject
{
    public int restoreHealthValue;
    public void Awake()
    {
        type = ItemType.Heal;
    }
}
