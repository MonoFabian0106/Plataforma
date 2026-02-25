using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // Start is called before the first frame update
   public int coinValue;

   private void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision.CompareTag("Player"))
    {
        PlayerStats.score += coinValue;
        Debug.Log(PlayerStats.score);
        Destroy(gameObject);
    }
   }

}
