using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 300f;
    public float jumpForce = 200f;

    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0,0, forwardForce * Time.deltaTime);
        }
    }


    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {

    // }
}
