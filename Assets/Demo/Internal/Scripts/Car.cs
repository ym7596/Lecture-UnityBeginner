using Unity.VisualScripting;
using UnityEngine;

public class Car
{
    public string name; //k5 아반떼 k9 c클래스...
    public float speed; //시속 제로백...

    public void Drive()
    {
        Debug.Log(name + "가" + speed + "km/h로 달린다.");
    }
}

public class CClass : Car
{
    public string color; //색상
    public void ShowColor()
    {
        Debug.Log(name + "의 색상은 " + color + "이다.");
    }

    public void Special()
    {

    }
}


public class Animal
{
    public string name;
    public virtual void Bark() //재정의 하고 싶어.
    {
        Debug.Log("" + name + "가 짖는다.");
    }
}

public class Zebra : Animal
{
    public override void Bark()
    {
        base.Bark();
        Debug.Log("" + name + "가 히힝 짖는다.");
    }
}

public class Dog : Animal
{
   public override void Bark()
    {
        Debug.Log("" + name + "가 멍멍 짖는다.");
    }
}

public class Tiger : Animal
{
   public override void Bark()
    {
        Debug.Log("" + name + "가 어흥 짖는다.");
    }
}
public class Cat : Animal
{
    public override void Bark()
    {
        Debug.Log("" + name + "가 야옹 짖는다.");
    }
}





public class Player
{
    public int hp = 100;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log("플레이어가 " + damage + "의 피해를 입었다. 현재 체력: " + hp);
    }
}
