using UnityEngine;

public class respan : MonoBehaviour
{
    public Transform startPoint; // Assign this in the Inspector

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fire"))
        {
            transform.position = startPoint.position;
        }
    }
}

