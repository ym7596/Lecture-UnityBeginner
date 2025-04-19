using UnityEngine;

public class staticTest : MonoBehaviour
{
    public static staticTest Instance;

    public int myInt = 0;

    public string myString = "Hello World";

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}
