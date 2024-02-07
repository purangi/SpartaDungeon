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

    private void ShowInfo()
    {
        nameTxt.text = GameManager.instance.user.Name;
        levelTxt.text = GameManager.instance.user.Level.ToString();
        goldTxt.text = GameManager.instance.user.Gold.ToString();
        SetExpBar();
    }

    void SetExpBar() //Exp»πµÊ Ω√ Ω««‡
    {
        expBar.fillAmount = (float)GameManager.instance.user.NowExp / (float)GameManager.instance.user.FullExp;
    }
}
