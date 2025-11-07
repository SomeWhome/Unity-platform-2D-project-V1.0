using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class boss_fight : MonoBehaviour
{
    public Object Attack;
    public GameObject playerTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackPlayer()
    {
        Object fireball = Instantiate(Attack, gameObject.transform.position, gameObject.transform.rotation);
        fireball.GetComponent<Attack_script>().player = playerTarget;
    }
}
