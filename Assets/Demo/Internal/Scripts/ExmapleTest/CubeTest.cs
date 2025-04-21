using UnityEngine;

public class CubeTest : MonoBehaviour
{

    //물리 컴포넌트 Rigidbody -> Collider
    // 타격될 바닥도 Collider
    // 해당 오브젝트에 Layer혹은 Tag  
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    //OnCollision OnTrigger  
    // 피격체와 타격체 둘다 Collider가 있을 것
    // 둘중에 하나에는 반드시 Rigidbody 있을 것.


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            Debug.Log("It's Ground!");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            Debug.Log("It's Ground! Out");
        }
    }
}
