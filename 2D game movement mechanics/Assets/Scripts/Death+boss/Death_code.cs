using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Death_code: MonoBehaviour
{
    public Text TextLives;
    public bool destroyed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector2 Teleported_position;
    public float lives = 3;
    public Vector2 Teleporter;
    public GameObject Questionmanager;
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
        if (collision.gameObject.CompareTag("teleport"))
        {
            gameObject.transform.position = Teleporter;

        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && destroyed == false)
        {
            lives -= 1;
           
        }
    }

    private void Update()
    {
        TextLives.text = "lives : " + lives;
        if (lives <= 0)
        {
            gameObject.transform.position = Teleported_position;
            lives = 3;
            Questionmanager.GetComponent<Questionmanager>().Offplatform();
            Questionmanager.SetActive(true);
        }
        
    }
}
