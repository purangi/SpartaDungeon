using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    public Button button;
    public Image icon;
    [SerializeField] private Image equipIcon;
    private ItemSlotUI curSlot;

    public int index;
    public bool equipped;


}
