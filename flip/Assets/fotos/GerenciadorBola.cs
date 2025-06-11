using UnityEngine;

public class GerenciadorBola : MonoBehaviour
{
    public GameObject bolaPrefab;       
    public Transform spawnPoint;        

    public void SpawnarBola()
    {
        Instantiate(bolaPrefab, spawnPoint.position, Quaternion.identity);
    }
}
