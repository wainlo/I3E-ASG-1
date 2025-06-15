using UnityEngine;

public class firebutton : MonoBehaviour
{
    public DoorController door;
    private bool isPlayerNear = false;
    private bool hasBeenPressed = false;

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E) && !hasBeenPressed)
        {
            door.OpenDoor();
            pressbutton();
            hasBeenPressed = true; // Prevent multiple presses
        }
    }

    void pressbutton()
    {
        
        transform.position = new Vector3(-73.984f, 4.42f, -74.2f);
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