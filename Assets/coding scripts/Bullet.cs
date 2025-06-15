using UnityEngine;

public class Bullet : MonoBehaviour
{

    

    void Start()
    {
        Destroy(gameObject, 4f); // Destroy the bullet after 4 seconds
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Untagged"))
        {
            Destroy(gameObject);
        }

    }


}
