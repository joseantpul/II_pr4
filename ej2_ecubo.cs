using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2_ecubo : MonoBehaviour
{
    public delegate void colisionCilindro();
    public event colisionCilindro OnColisionCilindroMoverEsfera1;
    public event colisionCilindro OnColisionCilindroAumentarTamano;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
      if(other.gameObject.tag != "esfera_1") { // mover esfera1 al cilindro
        OnColisionCilindroMoverEsfera1();
      } else { // esferas2 aumentan de tamaño
        OnColisionCilindroAumentarTamano();
      }
    }

}
