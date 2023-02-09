using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerRb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerRb.position.x, transform.position.y, -10);
    }
}
