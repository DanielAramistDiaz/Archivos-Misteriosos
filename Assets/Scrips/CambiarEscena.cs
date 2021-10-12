using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public int Escena;
    void OnTriggerEnter(Collider other){
        SceneManager    .LoadScene (Escena);
    }
}

 

 
