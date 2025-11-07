using UnityEngine;
using UnityEngine.InputSystem;

public class Moviment : MonoBehaviour
{
    [SerializeField] Rigidbody body;
    [SerializeField] float Speed;

    [SerializeField] bool IsMoving;

    Vector3 Direction;
    void Update()
    {
        if (IsMoving)
        {
            body.linearVelocity = new Vector3(Direction.x, 0,Direction.z) * Speed;
        }
        else
        {
            body.linearVelocity = Vector3.zero;
        }
    }

    public void Move(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.phase == InputActionPhase.Started)
        {
            IsMoving = true;
        }
        else if(callbackContext.phase == InputActionPhase.Performed)
        {
            Direction = callbackContext.ReadValue<Vector3>();
        }
        else if (callbackContext.phase == InputActionPhase.Canceled) 
        { IsMoving = false; }
    }
}
