using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InvenPopUp : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI selectedItemName;
    public TextMeshProUGUI selectedItemDescription;
    public TextMeshProUGUI selectedItemStats;
    public GameObject useButton;
    public GameObject equipButton;
    public GameObject unEquipButton;
    public GameObject sellButton;

    private bool equipped;
    private ItemData selectedItem;

    public void ShowPopUp(ItemData _selectedItem, bool _equipped)
    {
        equipped = _equipped;
        selectedItem = _selectedItem;

        selectedItemName.text = selectedItem.displayName;
        selectedItemDescription.text = selectedItem.description;

        selectedItemStats.text = string.Empty;

        for (int i = 0; i < selectedItem.consumables.Length; i++)
        {
            selectedItemStats.text += selectedItem.consumables[i].type.ToString() + selectedItem.consumables[i].value.ToString() + " ";
        }

        icon.sprite = selectedItem.icon;
        useButton.SetActive(selectedItem.type == ItemType.Consumable);
        equipButton.SetActive(selectedItem.type == ItemType.Equipable && !equipped);
        unEquipButton.SetActive(selectedItem.type == ItemType.Equipable && equipped);
        sellButton.SetActive(true);
        gameObject.SetActive(true);
    }

    private void ClearSelectedItemWindow()
    {
        selectedItemName.text = string.Empty;
        selectedItemDescription.text = string.Empty;

        selectedItemStats.text = string.Empty;

        useButton.SetActive(false);
        equipButton.SetActive(false);
        unEquipButton.SetActive(false);
    }

    public void ExipPopUp()
    {
        ClearSelectedItemWindow();
        gameObject.SetActive(false);
    }
}
