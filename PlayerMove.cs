using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jump;

    private float Move;
    private float Gravity = 9.81f;
    private bool Grounded = false;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && Grounded)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump * Gravity));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Grounded = (other.gameObject.CompareTag("Ground"));
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Grounded = (!other.gameObject.CompareTag("Ground"));
    }
}
