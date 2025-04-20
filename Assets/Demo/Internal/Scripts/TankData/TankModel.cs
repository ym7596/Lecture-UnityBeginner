using System;
using UnityEngine;

public enum TankUpgradeState
{
    None,
    Upgrade1,
    Upgrade2,
    Upgrade3
}

[Serializable]
public class TankModel
{
    //이름, 체력, 이동속도, 공격력, 업그레이드상태
    public string name;
    public int hp;
    public float moveSpeed;
    public int attackPower;
    public TankUpgradeState upgradeState;
    public GameObject tankPrefab;
}
