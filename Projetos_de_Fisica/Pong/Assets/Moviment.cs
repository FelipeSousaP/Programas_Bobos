using UnityEngine;
using UnityEngine.InputSystem;

public class Moviment : MonoBehaviour
{
    [SerializeField] Rigidbody body;
    [SerializeField] float Speed;

    [SerializeField] bool IsMoving;

    Vector2 Direction;
    void Update()
    {
        if (IsMoving)
        {
            body.linearVelocity = new Vector2(Direction.x, 0) * Speed;
        }
        else
        {
            body.linearVelocity = Vector2.zero;
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
            Direction = callbackContext.ReadValue<Vector2>();
        }
        else if (callbackContext.phase == InputActionPhase.Canceled) 
        { IsMoving = false; }
    }
}
