using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ChessCollection : MonoBehaviour
{
    private int chess = 0;
    public int health = 100; // Initial health value
    public TextMeshProUGUI chessCountText;  // Reference to the TMP Text element
    public TextMeshProUGUI healthText; // Reference to the TMP Text element for health
    public Transform spawnPoint;

    public AudioClip collectSound; // Add this
    public AudioClip healthSound; // Add this for health collection sound
    private AudioSource audioSource; // And this
    private AudioSource audioSource2; // For the second AudioSource if needed

    void Start()
    {
        UpdateChessCount();
        UpdateHealthUI();
        audioSource = GetComponent<AudioSource>(); // Initialize the AudioSource
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource2 = gameObject.AddComponent<AudioSource>(); // Add a second AudioSource if needed
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("chess"))
        {
            chess++;
            Destroy(other.gameObject);
            UpdateChessCount();
            Debug.Log("Chess Pieces Collected : " + chess.ToString());
            audioSource.PlayOneShot(collectSound); // Play the collect sound
        }
        if (other.CompareTag("fire"))
        {
            health -= 10; // Decrease health by 10 when colliding with fire
            if (health < 0) health = 0; // Ensure health doesn't go below 0
            if (health == 0)
            {
                Respawn(); // Respawn if health reaches 0
            }
            healthText.text = "Health: " + health.ToString(); // Update health UI
        }
        if (other.CompareTag("bear"))
        {
            health -= 20; // Decrease health by 20 when colliding with a bear
            if (health < 0) health = 0; // Ensure health doesn't go below 0
            if (health == 0)
            {
                Respawn(); // Respawn if health reaches 0
            }
            healthText.text = "Health: " + health.ToString(); // Update health UI
        }
        if (other.CompareTag("bullet"))
        {
            health -= 15; // Decrease health by 5 when colliding with a bullet
            if (health < 0) health = 0; // Ensure health doesn't go below 0
            if (health == 0)

            {
                Respawn(); // Respawn if health reaches 0
            }
            healthText.text = "Health: " + health.ToString(); // Update health UI
        }
        if (other.CompareTag("powerup"))
        {
            health += 20; // Increase health by 20 when collecting a power-up
            if (health > 100) health = 100; // Ensure health doesn't exceed 100
            audioSource.PlayOneShot(healthSound); // Play the collect sound
            healthText.text = "Health: " + health.ToString(); // Update health UI
            Destroy(other.gameObject); // Destroy the power-up after collection
        }
        
        if (other.CompareTag("laser"))
        {
            Respawn(); // Respawn if colliding with a laser
        }
    }

    void UpdateChessCount()
    {
        chessCountText.text = "Chess Pieces: " + chess.ToString();// Update the UI text with the current chess count
    }
    void UpdateHealthUI()
    {
        healthText.text = "Health: " + health.ToString();// Update the UI text with the current health
    }
    void Respawn()
    {
        transform.position = spawnPoint.position;// Reset the player's position to the spawn point
        health = 100;
        UpdateHealthUI();
    }
    public int GetChessCount()
    {
        return chess;
    }
}
