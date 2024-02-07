using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EquipManager : MonoBehaviour
{
    public ItemData curEquip;
    public Transform equipParent;


    public static EquipManager instance;
    private void Awake()
    {
        instance = this;
    }

    public void EquipNew(ItemData item)
    {
        UnEquip();
        curEquip = item;
    }

    public void UnEquip()
    {
        if (curEquip != null)
        {
            curEquip = null;
        }
    }
}
