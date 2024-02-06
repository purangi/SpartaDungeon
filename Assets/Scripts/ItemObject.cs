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

    }
}
