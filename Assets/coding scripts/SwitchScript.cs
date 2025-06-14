using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public DoorController door;
    private bool isPlayerNear = false;
    private bool hasBeenFlipped = false;

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E) && !hasBeenFlipped)
        {
            door.OpenDoor();
            pressbutton();
            hasBeenFlipped = true; // Prevent multiple flips
        }
    }

    void pressbutton()
    {
        // Flip the switch 180 degrees on the Y axis
        transform.position = new Vector3(5.3f, 4.29f, -9.86f);
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