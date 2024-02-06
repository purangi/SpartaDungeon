using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EquipManager : MonoBehaviour
{
    public ItemData curEquip;
    public Transform equipParent;

    private PlayerStatus status;

    public static EquipManager instance;
    private void Awake()
    {
        instance = this;
        status = GetComponent<PlayerStatus>();
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
