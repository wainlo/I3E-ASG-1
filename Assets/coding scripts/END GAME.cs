using UnityEngine;
using UnityEngine.SceneManagement;
public class ENDGAME : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void EndGame()
    {
        // Load the scene named "EndScene"
        Application.Quit();
    }
}
