using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundscroll : MonoBehaviour {
    private Transform cam;
    public Transform[] layers;
    public float viewzone = 10f;
    private int leftindex;
    private int rightindex;
    public float backgroundsize;
    public float parallaxspeed;
    public bool isparallax, isscrolling;
    private float lastcamerax;
    private movimiento player;
    public float auxy;
	// Use this for initialization
	void Start () {
        auxy = transform.position.y;
        cam = Camera.main.transform;
        player = FindObjectOfType<movimiento>();
        lastcamerax = cam.position.x;
        leftindex = 0;
        rightindex = layers.Length - 1;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (isparallax)
        {
            if (!player.dadovuelta)
            {
                float deltax = cam.position.x + lastcamerax;
                transform.position =  Vector3.left * (deltax * parallaxspeed);
                lastcamerax = cam.position.x;
            }
            else
            {
                float deltax = cam.position.x + lastcamerax;
                transform.position = Vector3.left * (deltax * parallaxspeed);
                lastcamerax = cam.position.x;
            }
        }

        if (cam.transform.position.x < (layers[leftindex].transform.position.x + viewzone))
        {
            scrollleft();
        }
        if (cam.transform.position.x > (layers[rightindex].transform.position.x - viewzone))
        {
            scrollright();
        }
    }
    private void scrollleft()
    {
        int lastright = rightindex;
        layers[rightindex].position = new Vector2 (1*layers[leftindex].position.x - backgroundsize,auxy);

        leftindex = rightindex;
        rightindex--;
        if (rightindex < 0)
            rightindex = layers.Length - 1;

    }
    private void scrollright()
    {
        int lastleft = leftindex;
        layers[leftindex].position = new Vector2  (1 * layers[rightindex].position.x + backgroundsize,auxy);
        rightindex =  leftindex ;
        leftindex++;
        if (leftindex == layers.Length)
            leftindex = 0;
    }
}
