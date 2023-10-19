using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//https://www.youtube.com/watch?v=ILONj0mBFPo&ab_channel=EmanGameDev

public class ej5_e : MonoBehaviour
{
    private int puntuacion = 0;
    TextMeshProUGUI tpuntuacion;
    void Start()
    {
      tpuntuacion = GameObject.Find("puntuacion").GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        tpuntuacion.text = "Puntuación: " + puntuacion.ToString();
    }

    private void OnTriggerEnter(Collider other) {
      if(other.gameObject.tag == "esfera_1")
      {
        puntuacion += 5;
        Debug.Log(puntuacion);
      } else if (other.gameObject.tag == "esfera_2")
      {
        puntuacion += 10;
        Debug.Log(puntuacion);
      }
    }
}
