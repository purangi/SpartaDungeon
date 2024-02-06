using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string name;
    public string description;
    public int level;
    public int gold;
    private PlayerStatus status;

    [SerializeField] private TextMeshProUGUI nameTxt;
    [SerializeField] private TextMeshProUGUI descriptionTxt;
    [SerializeField] private TextMeshProUGUI levelTxt;
    [SerializeField] private TextMeshProUGUI goldTxt;

    [SerializeField] private GameObject buttonPanel;
    [SerializeField] private GameObject statusPanel;
    [SerializeField] private GameObject invenPanel;
    [SerializeField] private GameObject shopPanel;

    private void Awake()
    {
        status = GetComponent<PlayerStatus>();
    }

    private void Start()
    {
        ShowInfo();
    }

    private void ShowInfo()
    {
        nameTxt.text = name;
        descriptionTxt.text = description;
        levelTxt.text = level.ToString();
        goldTxt.text = gold.ToString();
    }

    public void ShowStatus()
    {
        buttonPanel.SetActive(false);
        statusPanel.SetActive(true);
        status.SetStatus();
    }
}
