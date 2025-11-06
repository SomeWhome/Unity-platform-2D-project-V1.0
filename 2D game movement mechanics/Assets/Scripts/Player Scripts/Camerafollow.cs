using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    [SerializeField] GameObject player;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 3, gameObject.transform.position.z);

    }
}
