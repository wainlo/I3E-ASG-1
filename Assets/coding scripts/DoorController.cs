using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isOpen = false;
    public Vector3 openPositionOffset = new Vector3(0, 3, 0);
    private Vector3 closedPosition;
    private Vector3 openPosition;
    public float openSpeed = 2f;

    void Start()
    {
        closedPosition = transform.position;// Store the initial position of the door as the closed position
        openPosition = closedPosition + openPositionOffset;// Calculate the open position based on the closed position and offset
    }

    void Update()
    {
        if (isOpen)
        {
            transform.position = Vector3.Lerp(transform.position, openPosition, Time.deltaTime * openSpeed);// Smoothly move the door to the open position
        }
    }

    public void OpenDoor()
    {
        isOpen = true;
    }
}