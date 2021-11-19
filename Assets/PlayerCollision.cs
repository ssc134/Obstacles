using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collisionInfo)
    {
        PlayerMovement pm = GameObject.Find("Player").GetComponent<PlayerMovement>();
        Debug.Log($"Collision Detected with {collisionInfo.collider.name}");
        if (collisionInfo.collider.tag == "Obstacle")
            pm.enabled = false;
    }

}
