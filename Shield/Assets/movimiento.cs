using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour {
    public float jumpheight, speed;
    private Rigidbody2D rb;
    public bool isgrounded;
    public LayerMask whatisground;
    public GameObject groundchecker;
    public float groundcheckerradius;
    public float fallmultiplayer, lowjumpmultiplayer;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update() {
        isgrounded = Physics2D.OverlapCircle(groundchecker.transform.position, groundcheckerradius, whatisground);
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);

        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);

        }
        if (Input.GetKey(KeyCode.W) && isgrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpheight);

        }

    }
    private void FixedUpdate()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallmultiplayer - 1) * Time.deltaTime;

        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.W) )
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowjumpmultiplayer - 1) * Time.deltaTime;
        }

        if (rb.velocity.y < 0 )
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallmultiplayer - 1) * Time.deltaTime;

        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.W) )
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowjumpmultiplayer - 1) * Time.deltaTime;
        }
    }
}
