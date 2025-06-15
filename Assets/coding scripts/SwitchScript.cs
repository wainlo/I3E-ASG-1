using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public DoorController door;
    private bool isPlayerNear = false;
    private bool hasBeenPressed = false;

    public AudioSource audioSource;

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E) && !hasBeenPressed)
        {
            door.OpenDoor();
            pressbutton();
            hasBeenPressed = true; // Prevent multiple presses
            audioSource.Play();
        }
    }

    void pressbutton()
    {
        
        transform.position = new Vector3(24.415f, 32.63f, -6.09f);// Adjust the position as needed
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