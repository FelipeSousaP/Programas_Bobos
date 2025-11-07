using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Rigidbody))]
public class TennisBallController : MonoBehaviour
{
    [Header("Configuração da Bola")]
    public float bounceForce = 8f;       
    public float forwardSpeed = 7f;      
    public float gravity = -9.81f;       

    [Header("Arena")]
    public float arenaWidth = 14f;       
    public float arenaDepth = 25f;       
    public float outMargin = 2f;         
    
    private Rigidbody rb;
    private int direction = 1;            // 1 = indo pra frente (Z+), -1 = voltando (Z−)

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        rb.interpolation = RigidbodyInterpolation.Interpolate;

        // impulso inicial
        rb.linearVelocity = new Vector3(0, bounceForce, forwardSpeed * direction);
    }

    void FixedUpdate()
    {
        // aplica gravidade manualmente
        rb.linearVelocity += new Vector3(0, gravity * Time.fixedDeltaTime, 0);

        // limite seguro da arena (metade da profundidade/largura + margem)
        float limitZ = (arenaDepth / 2f) + outMargin;
        float limitX = (arenaWidth / 2f) + outMargin;

        // se a bola sair da arena (Z muito além dos limites) → reinicia cena
        if (Mathf.Abs(transform.position.z) > limitZ ||
            Mathf.Abs(transform.position.x) > limitX ||
            transform.position.y < -2f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.name == "Plane")
        {
            float newY = Mathf.Abs(bounceForce);
            rb.linearVelocity = new Vector3(forwardSpeed * direction, newY, rb.linearVelocity.z);
        }

        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Bot"))
        {
            direction *= -1; // inverte direção Z
            float newY = Mathf.Abs(bounceForce);
            rb.linearVelocity = new Vector3(forwardSpeed * direction, newY, rb.linearVelocity.z);
        }
    }
}
