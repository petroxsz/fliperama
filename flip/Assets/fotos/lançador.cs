using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Rigidbody2D bola;
    public float forca = 500f;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.attachedRigidbody == bola && Input.GetKeyDown(KeyCode.Space))
        {
            bola.AddForce(Vector2.up * forca);
        }
    }
}