using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_esfera1e : MonoBehaviour
{
    public float fuerza_salto = 5.0f;
    ej3_cuboe notificador;
    GameObject[] esferas_1;
    void Start()
    {
        notificador = GameObject.Find("Cube").GetComponent<ej3_cuboe>();
        esferas_1 = GameObject.FindGameObjectsWithTag("esfera_1");
        notificador.OnAproximacionCilindro += cambiarColorySaltar;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void cambiarColorySaltar() {
        foreach (GameObject esfera in esferas_1)
        {
            float randomRed = Random.Range(0f, 1f);
            float randomGreen = Random.Range(0f, 1f);
            float randomBlue = Random.Range(0f, 1f);
            Color randomColor = new Color(randomRed, randomGreen, randomBlue);
            Renderer renderer = esfera.GetComponent<Renderer>();
            renderer.material.color = randomColor;
            esfera.GetComponent<Rigidbody>().AddForce(Vector3.up * fuerza_salto, ForceMode.Impulse);
        } 

    }
}
