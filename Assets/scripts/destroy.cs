using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject)
        {
            Destroy(GameObject.FindWithTag("red"));
        }

        //else if (collision.gameObject.CompareTag("red"))
       // {
         //   Destroy(GameObject.FindWithTag("BlueSlab"));
       // }
    }
}
