using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento: MonoBehaviour
{
    private float v;
   
    [SerializeField] Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(0, 0, v);
    }
}
