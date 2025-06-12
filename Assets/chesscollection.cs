using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ChessCollection : MonoBehaviour
{
    private int chess = 0;
    private int health = 100; // Initial health value
    public TextMeshProUGUI chessCountText;  // Reference to the TMP Text element
    public TextMeshProUGUI healthText; // Reference to the TMP Text element for health
     public Transform spawnPoint;

    void Start()
    {
        UpdateChessCount();
        UpdateHealthUI();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("chess"))
        {
            chess++;
            Destroy(other.gameObject);
            UpdateChessCount();
            Debug.Log("Chess Pieces Collected : " + chess.ToString());
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
    }

    void UpdateChessCount()
    {
        chessCountText.text = "Chess Pieces: " + chess.ToString();
    }
    void UpdateHealthUI()
    {
        healthText.text = "Health: " + health.ToString();
    }
    void Respawn()
{
    transform.position = spawnPoint.position;
    health = 100;
    UpdateHealthUI();
}


}
