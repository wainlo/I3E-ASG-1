using UnityEngine;

public class Bigdoor2 : MonoBehaviour
{
    public DoorController door1; // Reference to first door
    public DoorController door2; // Reference to second door
    private bool isPlayerNear = false;
    private bool hasBeenPressed = false;

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E) && !hasBeenPressed )
            {
                door1.OpenDoor();
                door2.OpenDoor();
                pressbutton();
                hasBeenPressed = true; // Prevent multiple presses
            }
    }

    void pressbutton()
    {
        // Flip the switch 180 degrees on the Y axis
        transform.position = new Vector3(143.04f,4.98f , -69.93f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
        }
    }
}
