using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiodecolor : MonoBehaviour {
    private MeshRenderer mr;
    public Material [] materiales;
    public int contadormateriales;
    
	// Use this for initialization
	void Start () {
        contadormateriales = 1;
        mr = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        cambiartag();
		if(Input.GetKeyDown(KeyCode.F))
        {
            mr.material = materiales[contadormateriales];
            if (contadormateriales == 2)
                contadormateriales = 0;
            else
            {
                contadormateriales++;
            }

            
        }
	}
    public void cambiartag()
    {
        if(contadormateriales == 0)
        {
            gameObject.tag = "rojo";
        }
        if (contadormateriales == 1)
        {
            gameObject.tag = "azul";
        }
        if (contadormateriales == 2)
        {
            gameObject.tag = "verde";
        }
    }
}
