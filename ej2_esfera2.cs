using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2_esfera2 : MonoBehaviour
{
    ej2_ecubo notificador;
    GameObject[] esferas2;
    void Start()
    {
        notificador = GameObject.Find("Cube").GetComponent<ej2_ecubo>();
        esferas2 = GameObject.FindGameObjectsWithTag("esfera_2");
        notificador.OnColisionCilindroAumentarTamano += aumentarTamano;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void aumentarTamano() {
        for (int i = 0; i < esferas2.Length; i++) {
            esferas2[i].transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        }
    }
}
