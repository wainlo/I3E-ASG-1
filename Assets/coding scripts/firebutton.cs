using UnityEngine;

public class firebutton : MonoBehaviour
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
       
        transform.position = new Vector3(-73.984f, 4.42f, -74.2f);// Adjust the position as needed
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))// Check if the collider belongs to the player
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