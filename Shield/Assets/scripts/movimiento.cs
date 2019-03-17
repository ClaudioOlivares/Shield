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
    public bool isrunning,isjumping;
    public bool mirandoarriba, mirandoabajo,corriendoizquierda,corriendoderecha;
    private Animator animb, anims;
    public bool dadovuelta;
    private bool jumprequest;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        animb = transform.GetChild(0).GetComponent<Animator>();
        anims = transform.GetChild(1).GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            corriendoderecha = true;
            isrunning = true;
           // gameObject.transform.localScale = new Vector3(1, 1, 1);
            dadovuelta = false;
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animb.SetBool("run_body", false);
            anims.SetBool("run_shield",false);
            corriendoderecha = false;
            isrunning = false;
             //rb.velocity = new Vector2(0, rb.velocity.y);
           

        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            corriendoizquierda = true;
            isrunning = true;
           // gameObject.transform.localScale = new Vector3(-1, 1, 1);
            dadovuelta = true;

           // rb.velocity = new Vector2(-speed, rb.velocity.y); 

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animb.SetBool("run_body", false);
            anims.SetBool("run_shield", false);
            corriendoizquierda = false;
            isrunning = false;
         
            rb.velocity = new Vector2(0, rb.velocity.y);
         
            

        }
        if (Input.GetKeyDown(KeyCode.Space) && isgrounded)
        {
            jumprequest = true;
          //  animb.SetBool("jumpbody", true);
          //  anims.SetBool("jumpshield",true);
            isjumping = true;
        }

    }
    private void FixedUpdate()
    {
        isgrounded = Physics2D.OverlapCircle(groundchecker.transform.position, groundcheckerradius, whatisground);
        if(jumprequest)
        {
            jump();
            jumprequest = false;
        }
        if(isgrounded && rb.velocity.y == 0)
        {
          //  animb.SetBool("jumpbody", false);
           // anims.SetBool("jumpshield", false);
        }
        if (isrunning && corriendoderecha)
        {
  
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            animb.SetBool("run_body",true);
            anims.SetBool("run_shield", true);
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if(isrunning && corriendoizquierda)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            animb.SetBool("run_body", true);
            anims.SetBool("run_shield", true);
           rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallmultiplayer - 1) * Time.deltaTime;

        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space) )
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowjumpmultiplayer - 1) * Time.deltaTime;
        }

        if (rb.velocity.y < 0 )
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallmultiplayer - 1) * Time.deltaTime;
           

        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space) )
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowjumpmultiplayer - 1) * Time.deltaTime;
        }
    }
    void jump()
    {
       // rb.velocity = new Vector2(rb.velocity.x, jumpheight);
        rb.AddForce(new Vector2(0,jumpheight));
    }
}
