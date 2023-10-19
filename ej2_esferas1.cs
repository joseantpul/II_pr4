using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2_esferas1 : MonoBehaviour
{
    ej2_ecubo notificador;
    GameObject[] esferas_1;
    float speed = 2.0f;
    Transform cilindro_t;
    void Start()
    {
        cilindro_t = GameObject.Find("cilindro1").transform;
        notificador = GameObject.Find("Cube").GetComponent<ej2_ecubo>();
        esferas_1 = GameObject.FindGameObjectsWithTag("esfera_1");
        notificador.OnColisionCilindroMoverEsfera1 += Mover;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Mover()
    {
        foreach (GameObject esfera in esferas_1)
        {
            Vector3 direccion = cilindro_t.position - esfera.transform.position;
            direccion.Normalize();
            Vector3 desplazamiento = direccion * speed * Time.deltaTime;
            esfera.transform.Translate(desplazamiento);
        } 
    }
}
