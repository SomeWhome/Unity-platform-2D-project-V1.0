using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update

    public int m_value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //only trigger if the player touches the coin
        if(collision.CompareTag("Player"))
        {
            //find the score manager and add point
            Score_Manager score_Manager = FindObjectOfType<Score_Manager>();
            
            if (score_Manager != null)
            {
                score_Manager.AddScore(m_value);
                Debug.Log("Collected coins");
            }

            //destroy coin after collition
            Destroy(gameObject);
            Debug.Log("Coin Destroyed");


        }
    }
}
