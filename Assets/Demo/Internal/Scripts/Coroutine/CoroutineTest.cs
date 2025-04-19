using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    //유니티느ㄴ 메인스레드만 사용을 하는데.
    private bool myBool = false;
    Coroutine myCoroutine = null;
    //코루틴
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Attack();
        // myCoroutine = StartCoroutine(AttackCo());
        ParrallelTest();
    }

    public void Attack()
    {
        //f(x) = y
        //2

        //3
        //4
        //5
    }

    public IEnumerator LongtimeCo()
    {
        yield return new WaitForSeconds(5f);
        Debug.Log("bool is true");
        myBool = true;
    }

    public IEnumerator AttackCo()
    {
        //1
        Debug.Log("start");
        yield return StartCoroutine(LongtimeCo());
        yield return new WaitUntil(() => myBool==true);
        Debug.Log("finish");
        
        //2
    }

    //Parrallel 메서드 / Job System  DOTS
    //유니티는 메인스레드만 모든 UI 유니티 API 메인스레드 작동.


    public void ParrallelTest()
    {
        string[] myStrings = new string[] {"a","b","c","d","e" };

        for (int i = 0; i < myStrings.Length; i++)
        {
            Debug.Log(myStrings[i]);
            Instantiate(new GameObject($"Object_{i}"), Vector3.zero, Quaternion.identity);
        }

        //Parallel.For(0, myStrings.Length, (i) =>
        //{
        //    Debug.Log(myStrings[i]);
        //    Instantiate(new GameObject(), Vector3.zero, Quaternion.identity);
        //});
    }
}
