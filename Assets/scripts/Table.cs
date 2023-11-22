using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    public float jumpForce = 10f;
    public Rigidbody rb;

    

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("azul"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
    }

}
