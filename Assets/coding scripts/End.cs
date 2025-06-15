using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSceneTrigger : MonoBehaviour
{
    public string nextSceneName; // The name of the scene to load

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered door trigger. Loading scene: " + nextSceneName);
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
