using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiodePosicion : MonoBehaviour
{
    public GameObject[] posiciones;
    public int posicion = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (posicion < 2)
            {
                posicion++;
            }

        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (posicion > 0)
            {
                posicion--;
            }
        }
        cambiarPosicion();
    }

    void cambiarPosicion()
    {
        if(posicion == 0)
        {
            transform.position = posiciones[posicion].transform.position;
            transform.rotation = posiciones[posicion].transform.rotation;
        }
        if (posicion == 1)
        {
            transform.position = posiciones[posicion].transform.position;
            transform.rotation = posiciones[posicion].transform.rotation;
        }
        if (posicion == 2)
        {
            transform.position = posiciones[posicion].transform.position;
            transform.rotation = posiciones[posicion].transform.rotation;
        }
    }
}
