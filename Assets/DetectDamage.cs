
using UnityEngine;

public class detectDamage : MonoBehaviour
{
   [SerializeField] Transform SpawnPoint; // Reference to the spawn point
   [SerializeField] GameObject player; // Reference to the player object

   void OnTriggerEnter(Collider col)
   {
       Debug.Log("Triggered by: " + col.name);
       if (col.CompareTag("Player"))
       {
           col.transform.position = SpawnPoint.position;
       }
   }


    // Update is called once per frame
    void Update()
    {

       
    }
   

        

    }


