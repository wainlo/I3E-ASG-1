using UnityEngine;

public class resetspawn : MonoBehaviour
{
    public float threshold;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            transform.position = new Vector3(0 , 3, 0);
        }
    }
}
