using Unity.VisualScripting;
using UnityEngine;

public class Death_code: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector2 Teleported_position;
    public float lives;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            gameObject.transform.position = Teleported_position;
            lives -= 1;
        }

        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            Teleported_position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
        }
    }
}
