using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private bool Acostado = true;
    private Rigidbody rigid;

 
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        Vector3 inclinacion = Input.acceleration;
        if (Acostado) {
            inclinacion = Quaternion.Euler(90, 0, 0) * inclinacion;
            inclinacion.y = 0;

            rigid.AddForce(inclinacion *Time.deltaTime * 40);
            Debug.DrawRay(transform.position + Vector3.up, inclinacion, Color.red);
        }
    }
}
