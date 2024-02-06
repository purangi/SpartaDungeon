using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public interface IDamagable
{
    void TakePhysicalDamage(int damageAmount);
}

[System.Serializable]
public class Status
{
    [HideInInspector]
    public int curValue;
    public int maxValue;
    public TextMeshProUGUI valueTxt;

    public void Add(int amount)
    {
        curValue = Mathf.Min(curValue + amount, maxValue);
    }

    public void Subtract(int amount)
    {
        curValue = (int) Mathf.Max(curValue - amount, 0);
    }

    public float GetPercentage()
    {
        return curValue / maxValue;
    }
}

public class PlayerStatus : MonoBehaviour
{
    public Status atk;
    public Status def;
    public Status hp;
    public Status mp;
    public Status exp;

    public Image expBar;

    public UnityEvent onTakeDamage;

    void Start()
    {
        atk.curValue = 10;
        def.curValue = 10;
        hp.curValue = hp.maxValue;
        mp.curValue = mp.maxValue;
        exp.curValue = 0;
    }

    void SetExpBar() //Exp»πµÊ Ω√ Ω««‡
    {
        expBar.fillAmount = exp.GetPercentage();
    }

    public void HpUp(int amount)
    {
        hp.Add(amount);
    }

    public void MpUp(int amount)
    {
        mp.Add(amount);
    }

    public bool UseMP(int amount)
    {
        if (mp.curValue - amount < 0) return false;

        mp.Subtract(amount);
        return true;
    }

    public void Die()
    {
        Debug.Log("«√∑π¿ÃæÓ∞° ¡◊æ˙¥Ÿ.");
    }

    public void TakeDamage(int damage)
    {
        hp.Subtract(damage);
        onTakeDamage?.Invoke();
    }

    public void SetStatus()
    {
        atk.valueTxt.text = atk.curValue.ToString();
        def.valueTxt.text = def.curValue.ToString();
        hp.valueTxt.text = hp.maxValue.ToString();
        mp.valueTxt.text = mp.maxValue.ToString();
    }
}
