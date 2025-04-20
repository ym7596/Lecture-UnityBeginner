using System;
using System.Collections;
using UnityEngine;

public class ActionTest : MonoBehaviour
{
    public Action firstAction;
    public Action<int> firstActionint;
   // public event Action secondAction;

    private void Start()
    {
        //
        StartCoroutine(TestCo((myint) =>
            {
                Debug.Log(myint);
            }
        ));
    }


    public int TestFun(int a)
    {

        return a;
    }

    public IEnumerator TestCo(Action<int> myaction)
    {
        Debug.Log("co Start");
        yield return new WaitForSeconds(3f);

        myaction?.Invoke(2);

    }


}
