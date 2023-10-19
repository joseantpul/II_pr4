using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notificar_movimiento : MonoBehaviour
{
    public delegate void buttonCollision();
    public event buttonCollision OnForwardColl;
    public event buttonCollision OnBackColl;
    public event buttonCollision OnLeftColl;
    public event buttonCollision OnRightColl;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        string button = collision.gameObject.name;
        if(button == "forwardbtn") {
            OnForwardColl();
        } else if(button == "backbtn") {
            OnBackColl();
        } else if(button == "rightbtn") {
            OnRightColl();
        } else if(button == "leftbtn") {
            OnLeftColl();
        }
    }
}
