using UnityEngine;

public class Little_Ball : MonoBehaviour
{
    [Header("Ball Settings")]
    [SerializeField] Rigidbody rb;
    [SerializeField] Vector3 VelocidadeInicial;

    [Header("physics Setting")]
    [SerializeField] float Gravidade;
    public float time;

    void Update()
    {
        time = Time.time;
        transform.position += new Vector3(VelocidadeInicial.x,VelocidadeInicial.y,VelocidadeInicial.z) * Gravidade * time;
    }
}
