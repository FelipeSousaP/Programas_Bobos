using UnityEngine;

public class Little_Ball : MonoBehaviour
{
    [Header("Ball Settings")]
    [SerializeField] Rigidbody rb;
    void Update()
    {
        // for�a = Dire��o, massa * acelera��o
        rb.AddForce(Vector3.forward * rb.mass, ForceMode.Acceleration);
    }
}
