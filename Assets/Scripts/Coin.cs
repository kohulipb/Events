using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] EventManagerSO eventManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(eventManager != null)
            {
                eventManager.CoinCollected();
            }
            
            Destroy(this.gameObject);
        }
    }
}
