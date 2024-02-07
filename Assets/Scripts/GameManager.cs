using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Status
{
    public int atk;
    public int def;
    public int hp;
    public int mp;

    public Status(int atk, int def, int hp, int mp)
    {
        this.atk = atk;
        this.def = def;
        this.hp = hp;
        this.mp = mp;
    }

    public void HpUp(int amount)
    {
        hp += amount;
    }

    public void MpUp(int amount)
    {
        mp += amount;
    }
}

[System.Serializable]
public class UserData
{
    public string Name;
    public int Level;
    public int Gold;
    public int NowExp;
    public int FullExp;

    public Status Stat;
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public UserData user;
    public PlayerInfo pInfo;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void Pay(int amount)
    {
        user.Gold -= amount;
        pInfo.ShowInfo();
    }
}
