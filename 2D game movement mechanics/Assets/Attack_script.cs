using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_script : MonoBehaviour
{
    
    public GameObject player;
    public float speed =8f;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = player.transform.position;
    }

     void Update()
     {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        
        if(Vector3.Distance(transform.position, target) < 0.1f )
        {
           Destroy(gameObject);
        }
     }
}

