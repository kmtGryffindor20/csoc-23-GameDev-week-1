using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Destroyer : MonoBehaviour
{
    // this function is used to detect collisions. Use the intellisence to check what you can access using the "other" 


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }



}
