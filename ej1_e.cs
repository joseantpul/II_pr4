using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_e : MonoBehaviour
{
    public delegate void colisionCilindro();
    public event colisionCilindro OnColisionCilindro;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
      if(other.gameObject.tag == "cilindro") {
        OnColisionCilindro();
      }
    }
}
