using UnityEngine;

public class CallManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        staticTest.Instance.myInt = 1;
        staticTest.Instance.myString = "Hello World222";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
