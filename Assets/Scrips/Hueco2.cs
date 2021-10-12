using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hueco2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
GameObject scripter = GameObject.Find("Scripter");
scripter.GetComponent<ScoreManager>().RaiseScore(2);
    }
 

}
