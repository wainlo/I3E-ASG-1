using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
  
    [SerializeField] GameObject projectile; // Reference to the projectile object
    [SerializeField] Transform spawnPoint; // Reference to the spawn point for the projectile
    [SerializeField] float fireStrength = 60f; // Projectile fire strength
    [SerializeField] float interactionDistance = 5f;

    void Update()
    {
        
       
    }
   
    void OnFire()
    {
        GameObject newProjectile = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
        Vector3 fireForce = spawnPoint.forward * fireStrength;
        newProjectile.GetComponent<Rigidbody>().AddForce(fireForce);
    }
}