using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private Image expBar;

    [SerializeField] private TextMeshProUGUI nameTxt;
    [SerializeField] private TextMeshProUGUI descriptionTxt;
    [SerializeField] private TextMeshProUGUI levelTxt;
    [SerializeField] private TextMeshProUGUI goldTxt;

    private void Awake()
    {

    }

    private void Start()
    {
        ShowInfo();
    }

    public void ShowInfo()
    {
        UserData user = GameManager.instance.user;
        nameTxt.text = user.Name;
        levelTxt.text = user.Level.ToString();
        goldTxt.text = user.Gold.ToString();
        expBar.fillAmount = (float)user.NowExp / (float)user.FullExp;
    }
}
