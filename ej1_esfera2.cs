using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_esfera2 : MonoBehaviour
{
    ej1_e notificador;
    GameObject[] esferas_2;
    float speed = 2.0f;
    Transform cilindro_t;
    // Start is called before the first frame update
    void Start()
    {
        cilindro_t = GameObject.Find("cilindro1").transform;
        notificador = GameObject.Find("Cube").GetComponent<ej1_e>();
        esferas_2 = GameObject.FindGameObjectsWithTag("esfera_2");
        notificador.OnColisionCilindro += Mover;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void Mover()
    {
        foreach (GameObject esfera in esferas_2)
        {
            Vector3 direccion = cilindro_t.position - esfera.transform.position;
            direccion.Normalize();
            Vector3 desplazamiento = direccion * speed * Time.deltaTime;
            esfera.transform.Translate(desplazamiento);
        } 

    }
}
