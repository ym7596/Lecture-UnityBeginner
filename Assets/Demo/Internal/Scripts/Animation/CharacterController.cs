using UnityEngine;

public enum ChracterState
{
    Idle,
    Run,
    Jump,
}

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private ChracterState state;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = ChracterState.Run;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           state = ChracterState.Jump;
        }

        switch (state)
        {
            case ChracterState.Run:
                //_animator.SetBool("IsRun", false);
                break;
            case ChracterState.Jump:
                _animator.SetTrigger("JumpTrigger");
                state = ChracterState.Run;
                break;
            default:
                break;
        }
    }
}
