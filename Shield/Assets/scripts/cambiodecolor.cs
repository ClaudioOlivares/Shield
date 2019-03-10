using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiodecolor : MonoBehaviour {
    //  private MeshRenderer mr;
    public Material [] colores;
    public int contadormateriales;
    private MeshRenderer mr;
    
	// Use this for initialization
	void Start () {
        contadormateriales = 0;
        cambiartag();
        mr = GetComponent<MeshRenderer>();
        mr.material = colores[contadormateriales];
	}
	
	// Update is called once per frame
	void Update ()
    {
        cambiartag();
		if(Input.GetKeyDown(KeyCode.F))
        {
            if (contadormateriales == 2)
            {
                contadormateriales = 0;
            }
            else
            {
                contadormateriales++;
            }

            mr.material = colores[contadormateriales];

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
