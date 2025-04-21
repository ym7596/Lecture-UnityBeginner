using UnityEngine;

public class TankSOController : MonoBehaviour
{
    [SerializeField] private TankSO _tankSO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TankModel model = new TankModel();
        model = _tankSO.tankModels[0];
        Instantiate(model.tankPrefab);
        Debug.Log($"{model.name} + {model.attackPower}");
    }

    
}
