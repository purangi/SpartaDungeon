using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject buttonPanel;
    [SerializeField] private GameObject statusPanel;
    [SerializeField] private GameObject invenPanel;
    [SerializeField] private GameObject shopPanel;

    private void Awake()
    {

    }

    private void Start()
    {

    }

    public void ShowStatus()
    {
        buttonPanel.SetActive(false);
        statusPanel.SetActive(true);
    }
}
