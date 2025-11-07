using UnityEngine;

public class TennisBot : MonoBehaviour
{
    public Transform[] pontos;
    public float velocidade = 2f;
    private int pontoAtual = 0;

    private void Update()
    {
        if (pontos.Length == 0) return;
        transform.position = Vector3.MoveTowards(transform.position,pontos[pontoAtual].position,velocidade * Time.deltaTime);

        if (Vector3.Distance(transform.position, pontos[pontoAtual].position) < 0.1f)
        {
            pontoAtual = (pontoAtual + 1) % pontos.Length;
            //% dividindo
        }
    }
}

