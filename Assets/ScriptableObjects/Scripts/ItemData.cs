using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipable,
    Consumable
}

public enum EquipType
{
    Atack,
    Defense
}

public enum ConsumeType
{
    HP,
    MP
}

[System.Serializable]
public class ItemDataEquipable
{
    public EquipType type;
    public float value;
}

[System.Serializable]
public class ItemDataConsumable
{
    public ConsumeType type;
    public float value;
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public int price;
    public ItemType type;
    public Sprite icon;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Equipable")]
    public ItemDataEquipable[] equipables;

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;
}
