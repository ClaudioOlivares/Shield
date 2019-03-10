using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {
    public movimiento player;
    public float speed;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<movimiento>();
	}
	
	// Update is called once per frame
	void Update () {
      transform.position =  Vector3.MoveTowards(transform.position,new Vector3 (player.transform.position.x,transform.position.y,transform.position.z), speed);
	}
}
