using UnityEngine;


public enum  TankState
{
    Idle,
    Move,
    Attack,
    Dead
}

[System.Flags]
public enum PokemonAttribute
{
    None = 0,
    Flying = 1 << 0 , // 0001 << 0 
    Water = 1 << 1, // 1 << 1  0010
    Grass = 1<<2, // 1 << 2 0100
    Fire = 1 << 3, // 1000
    // 1001
}
//  |

//  0001
//  0010
//  0011

// 1001
// 0001
// 0001
//리자몽 => 불꽃 + 비행
//비트마스크 

public class EnumTest : MonoBehaviour
{
    public TankState tankState;
    public PokemonAttribute pokemonAttribute;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(pokemonAttribute);

        if((pokemonAttribute & PokemonAttribute.Flying) == PokemonAttribute.Flying)
        {
            Debug.Log("비행속성");
        }
        else
        {
            Debug.Log("비행속성 아님");
        }
    }


    private void Update()
    {
        switch(tankState) //FSM State 
        {
            case TankState.Idle:
                Debug.Log("대기");
                break;
            case TankState.Move:
                Debug.Log("이동");
                break;
            case TankState.Attack:
                Debug.Log("공격");
                break;
            case TankState.Dead:
                Debug.Log("사망");
                break;
        }
    }

}
