using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    
    public GameObject chess; // Reference to the chess piece prefab
    [SerializeField] GameObject projectile; // Reference to the projectile object
    [SerializeField] Transform spawnPoint; // Reference to the spawn point for the projectile
    [SerializeField] float fireStrength = 60f; // Projectile fire strength
    [SerializeField] float interactionDistance = 5f;
    
    
    chessbehaviour currentChess = null; // Reference to the currently highlighted chess piece
    
    void Update()
    {
        RaycastHit hitInfo;
        Debug.DrawRay(spawnPoint.position, spawnPoint.forward * interactionDistance, Color.red); // Visualize the raycast in the scene view
        if (Physics.Raycast(spawnPoint.position, spawnPoint.forward, out hitInfo, interactionDistance))
            if (hitInfo.collider.CompareTag("chess"))
            {
                if (currentChess != null)
                {
                    currentChess.Unhighlight(); // Remove highlight from the previous chess piece
                }

                currentChess = hitInfo.collider.gameObject.GetComponent<chessbehaviour>(); // Store the chess piece object
                currentChess.Highlight(); // Highlight the chess piece

            }
            else
            {
                if (currentChess != null)
                {
                    currentChess.Unhighlight(); // Remove highlight if no chess piece is hit
                    currentChess = null; // Clear the reference to the highlighted chess piece
                }
            }

    }




    void OnFire()
    {
        GameObject newProjectile = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
        Vector3 fireForce = spawnPoint.forward * fireStrength;
        newProjectile.GetComponent<Rigidbody>().AddForce(fireForce);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet" && gameObject.tag == "bear")
        {
            Debug.Log("bear hit by bullet!");
            Destroy(collision.gameObject); // Destroy the projectile
            Destroy(gameObject); // Destroy the bear

        }
        
        if (collision.gameObject.tag == "bullet" && gameObject.tag == "box")
        {
           
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    }
   

