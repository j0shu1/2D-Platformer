using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject SpawnPoint;

    private GameObject player;
    private Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerRb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerRb.velocity = Vector2.zero;
            player.transform.position = SpawnPoint.transform.position;
        }
    }
}
