using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulso : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust = 2f;


    private void Update()
    {
        
    
        if(Input.GetKeyDown(KeyCode.E))
        {
            rb.AddForce(0, 0, thrust, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Start"))

        {

            thrust = 10f;

        }


    }
     private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Start"))
        {
            thrust = 0;
        }
        
    }



}
