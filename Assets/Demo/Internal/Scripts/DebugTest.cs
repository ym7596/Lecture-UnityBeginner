using UnityEngine;

public class DebugTest : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
        // 해당 스크립트가 활성화될 때 호출됨
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
        // 해당 스크립트가 활성화될 때마다 호출됨
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
        // 해당 스크립트가 비활성화될 때마다 호출됨
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
        // 해당 스크립트가 파괴될 때 호출됨

    }
    //DebugLog는 어디서 버그가 나고 잘못되었는지를 직관적으로 알 수 있게 해주는 도구
    void Start()
    {
        //해당 오브젝트 생성될 때 한번 호출
        Debug.Log("Debug Log Test"); // 일반적인 로그
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
    
    }

    private void FixedUpdate()
    {

    }
}
