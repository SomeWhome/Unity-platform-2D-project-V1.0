using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemie : MonoBehaviour
{
    [SerializeField] private GameObject papa;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(papa);
            
            
        }
        
    }
}


