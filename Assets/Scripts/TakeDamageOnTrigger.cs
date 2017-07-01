using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnTrigger : MonoBehaviour
{

        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var go = collision.gameObject;
        if (go.GetComponent<TurnToGoldOnClick>().isGold)
            this.GetComponent<Health>().TakeDamage(1);
            
    }

}
