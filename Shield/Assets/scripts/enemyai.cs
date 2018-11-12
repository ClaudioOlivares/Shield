using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyai : MonoBehaviour {
    public GameObject shotplace;
    public float cooldown;
    private float contadorcooldown;
    private movimiento player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<movimiento>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(shotplace.transform.position, player.transform.position);
    }
}
