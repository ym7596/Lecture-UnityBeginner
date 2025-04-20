using UnityEngine;

public class EventTest : MonoBehaviour
{
    [SerializeField]
    private ActionTest _actionTest;
    private void Start()
    {
        _actionTest.firstAction = ActionFunc;
        _actionTest.firstAction = null;
        _actionTest.firstAction += ActionFunc;
      //  _actionTest.secondAction += ActionFunc;
      //  _actionTest.secondAction -= ActionFunc;


    }


    public void ActionFunc()
    {
        Debug.Log("ActionFunc");
    }

    public void ActionFunc2(int a)
    {
        Debug.Log($"{a} is ActionFunc");
        //계산 한다거나 수식 ...
    }
}
