using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    
    public Animator boton;
    public Animator Puerta;
    void Start()
    {
        boton.SetBool ("On",false);
        Puerta.SetBool ("Abierta",false );
    }

   void OnTriggerEnter (Collider collider){
       boton.SetBool ("On",true);
       Puerta.SetBool ("Abierta",true);
       Debug.Log("se esta abriendo");
   }
}
