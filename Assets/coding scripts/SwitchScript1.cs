using UnityEngine;

public class SwitchScript2 : MonoBehaviour
{
    public DoorController door1; // Reference to first door
    public DoorController door2; // Reference to second door
    private bool isPlayerNear = false;
    private bool hasBeenFlipped = false;

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E) && !hasBeenFlipped)
        {
            door1.OpenDoor();
            door2.OpenDoor();
            FlipSwitch();
            hasBeenFlipped = true; // Prevent multiple flips
        }
    }

    void FlipSwitch()
    {
        // Flip the switch 180 degrees on the Y axis
        transform.position = new Vector3(74.038f, 5.372f, -76.33f);
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
