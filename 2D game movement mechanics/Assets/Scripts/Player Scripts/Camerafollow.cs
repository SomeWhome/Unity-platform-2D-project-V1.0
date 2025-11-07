using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    [SerializeField] GameObject player;
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 2, gameObject.transform.position.z);

    }

    public void ZoomOut()
    {
        cam.orthographicSize = 10f;
    }

    public void ZoomIn()
    {
        cam.orthographicSize = 6f;
    }
}
