using UnityEngine;

public class Lancador : MonoBehaviour
{
    public Rigidbody2D lancadorRb;
    public float forcaDeLancamento = 8f;
    private bool carregando = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            carregando = true;
        }

        if (Input.GetKeyUp(KeyCode.Space) && carregando)
        {
            lancadorRb.AddForce(Vector2.up * forcaDeLancamento, ForceMode2D.Impulse);
            carregando = false;
        }
    }
}
