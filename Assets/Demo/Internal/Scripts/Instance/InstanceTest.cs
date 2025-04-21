using UnityEngine;

public class InstanceTest : MonoBehaviour
{
    public GameObject myGameObject;

    public Transform spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject unitychan = Instantiate(myGameObject, Vector3.zero, Quaternion.identity);
        unitychan.transform.position = spawnPoint.position;
        unitychan.transform.rotation = spawnPoint.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
