using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiodecolor : MonoBehaviour {
    //  private MeshRenderer mr;
    //public Material [] colores;
    public int contadormateriales;
    private Renderer mr;
    public Color red, blue, verde;
    
	// Use this for initialization
	void Start () {
        contadormateriales = 0;
        cambiartag();
        mr = GetComponent<Renderer>();
       // mr.material = colores[contadormateriales];
	}
	
	// Update is called once per frame
	void Update ()
    {
        cambiartag();
        cambiarColor();

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

            //mr.material = colores[contadormateriales];
           
        }
        
        //  cambiartag();
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
    public void cambiarColor()
    {
        if (contadormateriales == 0)
        {
            mr.material.color = red;
            
        }
        if (contadormateriales == 1)
        {
            mr.material.color = blue;
            
        }
        if (contadormateriales == 2)
        {
            mr.material.color = verde;
           
        }
    }
}

