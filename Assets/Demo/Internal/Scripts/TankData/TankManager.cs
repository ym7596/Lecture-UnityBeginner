using System.Collections.Generic;
using UnityEngine;

public class TankManager : MonoBehaviour
{
    public List<TankModel> tankModels;

    [SerializeField]
    private GameObject tankCube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tankCube.AddComponent<MyTank>();

        MyTank myTank = tankCube.GetComponent<MyTank>();
        myTank.SetData(tankModels[0]);
    }

   
   
}
