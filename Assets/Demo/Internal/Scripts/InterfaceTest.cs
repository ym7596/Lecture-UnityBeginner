using UnityEngine;

public abstract class InterfaceTest 
{
   
}

public abstract class Pokemon
{
    public void Attack()
    {
        Debug.Log("공격");
    }

    public abstract void Roar2();
}

public class Pichachu : Pokemon
{
    public override void Roar2()
    {
        Debug.Log("피카피카");
    }
}

public interface IPokemon
{
    void Roar();
}

public class Raichu :  Pokemon,IPokemon
{
    public override void Roar2()
    {
        Debug.Log("라이츄");
    }
    public void Roar()
    {
        throw new System.NotImplementedException();
    }
}

//추상 -> 공통 로직 + 강제구현  인터페이스 -> 강제구현.
//구현 가능 여부 / 일부 메서드  / 구현 불가 default
//다중 상속 

// animal - dog 추상 클래스 
// 로봇 -> shoot  인터페이스
