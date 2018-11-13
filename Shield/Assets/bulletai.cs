using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletai : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb;
    public Material[] materiales;
    public int aux;
    private MeshRenderer mr;
    public GameObject particledeath;
    public GameObject particledeath0,particledeath1,particledeath2;
    private CameraShake camshake;
    
	// Use this for initialization
	void Start () {
        Destroy(gameObject, 5f);
        camshake = FindObjectOfType<CameraShake>();
        mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody2D>();
        aux = Random.Range(0, 3);
        if(aux == 0)
        {
            mr.material = materiales[aux];
           

        }
        if (aux == 1)
        {
            mr.material = materiales[aux];

        }
        if (aux == 2)
        {
            mr.material = materiales[aux];

        }
        cambiartag();
      
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = transform.right * speed;
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == gameObject.tag)
        {
            gameObject.layer = 11;
            camshake.shakecamera(0.09f,0.28f);
            Instantiate(particledeath,gameObject.transform.position, Quaternion.identity);
            speed = -speed;
        }
        else
        {

            Destroy(gameObject, 0f);
        }
    }
    public void cambiartag()
    {
        if (aux == 0)
        {
            gameObject.tag = "rojo";
            particledeath = particledeath0;
        }
        if (aux == 1)
        {
            gameObject.tag = "azul";
            particledeath = particledeath1;

        }
        if (aux == 2)
        {
            gameObject.tag = "verde";
            particledeath = particledeath2;

        }
    }

  
}
