using UnityEngine;

public class Loop : MonoBehaviour
{
    //조건문
    //if  else  switch
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //반복문
    // 반복 시켜준다. loop

    public int[] myInts = new int[] { 1,2,3,4,5,6};
    int hp = 60;
    void Start()
    {
        //for while foreach

        for(int i =0; i<5; i++) //조건에 만족하는 반복문
        { //true 
            // 0=> 5보다작다가 true => i++  +1
            // 1 => true => +1
            // 2....
            // i =>5 false 끝
            Debug.Log(i);
            
        }

        while (hp>50)// true 
        {
            Debug.Log(hp);
            hp--;
            if (hp == 55)
            {
                break;
            }
        }

        foreach(int mynum in myInts)
        {
            Debug.Log(mynum);
        }

        //다른 사람이 내 코드를 봤을 때 쉽게 이해할 수 있는가?



        if(hp>51) // >  < ==  >=  <= and or
        {
          //  Debug.Log("0보다 작다");
        }
        else if(hp > 51)
        {
          //  Debug.Log("51보다 크다");
        }
        else
        {
          //  Debug.Log("아무것도 아니다");
        }
       // SwtichTest();
    }

    void SwtichTest()
    {
        switch(hp)
        {
            case 1:
                {
                    Debug.Log("1이다");
                    break; 
                }
            case 2:
                {
                    Debug.Log("2이다");
                    break;
                }
            case 60:
                {
                    Debug.Log("60이다.");
                    break;
                }
        }
    }

   
}
