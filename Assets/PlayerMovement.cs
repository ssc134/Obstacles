using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 1500f;
    public float sidewaysForce = 1500f;

    // Start is called before the first frame update
    void Start()
    {
         
       Debug.Log("Player Object Initialised...");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody rb = GameObject.Find("Player").GetComponent<Rigidbody>();
        Transform tf = GameObject.Find("Player").GetComponent<Transform>();
        if(tf.position[1] <= 1.0f)
        {
            PlayerMovement pm = GameObject.Find("Player").GetComponent<PlayerMovement>();
            pm.enabled = false;
        }

        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(-1 * sidewaysForce * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if(rb.velocity[2]>=0)
                rb.AddForce(0, 0, -1 * forwardForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //Transform tf = GameObject.Find("Player").GetComponent<Transform>();
            if (tf.position[1] <= 1.51)
                rb.AddExplosionForce(500f, tf.position + new Vector3(0, -1.0f, 0), 3);
        }
    }
}
 