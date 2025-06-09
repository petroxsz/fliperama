using UnityEngine;

public class BallReset : MonoBehaviour
{
    public Transform spawnPoint;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y < -10f)
        {
            transform.position = spawnPoint.position;
            rb.linearVelocity = Vector2.zero;
        }
    }
}
