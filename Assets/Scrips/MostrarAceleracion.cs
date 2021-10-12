using UnityEngine;

public class MostrarAceleracion : MonoBehaviour
{
    // Move object using accelerometer
    float speed = 500.0f;

    void Update()
    {
        Vector3 dir = Vector3.zero;

        
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

     
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

       
        dir *= Time.deltaTime;

        
        transform.Rotate(dir * speed);
    }
}