using UnityEngine;

public class BearHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            Destroy(gameObject); // Destroy the bear
        }
    }
}
