using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="TankSO", menuName = "SO/TANKSO")]
public class TankSO : ScriptableObject
{
    public List<TankModel> tankModels;
}
