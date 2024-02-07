using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI atkTxt;
    [SerializeField] private TextMeshProUGUI defTxt;
    [SerializeField] private TextMeshProUGUI hpTxt;
    [SerializeField] private TextMeshProUGUI mpTxt;

    void Start()
    {
        ShowStatus();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowStatus()
    {
        Status stat = GameManager.instance.user.Stat;

        atkTxt.text = stat.atk.ToString();
        defTxt.text = stat.def.ToString();
        hpTxt.text = stat.hp.ToString();
        mpTxt.text = stat.mp.ToString();
    }
}
