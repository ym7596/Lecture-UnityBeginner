
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    /*
     * 배열  '고정된' 크기의 데이터 집합
     * 리스트  크기가 자유로움. 늘어났다가 줄어들었다가 
     * 스택 선입후출  상자에 -> 6개 빵을 넣었어요.
     * 1번빵, ....6번빵.... 1번빵x 6번빵 -> 5번빵,,, 1번빵
        큐  선입선출 1번빵...6번빵 -> 1번빵부터 나옴..
        딕셔너리 key-value  아이템 -> 아이템 데이터 ak소총 (m4...) -> 데미지 50, 연사속도 ,..흔들림...
     * 해시셋 중복 없는 집합. 
     */

    private int[] myInts = { 1, 2, 3, 4 };
    //리스트
    public List<int> myIntList;

    public Stack<int> myStack;

    public Queue<int> myQueue;

    public Dictionary<int, string> myDictionary;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       myIntList = new List<int>();
        myStack = new Stack<int>();
        myQueue = new Queue<int>();
        myDictionary = new Dictionary<int, string>();
        myIntList.Add(1);
        myIntList.Add(2);
        myIntList.Remove(1);

        DictionaryControl();
    }

    void DictionaryControl()
    {
        myDictionary.Add(0, "abcd");
        myDictionary.Add(1, "bcdf");
        myDictionary.Add(0, "ffff");
        Debug.Log(myDictionary[0]);
    }

    void QueueControl()
    {
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);
        int result = myQueue.Dequeue();
        Debug.Log(result);
    }

    void StackControl()
    {
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        int myresult =  myStack.Pop();
        Debug.Log(myresult);
    }
}
