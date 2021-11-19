using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 1500f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
         
       Debug.Log("Player Object Initialised...");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody rb = GameObject.Find("Player").GetComponent<Rigidbody>();

        if(Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(-1 * sidewaysForce * Time.deltaTime/2, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(sidewaysForce * Time.deltaTime/2, 0, 0);
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if(rb.velocity[2]>=0)
                rb.AddForce(0, 0, -1 * forwardForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
            rb.AddForce(0, forwardForce * Time.deltaTime, 0);
    }
}
