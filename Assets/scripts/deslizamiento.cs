using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class deslizamiento : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("azul"))
        {
            Destroy(gameObject);
        }
        
        
    }

    


}
