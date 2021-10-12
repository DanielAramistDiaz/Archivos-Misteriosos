using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostArriba : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag =="Boost" )
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,0, 4000f) * Time.deltaTime, 0);
        
    }


}
