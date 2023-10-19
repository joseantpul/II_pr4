using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_esfera2e : MonoBehaviour
{
    Transform cilindro_t;
    GameObject[] esferas_2;
    ej3_cuboe notificador;
    void Start()
    {
        cilindro_t = GameObject.Find("Cylinder_2").transform;
        esferas_2 = GameObject.FindGameObjectsWithTag("esfera_2");
        notificador = GameObject.Find("Cube").GetComponent<ej3_cuboe>();
        notificador.OnAproximacionCilindro += mirarCilindro;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void mirarCilindro() {
        foreach (GameObject esfera in esferas_2)
        {
            esfera.transform.LookAt(cilindro_t.position);
        }
    }
}
