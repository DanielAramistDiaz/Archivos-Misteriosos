using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampas : MonoBehaviour
{
    
    public Animator trampas;
    
    void Start()
    {
        trampas.SetBool ("Si",false);
       
    }

   void OnTriggerEnter (Collider collider){
       trampas.SetBool ("Si",true);
       
       Debug.Log("Trampas Activadas");
   }
}
