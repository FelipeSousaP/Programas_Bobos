using UnityEngine;
using UnityEngine.InputSystem;

public class Moviment : MonoBehaviour
{
    [SerializeField] Rigidbody body;
    [SerializeField] float SpeedX;

    [SerializeField] bool IsMoving;
    void Update()
    {
        if (IsMoving)
        {

        }
    }

    public void Move(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.phase == InputActionPhase.Started)
        {
            IsMoving = true;
        }
        else if (callbackContext.phase == InputActionPhase.Canceled) { IsMoving = false; }
    }
}
