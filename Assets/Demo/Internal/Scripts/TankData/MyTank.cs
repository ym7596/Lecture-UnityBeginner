using UnityEngine;

public class MyTank : MonoBehaviour
{
    private string tankName;
    private int hp;
    private float moveSpeed;
    private int attackPower;
    public TankUpgradeState upgradeState;


    public void SetData(TankModel model)
    {
        tankName = model.name;
        hp = model.hp;
        moveSpeed = model.moveSpeed;
        attackPower = model.attackPower;
        upgradeState = model.upgradeState;
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * moveSpeed);
    }
}
