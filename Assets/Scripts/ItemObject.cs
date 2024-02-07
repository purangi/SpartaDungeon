using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public ItemData item;

    public string GetItemName()
    {
        return item.displayName;
    }

    public string GetItemDescription()
    {
        return item.description;
    }

    public void OnBuy()
    {
        Inventory.instance.AddItem(item);
        Debug.Log(item.displayName + "을 구매했음.");
        GameManager.instance.Pay(item.price);
        Destroy(gameObject);
    }
}
