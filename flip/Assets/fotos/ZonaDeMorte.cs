using UnityEngine;

public class ZonaDeMorte : MonoBehaviour
{
    public GerenciadorBola gerenciador;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bola"))
        {
            Destroy(other.gameObject);              
            gerenciador.SpawnarBola();              
        }
    }
}
