using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_cuboe : MonoBehaviour
{
    bool already_close = false;
    public delegate void colisionCilindro();
    public event colisionCilindro OnAproximacionCilindro;
    Transform cilindro_t;
    public float detectionRadius = 1.0f;
    void Start()
    {
        cilindro_t = GameObject.Find("cilindro1").transform;
        float distance = Vector3.Distance(transform.position, cilindro_t.position);
        if (distance < detectionRadius)
        {
           OnAproximacionCilindro();
        }   
    }

    // Update is called once per frame
    void Update()
    {
        cilindro_t = GameObject.Find("cilindro1").transform;
        float distance = Vector3.Distance(transform.position, cilindro_t.position);
        if (distance < detectionRadius && !already_close)
        {
           OnAproximacionCilindro();
           already_close = true;
        } else if (distance > detectionRadius) already_close = false;
    }
}
