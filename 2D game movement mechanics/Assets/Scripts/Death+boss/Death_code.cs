using Unity.VisualScripting;
using UnityEngine;


public class Death_code: MonoBehaviour
{
    public bool destroyed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector2 Teleported_position;
    public float lives = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            gameObject.transform.position = Teleported_position;
            lives = 3;
        }

        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            Teleported_position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            

          
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && destroyed == false)
        {
            lives -= 1;
            Debug.Log(lives);
        }
    }

    private void Update()
    {
        if (lives <= 0)
        {
            gameObject.transform.position = Teleported_position;
            Debug.Log(lives);
            lives = 3;

        }
        
    }
}
