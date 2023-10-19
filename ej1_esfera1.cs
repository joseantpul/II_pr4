using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_esfera1 : MonoBehaviour
{
    ej1_e notificador;
    GameObject[] esferas_1;
    // Start is called before the first frame update
    void Start()
    {
        notificador = GameObject.Find("Cube").GetComponent<ej1_e>();
        esferas_1 = GameObject.FindGameObjectsWithTag("esfera_1");
        notificador.OnColisionCilindro += cambiarColor;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void cambiarColor()
    {
        foreach (GameObject esfera in esferas_1)
        {
            float randomRed = Random.Range(0f, 1f);
            float randomGreen = Random.Range(0f, 1f);
            float randomBlue = Random.Range(0f, 1f);
            Color randomColor = new Color(randomRed, randomGreen, randomBlue);
            Renderer renderer = esfera.GetComponent<Renderer>();
            renderer.material.color = randomColor;
        } 

    }
}
