using UnityEngine;
using TMPro;

public class ChessCollection : MonoBehaviour
{
    private int chess = 0;
    public TextMeshProUGUI chessCountText;  // Reference to the TMP Text element

    void Start()
    {
        UpdateChessCount();
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
    }

    void UpdateChessCount()
    {
        chessCountText.text = "Chess Pieces: " + chess.ToString();
    }
}
