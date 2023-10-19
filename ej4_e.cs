using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://docs.unity3d.com/es/2018.4/Manual/UICanvas.html
//https://forum.unity.com/threads/middle-mouse-button-not-panning-in-scene-view.1113463/

public class ej4_e : MonoBehaviour
{
    int puntuacion = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
