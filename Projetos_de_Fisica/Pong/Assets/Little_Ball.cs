using UnityEngine;

public class Little_Ball : MonoBehaviour
{
    [Header("Ball Settings")]
    [SerializeField] Rigidbody rb;
    void Update()
    {
        // força = Direção, massa * aceleração
        rb.AddForce(Vector3.forward * rb.mass, ForceMode.Acceleration);
    }
}
