using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyai : MonoBehaviour {
    public GameObject shotplace;
    public float cooldown;
    private float cooldownaux;
    private float contadorcooldown;
    public float speed;
    private movimiento player;
    private Vector3 direction;
    private float angulo;
    public GameObject bullet;
    private Quaternion rotacion;
    public bool oncooldown;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<movimiento>();
        oncooldown = true;
        cooldownaux = cooldown;
        cooldown = Random.Range(cooldownaux-0.25f,cooldownaux+0.25f);
	}
	
	// Update is called once per frame
	void Update ()
    {
         direction = player.transform.position - transform.position;
         angulo = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
         rotacion = Quaternion.AngleAxis(angulo,Vector3.forward);
         transform.rotation = Quaternion.Slerp(transform.rotation, rotacion, speed * Time.deltaTime);
       
         
       // transform.LookAt(player.transform);
        if(oncooldown)
        {
            contadorcooldown += Time.deltaTime;
            if(contadorcooldown > cooldown)
            {
                oncooldown = false;
                contadorcooldown = 0;
            }
        }
        else
        {
            shot();

        }
	}
    private void FixedUpdate()
    {
        
    }
    public void shot()
    {
        Instantiate(bullet, shotplace.transform.position,transform.rotation);
        oncooldown = true;
    }
}
