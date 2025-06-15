using UnityEngine;
using UnityEngine.SceneManagement;
public class STARTGAME : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        // Load the scene named "MainScene"
        SceneManager.LoadScene("SampleScene");
    }
}
