using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_e2 : MonoBehaviour
{
    float moveSpeed = 1.0f;
    notificar_movimiento notificator;
    void Start()
    {
        notificator = GameObject.Find("controller").GetComponent<notificar_movimiento>();
        notificator.OnForwardColl += moveForward;
        notificator.OnBackColl += moveBack;
        notificator.OnRightColl += moveRight;
        notificator.OnLeftColl += moveLeft;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void moveForward()
    {
        transform.Translate((Vector3.forward * 35) * moveSpeed * Time.deltaTime);
    }

    void moveBack()
    {
        transform.Translate((Vector3.back * 35) * moveSpeed * Time.deltaTime);
    }

    void moveRight()
    {
        transform.Translate((Vector3.right * 35) * moveSpeed * Time.deltaTime);
    }

    void moveLeft()
    {
        transform.Translate((Vector3.left * 35)* moveSpeed * Time.deltaTime);
    }
}
