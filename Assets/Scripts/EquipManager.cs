using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EquipManager : MonoBehaviour
{
    public ItemData curWeapon;
    public ItemData curArmor;
    public Transform equipParent;

    public static EquipManager instance;
    private void Awake()
    {
        instance = this;
    }

    public void EquipNew(ItemData item)
    {
        switch((int)item.type)
        {
            case 0:
                UnEquip(0);
                curWeapon = item;
                break;
            case 1:
                UnEquip(1);
                curArmor = item;
                break;
        }
    }

    public void UnEquip(int type)
    {
        switch(type)
        {
            case 0:
                if(curWeapon != null)
                    curWeapon = null;
                break;
            case 1:
                if(curArmor != null)
                    curArmor = null;
                break;
        }
    }
}
