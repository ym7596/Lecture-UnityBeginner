using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Image image;
    private Image image2;
    protected Image image3;

    //변수 => 데이터를 저장하는 공간,
    // 숫자, 문자, 오브젝트 다양한 형태가능

    int number = 0; //정수 -1,0,1,2,3,4,5,6
    float nums = 0.1f; //소수점이 들어가는 숫자 float
    //double
    double num2 = 0;
    string chareset = "abcd"; //문자열
    bool isOn = false; // false, true
    GameObject gObject;

    //f(x) = y
    private void Start()
    {
        Attack(0,"abcd");
    }

    int AttackPower(int power)
    {
        int a = 1;
        return a;
    }

    string AttackString()
    {
        return "attackString";
    }

    void Attack(int damage, string damageString)
    {
        //f(x)
        //f(x,y)
        //f(x,y,z)
        //공격모션 플레이
        damage += AttackPower(damage);
        damage = damage + 1;
    }

}
